using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
       
        private string GetSelectedPaymentMethod()
        {
            if (rbBkash.Checked) return "Your payment has been confirmed via Bkash";
            if (rbRocket.Checked) return "Your payment has been confirmed via Rocket";
            if (rbNagad.Checked) return "Your payment has been confirmed via Nagad";
            if (rbCard.Checked) return "Your payment has been confirmed via Card";
            return "Payment method is not selected";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Payment successful");
            ProductSell ps = new ProductSell();
            ps.Show();
            this.Hide();*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
      
        
        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void rbRocket_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbBkash_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAdd.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                (!rbBkash.Checked && !rbRocket.Checked && !rbNagad.Checked && !rbCard.Checked))
            {
                MessageBox.Show("Please fill in all fields and select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtResult.Clear();
            txtResult.Text += "*******************************\n";
            txtResult.Text += "Mayer Duwa Grocery Shop\n";
            txtResult.Text += "*******************************\n";
            txtResult.Text += "Date: " + DateTime.Now + "\n\n";

            txtResult.Text += "Name: " + txtName.Text + "\n\n";
            txtResult.Text += "Address: " + txtAdd.Text + "\n\n";
            txtResult.Text += "Phone: " + txtPhone.Text + "\n\n";
            txtResult.Text += "Amount: " + txtAmount.Text + "\n\n";

            string paymentMethod = GetSelectedPaymentMethod();
            txtResult.Text += "" + paymentMethod + "\n\n";

            txtResult.Text += "\n\n\n\n\n\nThank you for shopping with us\n";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAdd.Text = "";
            txtPhone.Text = "";
            txtAmount.Text = "";
            txtResult.Text = "";
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 5));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void rbNagad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void rbBkash_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FeedbackForm p12 = new FeedbackForm();
            this.Hide();
            p12.Show();
        }
    }



}
