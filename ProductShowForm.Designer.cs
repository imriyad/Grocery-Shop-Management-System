
namespace LoginAndRegistrationForm
{
    partial class ProductShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductShowForm));
            this.ProductDGV = new System.Windows.Forms.DataGridView();
            this.buttonClk = new System.Windows.Forms.Button();
            this.ShowPrRTB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDGV
            // 
            this.ProductDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDGV.Location = new System.Drawing.Point(29, 158);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 26;
            this.ProductDGV.Size = new System.Drawing.Size(427, 335);
            this.ProductDGV.TabIndex = 0;
            // 
            // buttonClk
            // 
            this.buttonClk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClk.Location = new System.Drawing.Point(29, 113);
            this.buttonClk.Name = "buttonClk";
            this.buttonClk.Size = new System.Drawing.Size(427, 34);
            this.buttonClk.TabIndex = 63;
            this.buttonClk.Text = "Click To see Available Products";
            this.buttonClk.UseVisualStyleBackColor = true;
            this.buttonClk.Click += new System.EventHandler(this.buttonClk_Click);
            // 
            // ShowPrRTB
            // 
            this.ShowPrRTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPrRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowPrRTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrRTB.Location = new System.Drawing.Point(576, 158);
            this.ShowPrRTB.Name = "ShowPrRTB";
            this.ShowPrRTB.Size = new System.Drawing.Size(427, 335);
            this.ShowPrRTB.TabIndex = 64;
            this.ShowPrRTB.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(838, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 65;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(28, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(606, 40);
            this.label6.TabIndex = 66;
            this.label6.Text = "Available Products From Database";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "Your Selected Products : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OldLace;
            this.button2.Location = new System.Drawing.Point(433, 670);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 40);
            this.button2.TabIndex = 68;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1279, 752);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPrRTB);
            this.Controls.Add(this.buttonClk);
            this.Controls.Add(this.ProductDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductShowForm";
            this.Text = "ProductShowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDGV;
        private System.Windows.Forms.Button buttonClk;
        private System.Windows.Forms.RichTextBox ShowPrRTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}