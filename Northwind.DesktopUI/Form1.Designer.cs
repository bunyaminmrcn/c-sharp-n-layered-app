namespace Northwind.DesktopUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            groupBox1 = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            groupBox2 = new GroupBox();
            tbxProductName = new TextBox();
            textBox1 = new TextBox();
            lblName = new Label();
            gbxProductAdd = new GroupBox();
            btnAdd = new Button();
            tbxQuantityPU = new TextBox();
            tbxStock = new TextBox();
            tbxUnitPrice = new TextBox();
            cbxCategory2 = new ComboBox();
            tbxProductName2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnUpdate = new Button();
            tbxUpdateQuantity = new TextBox();
            tbxUpdateStock = new TextBox();
            tbxUpdatePrice = new TextBox();
            cbxUpdateCategory = new ComboBox();
            tbxUpdateName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbxProductAdd.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 226);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1112, 260);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxCategory);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Location = new Point(25, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1099, 86);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search by Category";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(116, 33);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(300, 28);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(26, 29);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 20);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Categories";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbxProductName);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblName);
            groupBox2.Location = new Point(25, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1099, 85);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search by Name";
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(116, 35);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(300, 27);
            tbxProductName.TabIndex = 1;
            tbxProductName.TextChanged += tbxProductName_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // gbxProductAdd
            // 
            gbxProductAdd.Controls.Add(btnAdd);
            gbxProductAdd.Controls.Add(tbxQuantityPU);
            gbxProductAdd.Controls.Add(tbxStock);
            gbxProductAdd.Controls.Add(tbxUnitPrice);
            gbxProductAdd.Controls.Add(cbxCategory2);
            gbxProductAdd.Controls.Add(tbxProductName2);
            gbxProductAdd.Controls.Add(label5);
            gbxProductAdd.Controls.Add(label4);
            gbxProductAdd.Controls.Add(label3);
            gbxProductAdd.Controls.Add(label2);
            gbxProductAdd.Controls.Add(label1);
            gbxProductAdd.Location = new Point(25, 509);
            gbxProductAdd.Name = "gbxProductAdd";
            gbxProductAdd.Size = new Size(496, 211);
            gbxProductAdd.TabIndex = 3;
            gbxProductAdd.TabStop = false;
            gbxProductAdd.Text = "Add New Product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(262, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxQuantityPU
            // 
            tbxQuantityPU.Location = new Point(365, 96);
            tbxQuantityPU.Name = "tbxQuantityPU";
            tbxQuantityPU.Size = new Size(109, 27);
            tbxQuantityPU.TabIndex = 9;
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(365, 42);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(109, 27);
            tbxStock.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(64, 150);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(192, 27);
            tbxUnitPrice.TabIndex = 7;
            // 
            // cbxCategory2
            // 
            cbxCategory2.FormattingEnabled = true;
            cbxCategory2.Location = new Point(105, 96);
            cbxCategory2.Name = "cbxCategory2";
            cbxCategory2.Size = new Size(151, 28);
            cbxCategory2.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            tbxProductName2.Location = new Point(72, 42);
            tbxProductName2.Name = "tbxProductName2";
            tbxProductName2.Size = new Size(184, 27);
            tbxProductName2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 99);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "QauntityPU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 42);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Stock Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 150);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "CategoryId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(tbxUpdateQuantity);
            groupBox3.Controls.Add(tbxUpdateStock);
            groupBox3.Controls.Add(tbxUpdatePrice);
            groupBox3.Controls.Add(cbxUpdateCategory);
            groupBox3.Controls.Add(tbxUpdateName);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(527, 509);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 211);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit Product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(262, 150);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(212, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUpdateQuantity
            // 
            tbxUpdateQuantity.Location = new Point(365, 96);
            tbxUpdateQuantity.Name = "tbxUpdateQuantity";
            tbxUpdateQuantity.Size = new Size(109, 27);
            tbxUpdateQuantity.TabIndex = 9;
            // 
            // tbxUpdateStock
            // 
            tbxUpdateStock.Location = new Point(365, 42);
            tbxUpdateStock.Name = "tbxUpdateStock";
            tbxUpdateStock.Size = new Size(109, 27);
            tbxUpdateStock.TabIndex = 8;
            // 
            // tbxUpdatePrice
            // 
            tbxUpdatePrice.Location = new Point(64, 150);
            tbxUpdatePrice.Name = "tbxUpdatePrice";
            tbxUpdatePrice.Size = new Size(192, 27);
            tbxUpdatePrice.TabIndex = 7;
            // 
            // cbxUpdateCategory
            // 
            cbxUpdateCategory.FormattingEnabled = true;
            cbxUpdateCategory.Location = new Point(105, 96);
            cbxUpdateCategory.Name = "cbxUpdateCategory";
            cbxUpdateCategory.Size = new Size(151, 28);
            cbxUpdateCategory.TabIndex = 6;
            // 
            // tbxUpdateName
            // 
            tbxUpdateName.Location = new Point(72, 42);
            tbxUpdateName.Name = "tbxUpdateName";
            tbxUpdateName.Size = new Size(184, 27);
            tbxUpdateName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 99);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 4;
            label6.Text = "QauntityPU";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 42);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 3;
            label7.Text = "Stock Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 150);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 2;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 99);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 1;
            label9.Text = "CategoryId";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 42);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 0;
            label10.Text = "Name";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(1029, 655);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Delete";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 732);
            Controls.Add(btnRemove);
            Controls.Add(groupBox3);
            Controls.Add(gbxProductAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbxProductAdd.ResumeLayout(false);
            gbxProductAdd.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private TextBox tbxProductName;
        private TextBox textBox1;
        private Label lblName;
        private GroupBox gbxProductAdd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxQuantityPU;
        private TextBox tbxStock;
        private TextBox tbxUnitPrice;
        private ComboBox cbxCategory2;
        private TextBox tbxProductName2;
        private Button btnAdd;
        private GroupBox groupBox3;
        private Button btnUpdate;
        private TextBox tbxUpdateQuantity;
        private TextBox tbxUpdateStock;
        private TextBox tbxUpdatePrice;
        private ComboBox cbxUpdateCategory;
        private TextBox tbxUpdateName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRemove;
    }
}
