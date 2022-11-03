using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        int muzi = 0;
        int zeny = 0;
        int pocitadlo = 0;
        /*string text = "";
        ulong delitelne = 0;*/
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            int rok = datum.Year;
            rok = rok % 100;
            int mesic = datum.Month;
            int den = datum.Day;
            int nahodne = rng.Next(100, 1000);
                if (radioButton1.Checked == true)
                {
                    if (den < 10)
                    {
                        maskedTextBox1.Text = rok + "" + mesic + "0" + den + "/" + nahodne;
                        maskedTextBox2.Text = rok + "" + mesic + "0" + den + "/" + nahodne + rng.Next(0, 10);
                    }
                    else if (mesic < 10)
                    {
                        maskedTextBox1.Text = rok + "0" + mesic + "" + den + "/" + nahodne;
                        maskedTextBox2.Text = rok + "0" + mesic + "" + den + "/" + nahodne + rng.Next(0, 10);
                    }
                    else if (mesic < 10 && den < 10)
                    {
                        maskedTextBox1.Text = rok + "0" + mesic + "0" + den + "/" + nahodne;
                        maskedTextBox2.Text = rok + "0" + mesic + "0" + den + "/" + nahodne + rng.Next(0, 10);
                    }
                    muzi++;
                    pocitadlo++;
                }
                else if (radioButton2.Checked == true)
                {
                    mesic = mesic + 50;
                    if (den < 10)
                    {
                        maskedTextBox1.Text = rok + "" + mesic + "0" + den + "/" + nahodne;
                        maskedTextBox2.Text = rok + "" + mesic + "0" + den + "/" + nahodne + rng.Next(0, 10);
                    }
                    else
                    {
                        maskedTextBox1.Text = rok + "" + mesic + "" + den + "/" + nahodne;
                        maskedTextBox2.Text = rok + "" + mesic + "" + den + "/" + nahodne + rng.Next(0, 10);
                    }
                    zeny++;
                    pocitadlo++;
                }
                else
                {
                    MessageBox.Show("Zadej pohlaví :D");
                }
                /*foreach (char znak in maskedTextBox2.Text)
                {
                    if (znak != '/')
                    {
                        text += znak;
                    }
                }
                delitelne = ulong.Parse(text);*/

            if(pocitadlo >= 2)
            {
                button2.Enabled = true;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "Mužů: " + muzi;
            label6.Text = "Žen: " + zeny;
        }
    }
}
