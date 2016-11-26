using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
           {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
           }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            size.Items.Add("4");
            size.Items.Add("5");
            size.Items.Add("6");
            size.Items.Add("7");
            size.Items.Add("8");
            size.Items.Add("9");
            size.Items.Add("10");
            size.Items.Add("11");
            size.Items.Add("12");
            size.Items.Add("14");
            size.Items.Add("16");
            size.Items.Add("18");
            size.Items.Add("20");
            size.Items.Add("22");
            size.Items.Add("24");
            size.Items.Add("26");
            size.Items.Add("28");
            size.Items.Add("36");
            size.Items.Add("48");
            size.Items.Add("72");
            size.Items.Add("144");
            size.Items.Add("288");
            foreach (FontFamily font in FontFamily.Families)
            {
                Calibri.Items.Add(font.Name.ToLowerInvariant());
            }

        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(size.SelectedItem), richTextBox1.Font.Style);
        }
    
       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Color_Click(object sender, EventArgs e)
        {
            DialogResult color = colorDialog1.ShowDialog();
            if (color == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Calibri_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(Calibri.Text, richTextBox1.Font.Size);
        }
    }
    }



    

