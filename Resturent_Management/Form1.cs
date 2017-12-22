using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtRice.Text = "0";
            txtSoup.Text = "0";
            txtTahari.Text = "0";
            txtVegetable.Text = "0";
            txtVorta.Text = "0";
            txtWon.Text = "0";
            txtMorog.Text = "0";
            txtFry.Text = "0";
            txtEgg.Text = "0";
            txtDal.Text = "0";
            txtCutlet.Text = "0";
            txtChow.Text = "0";
            txtChoup.Text = "0";
            txtBiriany.Text = "0";
            txtElish.Text = "0";
            txtPrawn.Text = "0";
            lblCostOfDrink.Text = "0";
            lblCostOfFood.Text = "0";
            lblCharge.Text = "1.75";

            ckAmerican.Checked = false;
            ckBall.Checked = false;
            ckBiriany.Checked = false;
            ckCowmin.Checked = false;
            ckCutlet.Checked = false;
            ckDal.Checked = false;
            ckEgg.Checked = false;
            ckElish.Checked = false;
            ckFry.Checked = false;
            ckMorog.Checked = false;
            ckRice.Checked = false;
            ckSoup.Checked = false;
            ckTahari.Checked = false;
            ckVegetable.Checked = false;
            ckVorta.Checked = false;
            ckWon.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtRice.Text = "0";
            txtSoup.Text = "0";
            txtTahari.Text = "0";
            txtVegetable.Text = "0";
            txtVorta.Text = "0";
            txtWon.Text = "0";
            txtMorog.Text = "0";
            txtFry.Text = "0";
            txtEgg.Text = "0";
            txtDal.Text = "0";
            txtCutlet.Text = "0";
            txtChow.Text = "0";
            txtChoup.Text = "0";
            txtBiriany.Text = "0";
            txtElish.Text = "0";
            txtPrawn.Text = "0";
            lblCostOfDrink.Text = "0";
            lblCostOfFood.Text = "0";
            lblCharge.Text = "1.75";

            txtRice.Enabled = false;
            txtSoup.Enabled = false;
            txtTahari.Enabled = false;
            txtVegetable.Enabled = false;
            txtVorta.Enabled = false;
            txtWon.Enabled = false;
            txtMorog.Enabled = false;
            txtFry.Enabled = false;
            txtElish.Enabled = false;
            txtEgg.Enabled = false;
            txtDal.Enabled = false;
            txtCutlet.Enabled = false;
            txtChow.Enabled = false;
            txtChoup.Enabled = false;
            txtBiriany.Enabled = false;
            txtPrawn.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckRice_CheckedChanged(object sender, EventArgs e)
        {
            if(ckRice.Checked==true)
            {
                txtRice.Enabled = true;
            }
            else if (ckRice.Checked == false)
            {
                txtRice.Enabled = false;
                txtRice.Text = "0";
            }
        }

        private void txtRice_Click(object sender, EventArgs e)
        {
            txtRice.Text = "";
            txtRice.Focus();
        }

        private void ckEgg_CheckedChanged(object sender, EventArgs e)
        {
            if(ckEgg.Checked==true)
            {
                txtEgg.Enabled = true;
            }
            if (ckEgg.Checked == false)
            {
                txtEgg.Enabled = false;
                txtEgg.Text = "0";
            }
        }

        private void txtEgg_Click(object sender, EventArgs e)
        {
            txtEgg.Text = "";
            txtEgg.Focus();
        }

        private void ckDal_CheckedChanged(object sender, EventArgs e)
        {
            if(ckDal.Checked==true)
            {
                txtDal.Enabled = true;
            }
            if (ckDal.Checked == false)
            {
                txtDal.Enabled = false;
               
            }
        }

        private void txtDal_Click(object sender, EventArgs e)
        {
            txtDal.Text = "";
            txtDal.Focus();
        }

        private void ckFry_CheckedChanged(object sender, EventArgs e)
        {
            if(ckFry.Checked==true)
            {
                txtFry.Enabled = true;
            }
            if (ckFry.Checked == false)
            {
                txtFry.Enabled = false;
            }
        }

        private void txtFry_Click(object sender, EventArgs e)
        {
            txtFry.Text = "";
            txtFry.Focus();
        }

        private void ckWon_CheckedChanged(object sender, EventArgs e)
        {
            if (ckWon.Checked == true)
            {
                txtWon.Enabled = true;
            }
            if (ckWon.Checked == false)
            {
                txtWon.Enabled = false;
            }
        }

        private void txtWon_Click(object sender, EventArgs e)
        {
            txtWon.Text = "";
            txtWon.Focus();
        }

        private void ckCowmin_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCowmin.Checked == true)
            {
                txtChow.Enabled = true;
            }
            if (ckCowmin.Checked == false)
            {
                txtChow.Enabled = false;
            }
        }

        private void txtChow_Click(object sender, EventArgs e)
        {
            txtChow.Text = "";
            txtChow.Focus();
        }

        private void ckBall_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBall.Checked == true)
            {
                txtPrawn.Enabled = true;
            }
            if (ckBall.Checked == false)
            {
                txtPrawn.Enabled = false;
            }
        }

        private void txtPrawn_Click(object sender, EventArgs e)
        {
            txtPrawn.Text = "";
            txtPrawn.Focus();
        }

        private void ckCutlet_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCutlet.Checked == true)
            {
                txtCutlet.Enabled = true;
            }
            if (ckCutlet.Checked == false)
            {
                txtCutlet.Enabled = false;
            }
        }

        private void txtCutlet_Click(object sender, EventArgs e)
        {
            txtCutlet.Text = "";
            txtCutlet.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //Open Text File
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //save Text FIle
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtReceipt.Text);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            //rtReceipt.AppendText(Environment.NewLine);
            rtReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine);
            rtReceipt.AppendText("\t" +"Just San Resaurant"+Environment.NewLine);
            rtReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);

            rtReceipt.AppendText("Rice t\t\t\t"+txtRice.Text+ Environment.NewLine);
            rtReceipt.AppendText("American Coffee \t\t" + txtEgg.Text + Environment.NewLine);
            rtReceipt.AppendText("African Coffee \t\t" + txtDal.Text + Environment.NewLine);
            rtReceipt.AppendText("Cappuccino \t\t" + txtFry.Text + Environment.NewLine);
            rtReceipt.AppendText("Fried Wonthone \t\t" + txtWon.Text + Environment.NewLine);
            rtReceipt.AppendText("Chicken Chowmein \t\t" + txtChow.Text + Environment.NewLine);
            rtReceipt.AppendText("Fried Prawn Ball \t\t" + txtPrawn.Text + Environment.NewLine);
            rtReceipt.AppendText("Chicken Cutlet \t\t" + txtCutlet.Text + Environment.NewLine);
            rtReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine);
            rtReceipt.AppendText("Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rtReceipt.AppendText("Sub Total \t\t" + lblSub.Text + Environment.NewLine);
            rtReceipt.AppendText("Total \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtReceipt.AppendText("---------------------------------------------------------------" + Environment.NewLine);
            rtReceipt.AppendText(lblTime.Text + "\t\t"+ Environment.NewLine+lblDate.Text);
            rtReceipt.AppendText(Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double rice, am_Cof, af_cof, cap, won, chow, prawn, cutlet;
            double rice=1.20, am_Cof=1.30, af_cof=1.50, cap=1.75, won=1.77, chow=1.10, prawn=1.15, cutlet=1.75;
            double rice_f = Convert.ToDouble(txtRice.Text);
            double am_cof_d = Convert.ToDouble(txtEgg.Text);
            double af_d = Convert.ToDouble(txtDal.Text);
            double cap_d = Convert.ToDouble(txtFry.Text);
            double won_f = Convert.ToDouble(txtWon.Text);
            double  chow_f= Convert.ToDouble(txtChow.Text);
            double  prawn_f= Convert.ToDouble(txtPrawn.Text);
            double cut_f = Convert.ToDouble(txtCutlet.Text);

            Res ob = new Res(rice, am_Cof, af_cof, cap, won, chow, prawn, cutlet);

        }
    }
}
