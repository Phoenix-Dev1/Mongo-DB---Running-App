namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshProductsList = new System.Windows.Forms.Button();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_InsertProduct = new System.Windows.Forms.Button();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RefreshProductsList);
            this.groupBox1.Controls.Add(this.dataGridView_products);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Products";
            // 
            // btn_RefreshProductsList
            // 
            this.btn_RefreshProductsList.Location = new System.Drawing.Point(294, 251);
            this.btn_RefreshProductsList.Name = "btn_RefreshProductsList";
            this.btn_RefreshProductsList.Size = new System.Drawing.Size(150, 28);
            this.btn_RefreshProductsList.TabIndex = 1;
            this.btn_RefreshProductsList.Text = "Refresh Products List";
            this.btn_RefreshProductsList.UseVisualStyleBackColor = true;
            this.btn_RefreshProductsList.Click += new System.EventHandler(this.btn_RefreshProductsList_Click);
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Location = new System.Drawing.Point(24, 23);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.ReadOnly = true;
            this.dataGridView_products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_products.Size = new System.Drawing.Size(699, 222);
            this.dataGridView_products.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_InsertProduct);
            this.groupBox2.Controls.Add(this.textBox_ProductName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_ProductPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ProductCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(31, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Product:";
            // 
            // btn_InsertProduct
            // 
            this.btn_InsertProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_InsertProduct.Location = new System.Drawing.Point(668, 30);
            this.btn_InsertProduct.Name = "btn_InsertProduct";
            this.btn_InsertProduct.Size = new System.Drawing.Size(75, 28);
            this.btn_InsertProduct.TabIndex = 6;
            this.btn_InsertProduct.Text = "Insert";
            this.btn_InsertProduct.UseVisualStyleBackColor = true;
            this.btn_InsertProduct.Click += new System.EventHandler(this.btn_InsertProduct_Click);
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(294, 33);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(150, 22);
            this.textBox_ProductName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // textBox_ProductPrice
            // 
            this.textBox_ProductPrice.Location = new System.Drawing.Point(515, 33);
            this.textBox_ProductPrice.Name = "textBox_ProductPrice";
            this.textBox_ProductPrice.Size = new System.Drawing.Size(150, 22);
            this.textBox_ProductPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // textBox_ProductCode
            // 
            this.textBox_ProductCode.Location = new System.Drawing.Point(69, 33);
            this.textBox_ProductCode.Name = "textBox_ProductCode";
            this.textBox_ProductCode.Size = new System.Drawing.Size(150, 22);
            this.textBox_ProductCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_InsertProduct;
        private System.Windows.Forms.Button btn_RefreshProductsList;
    }
}

