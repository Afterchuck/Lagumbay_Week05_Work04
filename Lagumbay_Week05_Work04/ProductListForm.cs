using System.Text.Json;

namespace Lagumbay_Week05_Work04;

public class ProductListForm : Form
{
    private readonly DataGridView productsGrid = new();
    private readonly Label emptyMessage = new();
    private readonly string productsFilePath = Path.Combine(AppContext.BaseDirectory, "products.json");

    public ProductListForm()
    {
        Text = "Product List";
        StartPosition = FormStartPosition.CenterParent;
        Size = new Size(1_100, 500);
        MinimumSize = new Size(800, 350);

        productsGrid.Dock = DockStyle.Fill;
        productsGrid.AllowUserToAddRows = false;
        productsGrid.AllowUserToDeleteRows = false;
        productsGrid.AutoGenerateColumns = true;
        productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        productsGrid.ReadOnly = true;
        productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        productsGrid.MultiSelect = false;

        emptyMessage.Dock = DockStyle.Fill;
        emptyMessage.Text = "No saved products were found.";
        emptyMessage.TextAlign = ContentAlignment.MiddleCenter;
        emptyMessage.Visible = false;

        Controls.Add(productsGrid);
        Controls.Add(emptyMessage);

        Load += ProductListForm_Load;
    }

    private void ProductListForm_Load(object? sender, EventArgs e)
    {
        LoadProducts();
    }

    private void LoadProducts()
    {
        List<ProductRecord> products;

        if (!File.Exists(productsFilePath))
        {
            ShowEmptyMessage();
            return;
        }

        try
        {
            string json = File.ReadAllText(productsFilePath);
            products = JsonSerializer.Deserialize<List<ProductRecord>>(json) ?? new List<ProductRecord>();
        }
        catch (JsonException)
        {
            MessageBox.Show(
                "The product data file is not valid JSON.",
                "Load Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ShowEmptyMessage();
            return;
        }
        catch (IOException)
        {
            MessageBox.Show(
                "The product data file could not be read.",
                "Load Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            ShowEmptyMessage();
            return;
        }

        productsGrid.DataSource = products;
        emptyMessage.Visible = products.Count == 0;
        productsGrid.Visible = products.Count > 0;

        if (products.Count > 0)
        {
            ConfigureColumnHeaders();
        }
    }

    private void ConfigureColumnHeaders()
    {
        SetHeader("Barcode", "Barcode");
        SetHeader("Name", "Name");
        SetHeader("Description", "Description");
        SetHeader("Category", "Category");
        SetHeader("Origin", "Origin");
        SetHeader("IsActive", "Active");
        SetHeader("Cost", "Cost");
        SetHeader("Price", "Price");
        SetHeader("Markup", "Markup (%)");

        if (productsGrid.Columns["Cost"] is not null)
        {
            productsGrid.Columns["Cost"].DefaultCellStyle.Format = "0.00";
        }

        if (productsGrid.Columns["Price"] is not null)
        {
            productsGrid.Columns["Price"].DefaultCellStyle.Format = "0.00";
        }

        if (productsGrid.Columns["Markup"] is not null)
        {
            productsGrid.Columns["Markup"].DefaultCellStyle.Format = "0.00";
        }
    }

    private void SetHeader(string columnName, string headerText)
    {
        if (productsGrid.Columns[columnName] is not null)
        {
            productsGrid.Columns[columnName].HeaderText = headerText;
        }
    }

    private void ShowEmptyMessage()
    {
        productsGrid.DataSource = null;
        productsGrid.Visible = false;
        emptyMessage.Visible = true;
    }
}
