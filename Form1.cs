using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopapirollo_form_20240917
{
    public partial class form : Form
    {
        int gpontszam;
        int jatekospont;
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void játékToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbjatekos.Enabled = true;
            gpontszam = 0;
            jatekospont = 0;
            lbgpont.Text = "0";
            lbjpont.Text = "0";
        }

        private void form_Shown(object sender, EventArgs e)
        {
            cbjatekos.Enabled=false;
        }

        private void cbjatekos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int gepvalasztas = rnd.Next(0, 3);
            string gep;
            if (gepvalasztas == 0)
            {
                gep = "Kő";
                if(cbjatekos.SelectedIndex == 0)
                {
                    gpontszam = gpontszam + 1;
                    jatekospont = jatekospont + 1;
                }
                else if(cbjatekos.SelectedIndex == 1)
                {
                    jatekospont = jatekospont + 1;
                }
                else { gpontszam = gpontszam + 1; }
            }
            else if (gepvalasztas == 1)
            {
                gep = "Papír";
                if (cbjatekos.SelectedIndex == 0)
                {
                    gpontszam = gpontszam + 1;
                }
                else if (cbjatekos.SelectedIndex == 1)
                {
                    jatekospont = jatekospont + 1;
                    gpontszam = gpontszam + 1;
                }
                else { jatekospont = jatekospont + 1; }
            }
            else 
            {
                gep = "Olló";
                if (cbjatekos.SelectedIndex == 0)
                {
                    jatekospont = jatekospont + 1;
                }
                else if (cbjatekos.SelectedIndex == 1)
                {
                    gpontszam = gpontszam + 1;
                }
                else 
                {
                    jatekospont = jatekospont + 1;
                    gpontszam = gpontszam +1;
                }
            }
            txgep.Text = gep;
            lbgpont.Text=Convert.ToString(gpontszam);
            lbjpont.Text = Convert.ToString(jatekospont);
            if(gpontszam == 5 && jatekospont <5)
            {
                MessageBox.Show("A gép nyert!","Eredmény",MessageBoxButtons.OK,MessageBoxIcon.None);
                gpontszam = 0;
                jatekospont = 0;
                lbgpont.Text = "0";
                lbjpont.Text ="0";
                cbjatekos.Enabled = false;
            }
            else if (gpontszam == 5 && jatekospont == 5)
            {
                MessageBox.Show("Döntetlen!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.None);
                gpontszam = 0;
                jatekospont = 0;
                lbgpont.Text = "0";
                lbjpont.Text = "0";
                cbjatekos.Enabled = false;
            }
            else if(jatekospont == 5 && gpontszam < 5)
            {
                MessageBox.Show("Gratulálok, nyertél!", "Eredmény", MessageBoxButtons.OK, MessageBoxIcon.None);
                gpontszam = 0;
                jatekospont = 0;
                lbgpont.Text = "0";
                lbjpont.Text = "0";
                cbjatekos.Enabled = false;
            }
        }
    }
}
