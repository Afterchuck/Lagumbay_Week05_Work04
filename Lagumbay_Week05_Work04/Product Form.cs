using System.Text.Json;

namespace Lagumbay_Week05_Work04
{
    public partial class Product_Form : Form
    {
        private readonly List<ProductRecord> products = new();
        private readonly string productsFilePath = Path.Combine(AppContext.BaseDirectory, "products.json");

        public Product_Form()
        {
            InitializeComponent();

            categoryCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            markup.ReadOnly = true;

            txtCost.TextChanged += CalculateMarkup;
            txtPrice.TextChanged += CalculateMarkup;
            saveBtn.Click += saveBtn_Click;
            clearBtn.Click += clearBtn_Click;
            cancelBtn.Click += cancelBtn_Click;

            LoadProducts();
            UpdateBarcodeStatus();
            CalculateMarkup(this, EventArgs.Empty);
        }

        private void LoadProducts()
        {
            if (!File.Exists(productsFilePath))
            {
                return;
            }

            try
            {
                string json = File.ReadAllText(productsFilePath);
                List<ProductRecord>? loadedProducts =
                    JsonSerializer.Deserialize<List<ProductRecord>>(json);

                if (loadedProducts is not null)
                {
                    products.AddRange(loadedProducts);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show(
                    "The product data file is not valid JSON. Existing records could not be loaded.",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "The product data file could not be read.",
                    "Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private bool BarcodeAlreadyExists(string barcode)
        {
            return products.Any(product =>
                string.Equals(product.Barcode, barcode, StringComparison.OrdinalIgnoreCase));
        }

        private void UpdateBarcodeStatus()
        {
            string barcode = txtBarcode.Text.Trim();

            if (barcode.Length == 0)
            {
                isBarAvail.Text = "Barcode is required";
                isBarAvail.ForeColor = Color.Red;
            }
            else if (BarcodeAlreadyExists(barcode))
            {
                isBarAvail.Text = "Barcode already exists";
                isBarAvail.ForeColor = Color.Red;
            }
            else
            {
                isBarAvail.Text = "Barcode is available";
                isBarAvail.ForeColor = Color.Green;
            }
        }

        private bool TryGetDecimal(TextBox textBox, string fieldName, out decimal value, bool mustBeGreaterThanZero = false)
        {
            if (!decimal.TryParse(textBox.Text.Trim(), out value))
            {
                MessageBox.Show(
                    $"Please enter a valid number for {fieldName}.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            if (value < 0 || (mustBeGreaterThanZero && value <= 0))
            {
                string requirement = mustBeGreaterThanZero
                    ? $"{fieldName} must be greater than zero."
                    : $"{fieldName} cannot be negative.";

                MessageBox.Show(
                    requirement,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateForm(out decimal cost, out decimal price)
        {
            cost = 0;
            price = 0;

            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Barcode is required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return false;
            }

            if (BarcodeAlreadyExists(txtBarcode.Text.Trim()))
            {
                MessageBox.Show("This barcode is already registered.", "Duplicate Barcode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescr.Text))
            {
                MessageBox.Show("Product description is required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescr.Focus();
                return false;
            }

            if (categoryCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryCmb.Focus();
                return false;
            }

            if (!localRadio.Checked && !abroadRadio.Checked)
            {
                MessageBox.Show("Please select Local or Abroad.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                manufactured.Focus();
                return false;
            }

            if (!TryGetDecimal(txtCost, "Cost", out cost, mustBeGreaterThanZero: true))
            {
                return false;
            }

            if (!TryGetDecimal(txtPrice, "Price", out price, mustBeGreaterThanZero: false))
            {
                return false;
            }

            return true;
        }

        private void txtBarcode_TextChanged(object? sender, EventArgs e) => UpdateBarcodeStatus();

        private void txtName_TextChanged(object? sender, EventArgs e) { }

        private void txtDescr_TextChanged(object? sender, EventArgs e) { }

        private void categoryCmb_SelectedIndexChanged(object? sender, EventArgs e) { }

        private void abroadRadio_CheckedChanged(object? sender, EventArgs e) { }

        private void CalculateMarkup(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtCost.Text.Trim(), out decimal cost)
                && decimal.TryParse(txtPrice.Text.Trim(), out decimal price)
                && cost > 0)
            {
                decimal markupPercentage = ((price - cost) / cost) * 100;
                markup.Text = markupPercentage.ToString("0.00");
            }
            else
            {
                markup.Clear();
            }
        }

        private void saveBtn_Click(object? sender, EventArgs e)
        {
            if (!ValidateForm(out decimal cost, out decimal price))
            {
                return;
            }

            decimal markupPercentage = ((price - cost) / cost) * 100;
            string origin = localRadio.Checked ? "Local" : "Abroad";

            ProductRecord product = new()
            {
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Description = txtDescr.Text.Trim(),
                Category = categoryCmb.Text,
                Origin = origin,
                IsActive = isActiveChk.Checked,
                Cost = cost,
                Price = price,
                Markup = markupPercentage
            };

            try
            {
                products.Add(product);

                JsonSerializerOptions options = new() { WriteIndented = true };
                string json = JsonSerializer.Serialize(products, options);
                File.WriteAllText(productsFilePath, json);

                MessageBox.Show(
                    "Product saved successfully.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearForm();
            }
            catch (IOException)
            {
                products.Remove(product);
                MessageBox.Show(
                    "The product could not be saved because the data file could not be written.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object? sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescr.Clear();
            categoryCmb.SelectedIndex = -1;
            localRadio.Checked = false;
            abroadRadio.Checked = false;
            isActiveChk.Checked = false;
            txtCost.Clear();
            txtPrice.Clear();
            markup.Clear();
            txtBarcode.Focus();
            UpdateBarcodeStatus();
        }

        private void cancelBtn_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            using ProductListForm productListForm = new();
            productListForm.ShowDialog(this);
        }
    }
}
