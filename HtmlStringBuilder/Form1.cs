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
            s += "private string BodyHtml(){" + Environment.NewLine;
            s += "var sb = new StringBuilder();" + Environment.NewLine;

            string _ = "\"";
            string cs = "\\\"";
            foreach (var t in richTextBox1.Lines)
            {
                if (string.IsNullOrWhiteSpace(t))
                {
                    continue;
                }

                var rpl = t.Replace(_, cs);
                var value = $"{_}{rpl}{_}".ToString();
                var text = $"sb.AppendLine({value});";
                s += text + Environment.NewLine;
                //s += text + Environment.NewLine;
            }
            s += "return sb.ToString();" + Environment.NewLine;

            s += "}" + Environment.NewLine;

            richTextBox2.Text = s;
        }
    }
}
