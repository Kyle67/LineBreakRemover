using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineBreakRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string newText = textBox1.Text.ToUpper();
            newText = newText.Replace(System.Environment.NewLine, " ");
            textBox2.Text = newText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "") 
                Clipboard.SetText(textBox2.Text);
        }
    }
}
