using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucus_rezarvasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota :" + comboBox1.Text + " - " + comboBox2.Text + "Tarih : " + dateTimePicker1.Text  + "  Saat: " + maskedTextBox1.Text  +  "  Ad Soyad: " + textBox1.Text  +  "  TC:  " + maskedTextBox2.Text  + " Telefon: " + maskedTextBox3.Text) ;
            MessageBox.Show("Rezervasyonunuz alındı.");      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label8.Text;
               

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
