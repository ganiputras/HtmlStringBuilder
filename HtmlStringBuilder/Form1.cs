using System;
using System.Windows.Forms;

namespace HtmlStringBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = String.Empty;

            s += "var sb = new StringBuilder();" + Environment.NewLine;

            foreach (var t in richTextBox1.Lines)
            {
                var text = $"sb.AppendLine({t})";
                s += text + Environment.NewLine;
                //s += text + Environment.NewLine;
            }
            s += "return sb.ToString();" + Environment.NewLine;

            richTextBox2.Text = s;
        }
    }
}
