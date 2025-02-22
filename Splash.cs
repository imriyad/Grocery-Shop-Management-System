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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int StartPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 5;
            MyProgress.Value = StartPoint;
            if(MyProgress.Value==100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
