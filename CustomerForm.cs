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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            CustomerDGV.CellClick += CustomerDGV_CellClick;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
                if (CustomerDGV.SelectedRows.Count > 0)
                {
                    try
                    {
                        Con.Open();
                        int rowIndex = CustomerDGV.SelectedRows[0].Index;
                        string customerId = CustomerDGV.Rows[rowIndex].Cells["Email"].Value.ToString(); // Assuming there's a column named "Email"
                        string query = "UPDATE CRegTbl SET FName = @FName, LName = @LName, Email = @Email, Phone = @Phone, Password = @Password WHERE Email = @Email";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@FName", CFNameTB.Text);
                        cmd.Parameters.AddWithValue("@LName", CLNameTB.Text);
                        cmd.Parameters.AddWithValue("@Email", CEmailTB.Text);
                        cmd.Parameters.AddWithValue("@Phone", CPhoneTB.Text);
                        cmd.Parameters.AddWithValue("@Password", CPasswordTB.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Updated Successfully");
                        Con.Close();
                        populate(); // Refresh DataGridView
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
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            

        }

        SqlConnection Con = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=LoginTbl;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from CRegTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CFNameTB.Text == "" || CLNameTB.Text == "" ||CEmailTB.Text == "" || CPhoneTB.Text == "" || CPasswordTB.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }
            try
            {
                Con.Open();
                string query = "insert into CRegTbl values('" + CFNameTB.Text + "','" + CLNameTB.Text + "','" + CEmailTB.Text + "','" + CPhoneTB.Text + "','" + CPasswordTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");

               /* Form1 f = new Form1();
                this.Hide();
                f.Show();
*/
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
        private void CustomerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerDGV.Rows[e.RowIndex];

                CFNameTB.Text = row.Cells["FName"].Value.ToString();
                CLNameTB.Text = row.Cells["LName"].Value.ToString();
                CEmailTB.Text = row.Cells["Email"].Value.ToString();
                CPhoneTB.Text = row.Cells["Phone"].Value.ToString();
                CPasswordTB.Text = row.Cells["Password"].Value.ToString();
            }
        }



        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

                CFNameTB.Text = "";
                CLNameTB.Text = "";
                CEmailTB.Text = "";
                CPhoneTB.Text = "";
                CPasswordTB.Text = "";
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
              if (CustomerDGV.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Con.Open();
                            int rowIndex = CustomerDGV.SelectedRows[0].Index;
                            string customerId = CustomerDGV.Rows[rowIndex].Cells["Email"].Value.ToString(); // Assuming there's a column named "CustomerId"
                            string query = "DELETE FROM CRegTbl WHERE Email = @Email";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.Parameters.AddWithValue("@Email", customerId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer Deleted Successfully");
                            Con.Close();
                            populate(); // Refresh DataGridView
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
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm adf43 = new AdminForm();
            this.Hide();
            adf43.Show();
        }
    }
}
