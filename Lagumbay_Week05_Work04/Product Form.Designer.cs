namespace Lagumbay_Week05_Work04
{
    partial class Product_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBarcode = new TextBox();
            isBarAvail = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtDescr = new TextBox();
            label5 = new Label();
            categoryCmb = new ComboBox();
            label6 = new Label();
            manufactured = new GroupBox();
            abroadRadio = new RadioButton();
            localRadio = new RadioButton();
            label7 = new Label();
            isActiveChk = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCost = new TextBox();
            txtPrice = new TextBox();
            markup = new TextBox();
            cancelBtn = new Button();
            clearBtn = new Button();
            saveBtn = new Button();
            prodListBtn = new Button();
            manufactured.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Barcode";
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 10F);
            txtBarcode.Location = new Point(178, 34);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(383, 30);
            txtBarcode.TabIndex = 1;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // isBarAvail
            // 
            isBarAvail.AutoSize = true;
            isBarAvail.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            isBarAvail.ForeColor = SystemColors.AppWorkspace;
            isBarAvail.Location = new Point(178, 67);
            isBarAvail.Name = "isBarAvail";
            isBarAvail.Size = new Size(137, 20);
            isBarAvail.TabIndex = 2;
            isBarAvail.Text = "Barcode is available";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(51, 120);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(178, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(383, 30);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(51, 163);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // txtDescr
            // 
            txtDescr.BorderStyle = BorderStyle.None;
            txtDescr.Font = new Font("Segoe UI", 10F);
            txtDescr.ForeColor = SystemColors.ControlText;
            txtDescr.Location = new Point(178, 160);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.ScrollBars = ScrollBars.Horizontal;
            txtDescr.Size = new Size(383, 81);
            txtDescr.TabIndex = 6;
            txtDescr.TextChanged += txtDescr_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(51, 257);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 7;
            label5.Text = "Category";
            // 
            // categoryCmb
            // 
            categoryCmb.BackColor = SystemColors.Window;
            categoryCmb.Font = new Font("Segoe UI", 10F);
            categoryCmb.ForeColor = SystemColors.ControlText;
            categoryCmb.FormattingEnabled = true;
            categoryCmb.Items.AddRange(new object[] { "Electronics", "Food", "Clothing", "School Supplies", "Others" });
            categoryCmb.Location = new Point(178, 256);
            categoryCmb.Name = "categoryCmb";
            categoryCmb.Size = new Size(383, 31);
            categoryCmb.TabIndex = 8;
            categoryCmb.SelectedIndexChanged += categoryCmb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(51, 301);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 9;
            label6.Text = "Origin";
            // 
            // manufactured
            // 
            manufactured.Controls.Add(abroadRadio);
            manufactured.Controls.Add(localRadio);
            manufactured.Location = new Point(178, 301);
            manufactured.Name = "manufactured";
            manufactured.Size = new Size(383, 76);
            manufactured.TabIndex = 10;
            manufactured.TabStop = false;
            manufactured.Text = "Manufactured";
            // 
            // abroadRadio
            // 
            abroadRadio.AutoSize = true;
            abroadRadio.Location = new Point(162, 36);
            abroadRadio.Name = "abroadRadio";
            abroadRadio.Size = new Size(80, 24);
            abroadRadio.TabIndex = 1;
            abroadRadio.TabStop = true;
            abroadRadio.Text = "Abroad";
            abroadRadio.UseVisualStyleBackColor = true;
            abroadRadio.CheckedChanged += abroadRadio_CheckedChanged;
            // 
            // localRadio
            // 
            localRadio.AutoSize = true;
            localRadio.Location = new Point(46, 36);
            localRadio.Name = "localRadio";
            localRadio.Size = new Size(65, 24);
            localRadio.TabIndex = 0;
            localRadio.TabStop = true;
            localRadio.Text = "Local";
            localRadio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(51, 392);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // isActiveChk
            // 
            isActiveChk.AutoSize = true;
            isActiveChk.Font = new Font("Segoe UI", 10F);
            isActiveChk.Location = new Point(178, 392);
            isActiveChk.Name = "isActiveChk";
            isActiveChk.Size = new Size(78, 27);
            isActiveChk.TabIndex = 12;
            isActiveChk.Text = "Active";
            isActiveChk.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(52, 441);
            label8.Name = "label8";
            label8.Size = new Size(44, 23);
            label8.TabIndex = 13;
            label8.Text = "Cost";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(178, 441);
            label9.Name = "label9";
            label9.Size = new Size(47, 23);
            label9.TabIndex = 14;
            label9.Text = "Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(473, 441);
            label10.Name = "label10";
            label10.Size = new Size(97, 23);
            label10.TabIndex = 15;
            label10.Text = "Markup (%)";
            // 
            // txtCost
            // 
            txtCost.Font = new Font("Segoe UI", 10F);
            txtCost.Location = new Point(52, 467);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(79, 30);
            txtCost.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(178, 467);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(79, 30);
            txtPrice.TabIndex = 17;
            // 
            // markup
            // 
            markup.Font = new Font("Segoe UI", 10F);
            markup.Location = new Point(473, 467);
            markup.Name = "markup";
            markup.Size = new Size(147, 30);
            markup.TabIndex = 18;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.Location = new Point(41, 518);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(124, 49);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 10F);
            clearBtn.Location = new Point(191, 518);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(124, 49);
            clearBtn.TabIndex = 20;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 10F);
            saveBtn.Location = new Point(485, 518);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(124, 49);
            saveBtn.TabIndex = 21;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // prodListBtn
            // 
            prodListBtn.Location = new Point(8, 5);
            prodListBtn.Name = "prodListBtn";
            prodListBtn.Size = new Size(115, 29);
            prodListBtn.TabIndex = 22;
            prodListBtn.Text = "Product Lists";
            prodListBtn.UseVisualStyleBackColor = true;
            prodListBtn.Click += this.button1_Click;
            // 
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 579);
            Controls.Add(prodListBtn);
            Controls.Add(saveBtn);
            Controls.Add(clearBtn);
            Controls.Add(cancelBtn);
            Controls.Add(markup);
            Controls.Add(txtPrice);
            Controls.Add(txtCost);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(isActiveChk);
            Controls.Add(label7);
            Controls.Add(manufactured);
            Controls.Add(label6);
            Controls.Add(categoryCmb);
            Controls.Add(label5);
            Controls.Add(txtDescr);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(isBarAvail);
            Controls.Add(txtBarcode);
            Controls.Add(label1);
            Name = "Product_Form";
            Text = "Product_Form";
            manufactured.ResumeLayout(false);
            manufactured.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBarcode;
        private Label isBarAvail;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtDescr;
        private Label label5;
        private ComboBox categoryCmb;
        private Label label6;
        private GroupBox manufactured;
        private RadioButton localRadio;
        private RadioButton abroadRadio;
        private Label label7;
        private CheckBox isActiveChk;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCost;
        private TextBox txtPrice;
        private TextBox markup;
        private Button cancelBtn;
        private Button clearBtn;
        private Button saveBtn;
        private Button prodListBtn;
    }
}