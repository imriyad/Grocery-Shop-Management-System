using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginAndRegistrationForm
{
    public partial class ProductShowForm : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\L\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30";

        public ProductShowForm()
        {
            InitializeComponent();
        }

        private void buttonClk_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Prodid ,ProdName,ProdPrice FROM ProductTbl", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ProductDGV.DataSource = dtbl;
            }
        }

        private void ProductDGV_SelectionChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow selectedRow in ProductDGV.SelectedRows)
            {
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    sb.Append($"{ProductDGV.Columns[cell.ColumnIndex].HeaderText}: {cell.Value}\t");
                }
                sb.AppendLine();
            }

            ShowPrRTB.AppendText(sb.ToString());
        }

        private void ProductShowForm_Load(object sender, EventArgs e)
        {
            ProductDGV.SelectionChanged += ProductDGV_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            this.Hide();
            pm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f13 = new Form1();
            this.Hide();
            f13.Show();
        }
    }
}
