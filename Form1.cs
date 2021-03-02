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

        public void Form1_Resize(object sender, System.EventArgs e)
        {
            // Button Location/Width/Height
            button1.Width = (int)(0.2 * this.Width);
            button1.Height = (int)(0.1 * this.Height);
            button1.Location = new Point(this.Width/2 - button1.Width/2, this.Height/2 - button1.Height/2);

            // Textbox 1 Location/Width/Height

            textBox1.Width = (int)(0.9 * this.Width);
            textBox1.Height = (int)(0.3 * this.Height);
            textBox1.Location = new Point((int)(this.Width * 0.05), (int)(this.Height * 0.05));

            // Textbox 2 Location/Width/Height
            textBox2.Width = (int)(0.9 * this.Width);
            textBox2.Height = (int)(0.3 * this.Height);
            textBox2.Location = new Point((int)(this.Width * 0.05), (int)(this.Height * 0.6));
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
