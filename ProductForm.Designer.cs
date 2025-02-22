
namespace LoginAndRegistrationForm
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ProductPriceTB = new System.Windows.Forms.TextBox();
            this.ProductQuantityTB = new System.Windows.Forms.TextBox();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.ProductIdTB = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(858, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 27);
            this.label9.TabIndex = 43;
            this.label9.Text = "Product Informations";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ProdDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProdDGV.Location = new System.Drawing.Point(636, 117);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 51;
            this.ProdDGV.Size = new System.Drawing.Size(693, 544);
            this.ProdDGV.TabIndex = 42;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // CatCB
            // 
            this.CatCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CatCB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Location = new System.Drawing.Point(242, 393);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(313, 29);
            this.CatCB.TabIndex = 40;
            this.CatCB.Text = "Select Category";
            this.CatCB.SelectedIndexChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(335, 612);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 49);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.Location = new System.Drawing.Point(455, 612);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 49);
            this.buttonRemove.TabIndex = 38;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(335, 508);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ProductPriceTB
            // 
            this.ProductPriceTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPriceTB.Font = new System.Drawing.Font("Sans Serif Collection", 9F);
            this.ProductPriceTB.Location = new System.Drawing.Point(242, 311);
            this.ProductPriceTB.Multiline = true;
            this.ProductPriceTB.Name = "ProductPriceTB";
            this.ProductPriceTB.Size = new System.Drawing.Size(313, 46);
            this.ProductPriceTB.TabIndex = 34;
            this.ProductPriceTB.TextChanged += new System.EventHandler(this.TbPhone_TextChanged);
            // 
            // ProductQuantityTB
            // 
            this.ProductQuantityTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductQuantityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductQuantityTB.Font = new System.Drawing.Font("Sans Serif Collection", 9F);
            this.ProductQuantityTB.Location = new System.Drawing.Point(242, 244);
            this.ProductQuantityTB.Multiline = true;
            this.ProductQuantityTB.Name = "ProductQuantityTB";
            this.ProductQuantityTB.Size = new System.Drawing.Size(313, 46);
            this.ProductQuantityTB.TabIndex = 33;
            this.ProductQuantityTB.TextChanged += new System.EventHandler(this.TbEMail_TextChanged);
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductNameTB.Font = new System.Drawing.Font("Sans Serif Collection", 9F);
            this.ProductNameTB.Location = new System.Drawing.Point(242, 180);
            this.ProductNameTB.Multiline = true;
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(313, 46);
            this.ProductNameTB.TabIndex = 32;
            this.ProductNameTB.TextChanged += new System.EventHandler(this.TbUserName_TextChanged);
            // 
            // ProductIdTB
            // 
            this.ProductIdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIdTB.Font = new System.Drawing.Font("Sans Serif Collection", 9F);
            this.ProductIdTB.Location = new System.Drawing.Point(242, 119);
            this.ProductIdTB.Multiline = true;
            this.ProductIdTB.Name = "ProductIdTB";
            this.ProductIdTB.Size = new System.Drawing.Size(313, 46);
            this.ProductIdTB.TabIndex = 31;
            this.ProductIdTB.TextChanged += new System.EventHandler(this.TbFName_TextChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(455, 508);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 44);
            this.buttonClear.TabIndex = 30;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 253);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(39, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(390, 40);
            this.label6.TabIndex = 48;
            this.label6.Text = "MANAGE PRODUCTS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::LoginAndRegistrationForm.Properties.Resources.shopping;
            this.pictureBox5.Location = new System.Drawing.Point(455, 558);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::LoginAndRegistrationForm.Properties.Resources.update;
            this.pictureBox4.Location = new System.Drawing.Point(335, 558);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LoginAndRegistrationForm.Properties.Resources.clear;
            this.pictureBox3.Location = new System.Drawing.Point(455, 452);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LoginAndRegistrationForm.Properties.Resources.add_package;
            this.pictureBox2.Location = new System.Drawing.Point(335, 452);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LoginAndRegistrationForm.Properties.Resources.arrows;
            this.pictureBox1.Location = new System.Drawing.Point(16, 714);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1438, 776);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.CatCB);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.ProductPriceTB);
            this.Controls.Add(this.ProductQuantityTB);
            this.Controls.Add(this.ProductNameTB);
            this.Controls.Add(this.ProductIdTB);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox ProductPriceTB;
        private System.Windows.Forms.TextBox ProductQuantityTB;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.TextBox ProductIdTB;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}