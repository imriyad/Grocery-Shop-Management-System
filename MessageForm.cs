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
    public partial class MessageForm : Form
    {
        public static MessageForm a1;
        public MessageForm()
        {
            InitializeComponent();

            a1 = this;
            
        }
       
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            ReportInfo.a1.tb2.Text = tbMessage.Text;
            MessageBox.Show("Thanks for your Feedback ");
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportInfo rpf = new ReportInfo();
            rpf.Show();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
