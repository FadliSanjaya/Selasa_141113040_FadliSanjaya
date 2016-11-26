using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

namespace volleyball_problem
=======
using System.Reflection;

namespace Latihan_5_1
>>>>>>> be0145bca7903f136483c8c0d56a86ddb8c3292e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        const long MOD = 1000000007;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
=======
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox2.Items.Add("4");
            toolStripComboBox2.Items.Add("5");
            toolStripComboBox2.Items.Add("6");
            toolStripComboBox2.Items.Add("7");
            toolStripComboBox2.Items.Add("8");
            toolStripComboBox2.Items.Add("9");
            toolStripComboBox2.Items.Add("10");
            toolStripComboBox2.Items.Add("11");
            toolStripComboBox2.Items.Add("12");
            toolStripComboBox2.Items.Add("14");
            toolStripComboBox2.Items.Add("16");
            toolStripComboBox2.Items.Add("18");
            toolStripComboBox2.Items.Add("20");
            toolStripComboBox2.Items.Add("22");
            toolStripComboBox2.Items.Add("24");
            toolStripComboBox2.Items.Add("26");
            toolStripComboBox2.Items.Add("28");
            toolStripComboBox2.Items.Add("36");
            toolStripComboBox2.Items.Add("48");
            toolStripComboBox2.Items.Add("72");
            toolStripComboBox2.Items.Add("144");
            toolStripComboBox2.Items.Add("288");
            foreach (FontFamily font in FontFamily.Families)
            {
                toolStripComboBox1.Items.Add(font.Name.ToLowerInvariant());
            }
        }
        
        private void settimgToolStripMenuItem_Click(object sender, EventArgs e)
>>>>>>> be0145bca7903f136483c8c0d56a86ddb8c3292e
        {

        }

<<<<<<< HEAD
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            long PlayerA, PlayerB, hasil;
            PlayerA = Convert.ToInt64(textBox1.Text);
            PlayerB = Convert.ToInt64(textBox2.Text);
            if (PlayerA < PlayerB)
            {
                long temp = PlayerA;
                PlayerA = PlayerB;
                PlayerB = temp;
            }

            if ((PlayerA > 25 && PlayerA - PlayerB != 2) || (PlayerA - PlayerB < 2) || (PlayerA < 25))
            {
                hasil = 0;
            }
            else
            {
                hasil = Hasil(Math.Min(PlayerA + PlayerB - 1, 47), Math.Min(PlayerA - 1, 24));
                hasil *= powerMod(2, PlayerA - 25);
                hasil %= MOD;
            }
            textBox3.Text = hasil.ToString();
        }
        private long Hasil(long x, long y)
        {
            if (x < y) return 0;
            long hasil = 1;
            hasil *= faktorial(x);
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(x - y));
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(y));
            hasil %= MOD;
            return hasil;
        }

        private long InverseEuler(long x)
        {
            return powerMod(x, MOD - 2);
        }

        private long faktorial(long x)
        {
            long hasil = 1;
            for (int i = 1; i <= x; i++)
            {
                hasil *= i;
                hasil %= MOD;
            }
            return hasil;
        }

        private long powerMod(long b, long e)
        {
            long res = 1;
            while (e > 0)
            {
                if (e % 2 == 1)
                {
                    res = (res * b) % MOD;
                }
                b = (b * b) % MOD;
                e /= 2;
            }
            return res % MOD;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
=======
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog2.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog2.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        

        

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(toolStripComboBox1.Text, richTextBox1.Font.Size);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(toolStripComboBox2.SelectedItem), richTextBox1.Font.Style);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult color = colorDialog1.ShowDialog();
            if (color == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                return;
            }

            richTextBox1.SelectedText = "";
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

>>>>>>> be0145bca7903f136483c8c0d56a86ddb8c3292e
        }
    }
}
