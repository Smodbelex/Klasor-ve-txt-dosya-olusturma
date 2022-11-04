using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dosyatxtolusturma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            string klasor = textBox1.Text;
            string txt = textBox2.Text + ".txt";
            string adres = (("C:\\Users\\emir_\\Desktop\\" + klasor + "\\") + txt);
            File.WriteAllText(adres, richTextBox1.Text);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
