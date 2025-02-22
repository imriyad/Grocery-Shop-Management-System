using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginAndRegistrationForm
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\L\Documents\smarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CategoryIDTB.Text) || string.IsNullOrWhiteSpace(CategoryNameTB.Text) ||
                   string.IsNullOrWhiteSpace(CategoryDescTB.Text))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }
                Con.Open();
                string query = "insert into CategoryTbl values(" + CategoryIDTB.Text + ",'" + CategoryNameTB.Text + "','" + CategoryDescTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();

                populate();
            }
            catch(Exception ex)
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
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoryForm_Load(object sender,EventArgs e)
        {
            populate();
        }
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CatDGV.Rows[e.RowIndex];

                CategoryIDTB.Text = row.Cells["Catid"].Value.ToString();
                CategoryNameTB.Text = row.Cells["CatName"].Value.ToString();
                CategoryDescTB.Text = row.Cells["CatDesc"].Value.ToString();
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatDGV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = CatDGV.SelectedRows[0];

                    int categoryId = Convert.ToInt32(selectedRow.Cells["Catid"].Value);

                    Con.Open();
                    string query = "delete from CategoryTbl where Catid = @CategoryId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    CatDGV.Rows.Remove(selectedRow);

                    MessageBox.Show("Category Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Select a category to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CategoryNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CategoryIDTB.Text))
                {
                    int categoryId = Convert.ToInt32(CategoryIDTB.Text);
                    string categoryName = CategoryNameTB.Text;
                    string categoryDesc = CategoryDescTB.Text;

                    Con.Open();
                    string query = "update CategoryTbl set CatName = @CategoryName, CatDesc = @CategoryDesc where Catid = @CategoryId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.Parameters.AddWithValue("@CategoryDesc", categoryDesc);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("Category Updated Successfully");

                    populate(); 
                }
                else
                {
                    MessageBox.Show("Select a category to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CategoryIDTB.Text = "";
            CategoryNameTB.Text = "";
            CategoryDescTB.Text = "";
        }

        private void CategoryForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm();
            pf.Show();
            this.Hide();
        }

        private void Sellers_Click(object sender, EventArgs e)
        {
            SellerForm sf = new SellerForm();
            sf.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           /* AdminForm ad = new AdminForm();
            this.Hide();
            ad.Show();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManagerDashboardForm mdf1 = new ManagerDashboardForm();
            this.Hide();
            mdf1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
           
                SqlCommand cmd = new SqlCommand("select * from CategoryTbl where Catid Like '%" + SearchTB.Text + "%'", Con);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                CatDGV.DataSource = dt;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
