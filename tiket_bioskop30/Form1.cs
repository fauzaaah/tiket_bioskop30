using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiket_bioskop30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("09.00");
            comboBox1.Items.Add("11.00");
            comboBox1.Items.Add("13.00");
            comboBox1.Items.Add("15.00");
            comboBox1.Items.Add("17.00");
            comboBox1.Items.Add("19.00");
            comboBox2.Items.Add("A1");
            comboBox2.Items.Add("A2");
            comboBox2.Items.Add("A3");
            comboBox2.Items.Add("A4");
            comboBox2.Items.Add("A5");
            comboBox2.Items.Add("A6");
            comboBox3.Items.Add("Senin");
            comboBox3.Items.Add("Selasa");
            comboBox3.Items.Add("Rabu");
            comboBox3.Items.Add("Jumat");
            comboBox3.Items.Add("Sabtu");
            comboBox3.Items.Add("Minggu");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Studio 1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Text = "Studio 2";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem=="Senin")
            {
                textBox2.Text = "25.000";
            }
            else if (comboBox3.SelectedItem == "Selasa")
            {
                textBox2.Text = "25.000";
            }
            else if (comboBox3.SelectedItem == "Rabu")
            {
                textBox2.Text = "25.000";
            }
            else if (comboBox3.SelectedItem == "Jumat")
            {
                textBox2.Text = "30.000";
            }
            else if (comboBox3.SelectedItem == "Sabtu")
            {
                textBox2.Text = "35.000";
            }
            else if (comboBox3.SelectedItem == "Minggu")
            {
                textBox2.Text = "30.000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(Pemesanan Berhasil !)", "Out Theater", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
