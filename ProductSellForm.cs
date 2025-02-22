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
    public partial class ProductSellForm : Form
    {
        public ProductSellForm()
        {
            InitializeComponent();
        }

        private void ProductSellForm_Load(object sender, EventArgs e)
        {
            LTlabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

       

        private void MilkCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BananasCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PotatoTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheeseCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YogurtCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnionsCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RiceCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TomatoesCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BeefCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChickenCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Creamlabel_Click(object sender, EventArgs e)
        {

        }

        private void AppleCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if(AppleCB.Checked==true)
            {
                AppleTB.Enabled = true;

            } 
            if(AppleCB.Checked==false)
            {
                AppleTB.Enabled = false;
                AppleTB.Text = "0";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TomatoesTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RiceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MilkTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BeefTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BananasTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnionsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheeseTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void YogurtTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MilkCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (MilkCB.Checked == true)
            {
                MilkTB.Enabled = true;

            }
            if (MilkCB.Checked == false)
            {
                MilkTB.Enabled = false;
                MilkTB.Text = "0";
            }
        }

        private void BeefCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BeefCB.Checked == true)
            {
                BeefTB.Enabled = true;

            }
            if (BeefCB.Checked == false)
            {
                BeefTB.Enabled = false;
                BeefTB.Text = "0";
            }
        }

        private void RiceCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RiceCB.Checked == true)
            {
                RiceTB.Enabled = true;

            }
            if (RiceCB.Checked == false)
            {
                RiceTB.Enabled = false;
                RiceTB.Text = "0";
            }
        }

        private void TomatoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (TomatoCB.Checked == true)
            {
                TomatoTB.Enabled = true;

            }
            if (TomatoCB.Checked == false)
            {
                TomatoTB.Enabled = false;
                TomatoTB.Text = "0";
            }
        }

        private void BananaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BananaCB.Checked == true)
            {
                BananaTB.Enabled = true;

            }
            if (BananaCB.Checked == false)
            {
                BananaTB.Enabled = false;
                BananaTB.Text = "0";
            }
        }

        private void CheeseCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheeseCB.Checked == true)
            {
                CheeseTB.Enabled = true;

            }
            if (CheeseCB.Checked == false)
            {
                CheeseTB.Enabled = false;
                CheeseTB.Text = "0";
            }
        }

        private void YogurtCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (YogurtCB.Checked == true)
            {
                YogurtTB.Enabled = true;

            }
            if (YogurtCB.Checked == false)
            {
                YogurtTB.Enabled = false;
                YogurtTB.Text = "0";
            }
        }

        private void OnionCB_CheckedChanged(object sender, EventArgs e)
        {
            if (OnionCB.Checked == true)
            {
                OnionTB.Enabled = true;

            }
            if (OnionCB.Checked == false)
            {
                OnionTB.Enabled = false;
                OnionTB.Text = "0";
            }
        }

        private void ChickenCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ChickenCB.Checked == true)
            {
                ChickenTB.Enabled = true;

            }
            if (ChickenCB.Checked == false)
            {
                ChickenTB.Enabled = false;
                ChickenTB.Text = "0";
            }
        }

        private void LTlabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LTlabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {
            BeefCB.Checked = false;
            AppleCB.Checked = false;
            MilkCB.Checked = false;
            RiceCB.Checked = false;
            
            TomatoCB.Checked = false;
            BananaCB.Checked = false;
            CheeseCB.Checked = false;

            YogurtCB.Checked = false;
            OnionCB.Checked = false;
            ChickenCB.Checked = false; 
        }
        double BeefPrice=595, ApplePrice=240, MilkPrice=90, RicePrice=75, TomatoPrice=50, BananaPrice=40, CheesePrice=350, YogurtPrice=110, OnionPrice=70, ChickenPrice=250;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 f88 = new Form1();
            this.Hide();
            f88.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ProductShowForm psf = new ProductShowForm();
            this.Hide();
            psf.Show();
        }

        private void Babyshoplabel_Click(object sender, EventArgs e)
        {

        }

        private void TkLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TkLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Display.Text + "Sub Total : " + Subtotal + "\nTax : " + Tax, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Black, new Point(130));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        double Subtotal =0, Tax=0, GrandTotal=0;

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            BeefPrice = BeefPrice * Convert.ToDouble(BeefTB.Text);
            ApplePrice = ApplePrice * Convert.ToDouble(AppleTB.Text);
            MilkPrice = MilkPrice * Convert.ToDouble(MilkTB.Text);
            RicePrice = RicePrice * Convert.ToDouble(RiceTB.Text);
            TomatoPrice = TomatoPrice * Convert.ToDouble(TomatoTB.Text);


            BananaPrice = BananaPrice * Convert.ToDouble(BananaTB.Text);
            CheesePrice = CheesePrice * Convert.ToDouble(CheeseTB.Text);
            YogurtPrice = YogurtPrice * Convert.ToDouble(YogurtTB.Text);
            OnionPrice = OnionPrice * Convert.ToDouble(OnionTB.Text);
            ChickenPrice = ChickenPrice * Convert.ToDouble(ChickenTB.Text);
            Subtotal = 0;


            Display.Clear();
           
            /*Tax = 0;
            GrandTotal = 0;*/

            Display.AppendText(Environment.NewLine);
            Display.AppendText("-----------Sir er Dua Grocery Shop---------------"+LTlabel.Text+ Environment.NewLine);
            Display.AppendText("--------------------------------------------------"+ Environment.NewLine);


            if (BeefCB.Checked == true)
            {
                double BeefPrice = 595 * Convert.ToDouble(BeefTB.Text);
                Display.AppendText("\tBeef: \t" + BeefPrice + " Tk" + Environment.NewLine);
                Subtotal += BeefPrice;
            }
            if (AppleCB.Checked == true)
            {
                double ApplePrice = 240 * Convert.ToDouble(AppleTB.Text);
                Display.AppendText("\tApple: \t" + ApplePrice + " Tk" + Environment.NewLine);
                Subtotal += ApplePrice;
            }

            if (MilkCB.Checked == true)
            {
                double MilkPrice = 90 * Convert.ToDouble(MilkTB.Text);
                Display.AppendText("\tMilk: \t" + MilkPrice + " Tk" + Environment.NewLine);
                Subtotal += MilkPrice;
            }

            if (RiceCB.Checked == true)
            {
                double RicePrice = 75 * Convert.ToDouble(RiceTB.Text);
                Display.AppendText("\tRice: \t" + RicePrice + " Tk" + Environment.NewLine);
                Subtotal += RicePrice;
            }

            if (TomatoCB.Checked == true)
            {
                double TomatoPrice = 50 * Convert.ToDouble(TomatoTB.Text);
                Display.AppendText("\tTomato: \t" + TomatoPrice + " Tk" + Environment.NewLine);
                Subtotal += TomatoPrice;
            }

            if (BananaCB.Checked == true)
            {
                double BananaPrice = 40 * Convert.ToDouble(BananaTB.Text);
                Display.AppendText("\tBanana: \t" + BananaPrice + " Tk" + Environment.NewLine);
                Subtotal += BananaPrice;
            }

            if (CheeseCB.Checked == true)
            {
                double CheesePrice = 350 * Convert.ToDouble(CheeseTB.Text);
                Display.AppendText("\tCheese: \t" + CheesePrice + " Tk" + Environment.NewLine);
                Subtotal += CheesePrice;
            }

            if (YogurtCB.Checked == true)
            {
                double YogurtPrice = 110 * Convert.ToDouble(YogurtTB.Text);
                Display.AppendText("\tYogurt: \t" + YogurtPrice + " Tk" + Environment.NewLine);
                Subtotal += YogurtPrice;           
            }

            if (OnionCB.Checked == true)
            {
                double OnionPrice = 70 * Convert.ToDouble(OnionTB.Text);
                Display.AppendText("\tOnion: \t" + OnionPrice + " Tk" + Environment.NewLine);
                Subtotal += OnionPrice;
            }

            if (ChickenCB.Checked == true)
            {
                double ChickenPrice = 250 * Convert.ToDouble(ChickenTB.Text);
                Display.AppendText("\tChicken: \t" + ChickenPrice + " Tk" + Environment.NewLine);
                Subtotal += ChickenPrice;
            }

            Tax = Subtotal*0.15;
            GrandTotal = Subtotal + Tax;
            TkLabel2.Text = "Tk" + Tax;
            TkLabel3.Text = "Tk" + GrandTotal;
        }
    }
}
