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
    public partial class ReportInfo : Form
    {
        public static ReportInfo a1;
        public TextBox  tb2;
        public ReportInfo()
        {
            InitializeComponent();
            a1 = this;
            tb2 = TbReportShow;
            
        }

        private void ReportInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm msgf = new MessageForm();
            msgf.Show();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
          
           
        }

    }
}
