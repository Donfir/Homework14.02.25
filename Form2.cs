using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String toFind = textBox2.Text;
            int index = str.IndexOf(toFind) + 1;
            textBox7.Text = index.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String toInsert = textBox2.Text;
            int index = Convert.ToInt32(textBox3.Text);
            string result = str.Insert(index, toInsert);
            textBox7.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            char toSeparate = Convert.ToChar(textBox2.Text);
            String[] result = str.Split(',');
            textBox7.Text = String.Join(toSeparate, result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String toFind = textBox2.Text;
            int index = str.LastIndexOf(toFind) + 1;
            textBox7.Text = index.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int index = Convert.ToInt32(textBox4.Text) - 1;
            String result = str.Remove(index);
            textBox7.Text = result;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String toReplace = textBox2.Text;
            String whatReplace = textBox5.Text;
            String result = str.Replace(toReplace, whatReplace);
            textBox7.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            String result = String.Join(' ', str.Split(','));
            textBox7.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int index = Convert.ToInt32(textBox4.Text) - 1;
            String result = str.Substring(index);
            textBox7.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            textBox7.Text = str.ToLower();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            
            char[] toTrim = textBox8.Text.ToCharArray();
            String result = str.Trim(toTrim);
            textBox7.Text = result;
        }
    }
}
