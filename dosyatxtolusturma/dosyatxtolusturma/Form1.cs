using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace dosyatxtolusturma
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
      
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C:\\Users\\emir_\\Desktop\\" + textBox1.Text);
            button1.Enabled = false;
            button3.Enabled = true;
            textBox1.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {  
            File.WriteAllText("C:\\Users\\emir_\\Desktop\\" + textBox1.Text + "\\" + textBox2.Text+".txt", richTextBox1.Text);
            button3.Enabled=false;
            textBox2.Enabled = false;
            richTextBox1.Text = "";
            richTextBox1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string adres;
            adres = File.ReadAllText("C:\\Users\\emir_\\Desktop\\" + textBox1.Text + "\\" + textBox2.Text + ".txt");
            richTextBox2.Text = adres;
        }
    }
}