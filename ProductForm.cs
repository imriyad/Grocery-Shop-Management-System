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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TbFName_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\L\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillcombo()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCB.ValueMember = "catName";
            CatCB.DataSource = dt;

            Con.Close();
        }
       
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();

        }

        private void CatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbPhone_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ProdDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product to update");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName=@ProdName, ProdQty=@ProdQty, ProdPrice=@ProdPrice, ProdCat=@ProdCat where Prodid=@Prodid";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    //setting parameters for product id,product name.....and assign the values from the textboxes(ProductIdTB,ProductNameTB...)

                    cmd.Parameters.AddWithValue("@Prodid", ProductIdTB.Text);
                    cmd.Parameters.AddWithValue("@ProdName", ProductNameTB.Text);
                    cmd.Parameters.AddWithValue("@ProdQty", ProductQuantityTB.Text);
                    cmd.Parameters.AddWithValue("@ProdPrice", ProductPriceTB.Text);
                    cmd.Parameters.AddWithValue("@ProdCat", CatCB.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully");
                    Con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }

        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\L\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                if (ProdDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = ProdDGV.SelectedRows[0];
                    int productId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    con.Open();
                    string query = "delete from ProductTbl where prodid = @prodid";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@prodid", productId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");

                    ProdDGV.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Select a product to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ProductIdTB.Text) || string.IsNullOrWhiteSpace(ProductNameTB.Text) ||
                   string.IsNullOrWhiteSpace(ProductQuantityTB.Text) || string.IsNullOrWhiteSpace(ProductPriceTB.Text) )
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                Con.Open();
                string query = "insert into ProductTbl values(" + ProductIdTB.Text + ",'" + ProductNameTB.Text + "'," + ProductQuantityTB.Text + ","+ProductPriceTB.Text+",'"+CatCB.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();

                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void TbEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ProductIdTB.Text = "";
            ProductNameTB.Text = "";
            ProductQuantityTB.Text = "";
            ProductPriceTB.Text = "";

            //  selected index of the ComboBox is Set to -1 to clear selection
            CatCB.SelectedIndex = -1;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProdDGV.Rows[e.RowIndex];

                ProductIdTB.Text = row.Cells[0].Value.ToString();
                ProductNameTB.Text = row.Cells[1].Value.ToString();
                ProductQuantityTB.Text = row.Cells[2].Value.ToString();
                ProductPriceTB.Text = row.Cells[3].Value.ToString();
                CatCB.SelectedValue = row.Cells[4].Value.ToString();
            }
        }

        private void Sellers_Click(object sender, EventArgs e)
        {
            SellerForm sf = new SellerForm();
            sf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*AdminForm ad = new AdminForm();
            this.Hide();
            ad.Show();*/
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f12 = new Form1();
            this.Hide();
            f12.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
