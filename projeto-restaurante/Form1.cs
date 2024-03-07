using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataLbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (FritasCb.Checked == true)
            {
                FritasTb.Enabled = true;
            }
            if (FritasCb.Checked == false)
            {
                FritasTb.Enabled = false;
                FritasTb.Text = "0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (SanduicheCb.Checked == true)
            {
                SanduicheTb.Enabled = true;
            }
            if (SanduicheCb.Checked == false)
            {
                SanduicheTb.Enabled = false;
                SanduicheTb.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladaCb.Checked == true)
            {
                SaladaTb.Enabled = true;
            }
            if (SaladaCb.Checked == false)
            {
                SaladaTb.Enabled = false;
                SaladaTb.Text = "0";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburguerCb.Checked == true)
            {
                HamburguerTb.Enabled = true;
            }
            if (HamburguerCb.Checked == false)
            {
                HamburguerTb.Enabled = false;
                HamburguerTb.Text = "0";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (NuggetsCb.Checked == true)
            {
                NuggetsTb.Enabled = true;
            }
            if (NuggetsCb.Checked == false)
            {
                NuggetsTb.Enabled = false;
                NuggetsTb.Text = "0";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (ChedarCb.Checked == true)
            {
                ChedarTb.Enabled = true;
            }
            if (ChedarCb.Checked == false)
            {
                ChedarTb.Enabled = false;
                ChedarTb.Text = "0";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (ChaGeladoCb.Checked == true)
            {
                ChaGeladoTb.Enabled = true;
            }
            if (ChaGeladoCb.Checked == false)
            {
                ChaGeladoTb.Enabled = false;
                ChaGeladoTb.Text = "0";
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaColaCb.Checked == true)
            {
                CocaColaTb.Enabled = true;
            }
            if (CocaColaCb.Checked == false)
            {
                CocaColaTb.Enabled = false;
                CocaColaTb.Text = "0";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void DataLbl_Click(object sender, EventArgs e)
        {

        }

        private void AguaMineralCb_CheckedChanged(object sender, EventArgs e)
        {
            if (AguaMineralCb.Checked == true)
            {
                AguaMineralTb.Enabled = true;
            }
            if (AguaMineralCb.Checked == false)
            {
                AguaMineralTb.Enabled = false;
                AguaMineralTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PanquecaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PanquecaCb.Checked == true)
            {
                PanquecaTb.Enabled = true;
            }
            if (PanquecaCb.Checked == false)
            {
                PanquecaTb.Enabled = false;
                PanquecaTb.Text = "0";
            }
        }

        private void SucoDeFrutaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SucoDeFrutaCb.Checked == true)
            {
                SucoDeFrutaTb.Enabled = true;
            }
            if (SucoDeFrutaCb.Checked == false)
            {
                SucoDeFrutaTb.Enabled = false;
                SucoDeFrutaTb.Text = "0";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // PREÇOS COMIDAS
        double fritasUp = 15, hamburguerUp = 35, saladaUp = 21, sanduicheUp = 12, nuggetsUp = 8, chedarUp = 6;
        double chaGeladoUp = 4, cocaColaUp = 8, aguaMineralUp = 2, chocolateUp = 4, panquecaUp = 12, sucoDeFrutaUp = 4;

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ComandaTb.Text + "\tSubtotal: " + Subtotallbl.Text + "\tTaxa: " + taxalbl.Text + "\t\tTotal à pagar: " + Totallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // LANCHES
            FritasCb.Checked = false;
            HamburguerCb.Checked = false;
            SaladaCb.Checked = false;
            SanduicheCb.Checked = false;
            NuggetsCb.Checked = false;
            ChedarCb.Checked = false;
            // BEBIDAS
            ChaGeladoCb.Checked = false;
            CocaColaCb.Checked = false;
            AguaMineralCb.Checked = false;
            ChocolateCb.Checked = false;
            PanquecaCb.Checked = false;
            SucoDeFrutaCb.Checked = false;

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        // VARIAVEL do TOTAL
        double fritasP, hamburguerP, saladaP, sanduicheP, nuggetsP, chedarP, chaGeladoP, cocaColaP, aguaMineralP, chocolateP, panquecaP, sucoDeFrutaP;
        double subTotal = 0, taxa, total;
        private void button2_Click(object sender, EventArgs e)
        {
            // LANCHES
            fritasP = fritasUp * Convert.ToDouble(FritasTb.Text);
            hamburguerP = hamburguerUp * Convert.ToDouble(HamburguerTb.Text);
            saladaP = saladaUp * Convert.ToDouble(SaladaTb.Text);
            sanduicheP = sanduicheUp * Convert.ToDouble(SanduicheTb.Text);
            nuggetsP = nuggetsUp * Convert.ToDouble(NuggetsTb.Text);
            chedarP = chedarUp * Convert.ToDouble(ChedarTb.Text);
            // BEBIDAS
            chaGeladoP = chaGeladoUp * Convert.ToDouble(ChaGeladoTb.Text);
            cocaColaP = cocaColaUp * Convert.ToDouble(CocaColaTb.Text);
            aguaMineralP = aguaMineralUp * Convert.ToDouble(AguaMineralTb.Text);
            chocolateP = chocolateUp * Convert.ToDouble(ChocolateTb.Text);
            panquecaP = panquecaUp * Convert.ToDouble(PanquecaTb.Text);
            sucoDeFrutaP = sucoDeFrutaUp * Convert.ToDouble(SucoDeFrutaTb.Text);
            // COMANDA
            ComandaTb.Clear();
            subTotal = 0;
            ComandaTb.AppendText(Environment.NewLine);
            ComandaTb.AppendText("\t\t---- RESTAURANTE DO EUDES ----\t" + DataLbl.Text+Environment.NewLine);
            ComandaTb.AppendText("\t\t---- ********************************* ----" + Environment.NewLine);

            // FUNÇÃO ADICIONAR NO LANCHE
            if (FritasCb.Checked == true)
            {
                ComandaTb.AppendText("\tFritas:" + "\tR$" + fritasP + Environment.NewLine);
                subTotal = subTotal + fritasP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (HamburguerCb.Checked == true)
            {
                ComandaTb.AppendText("\tHamburguer:" + "\tR$" + hamburguerP + Environment.NewLine);
                subTotal += hamburguerP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (SaladaCb.Checked == true)
            {
                ComandaTb.AppendText("\tSalada:" + "\tR$" + saladaP + Environment.NewLine);
                subTotal = subTotal + saladaP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (SanduicheCb.Checked == true)
            {
                ComandaTb.AppendText("\tSanduíche:" + "\tR$" + sanduicheP + Environment.NewLine);
                subTotal = subTotal + sanduicheP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (NuggetsCb.Checked == true)
            {
                ComandaTb.AppendText("\tNuggets:" + "\tR$" + nuggetsP + Environment.NewLine);
                subTotal = subTotal + nuggetsP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (ChedarCb.Checked == true)
            {
                ComandaTb.AppendText("\tChedar:" + "\tR$" + chedarP + Environment.NewLine);
                subTotal = subTotal + chedarP;
                Subtotallbl.Text = "" + subTotal;
            }

            // FUNÇÃO AIDCIONAR NOS DRINKS
            if (ChaGeladoCb.Checked == true)
            {
                ComandaTb.AppendText("\tChá Gelado:" + "\tR$" + chaGeladoP + Environment.NewLine);
                subTotal = subTotal + chaGeladoP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (CocaColaCb.Checked == true)
            {
                ComandaTb.AppendText("\tCoca Cola:" + "\tR$" + cocaColaP + Environment.NewLine);
                subTotal += cocaColaP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (AguaMineralCb.Checked == true)
            {
                ComandaTb.AppendText("\tÁgua Mineral:" + "\tR$" + aguaMineralP + Environment.NewLine);
                subTotal = subTotal + aguaMineralP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (ChocolateCb.Checked == true)
            {
                ComandaTb.AppendText("\tChocolate:" + "\tR$" + chocolateP + Environment.NewLine);
                subTotal = subTotal + chocolateP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (PanquecaCb.Checked == true)
            {
                ComandaTb.AppendText("\tPanqueca:" + "\tR$" + panquecaP + Environment.NewLine);
                subTotal = subTotal + panquecaP;
                Subtotallbl.Text = "" + subTotal;
            }

            if (SucoDeFrutaCb.Checked == true)
            {
                ComandaTb.AppendText("\tSuco de Frutas:" + "\tR$" + sucoDeFrutaP + Environment.NewLine);
                subTotal = subTotal + sucoDeFrutaP;
                Subtotallbl.Text = "" + subTotal;
            }

            taxa = subTotal * 0.10; // Taxa de 10% Restaurante
            total = subTotal + taxa;
            taxalbl.Text = "R$" + taxa;
            Totallbl.Text = "R$" + total;

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ComandaTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
