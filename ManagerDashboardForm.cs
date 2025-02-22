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
    public partial class ManagerDashboardForm : Form
    {
        public ManagerDashboardForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm cf11 = new CategoryForm();
            this.Hide();
            cf11.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }
    }
}
