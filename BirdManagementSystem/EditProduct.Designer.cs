namespace Bird.APP
{
    partial class EditProduct
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_productname = new TextBox();
            txt_description = new TextBox();
            txt_quantity = new TextBox();
            txt_price = new TextBox();
            txt_image = new TextBox();
            btn_save = new Button();
            btn_close = new Button();
            cb_category = new ComboBox();
            dtg_product = new DataGridView();
            label8 = new Label();
            txt_productid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_product).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 176);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 251);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 333);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 415);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 482);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 4;
            label5.Text = "Category Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 564);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Image URL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(119, 23);
            label7.Name = "label7";
            label7.Size = new Size(193, 41);
            label7.TabIndex = 6;
            label7.Text = "Edit Product";
            // 
            // txt_productname
            // 
            txt_productname.Location = new Point(150, 173);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(253, 27);
            txt_productname.TabIndex = 7;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(150, 248);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(253, 27);
            txt_description.TabIndex = 8;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(150, 330);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(253, 27);
            txt_quantity.TabIndex = 9;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(150, 412);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(253, 27);
            txt_price.TabIndex = 10;
            // 
            // txt_image
            // 
            txt_image.Location = new Point(150, 561);
            txt_image.Name = "txt_image";
            txt_image.Size = new Size(253, 27);
            txt_image.TabIndex = 12;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(97, 622);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 13;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(266, 622);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(94, 29);
            btn_close.TabIndex = 14;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(150, 482);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(253, 28);
            cb_category.TabIndex = 15;
            // 
            // dtg_product
            // 
            dtg_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_product.Location = new Point(446, 76);
            dtg_product.Name = "dtg_product";
            dtg_product.RowHeadersWidth = 51;
            dtg_product.RowTemplate.Height = 29;
            dtg_product.Size = new Size(850, 462);
            dtg_product.TabIndex = 16;
            dtg_product.CellClick += dtg_product_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 99);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 17;
            label8.Text = "ProductID";
            // 
            // txt_productid
            // 
            txt_productid.Location = new Point(150, 96);
            txt_productid.Name = "txt_productid";
            txt_productid.Size = new Size(253, 27);
            txt_productid.TabIndex = 18;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 707);
            Controls.Add(txt_productid);
            Controls.Add(label8);
            Controls.Add(dtg_product);
            Controls.Add(cb_category);
            Controls.Add(btn_close);
            Controls.Add(btn_save);
            Controls.Add(txt_image);
            Controls.Add(txt_price);
            Controls.Add(txt_quantity);
            Controls.Add(txt_description);
            Controls.Add(txt_productname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduct";
            Load += EditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_productname;
        private TextBox txt_description;
        private TextBox txt_quantity;
        private TextBox txt_price;
        private TextBox txt_image;
        private Button btn_save;
        private Button btn_close;
        private ComboBox cb_category;
        private DataGridView dtg_product;
        private Label label8;
        private TextBox txt_productid;
    }
}