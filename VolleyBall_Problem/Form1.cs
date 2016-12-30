using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolleyBall_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const long MOD = 1000000007;

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

        private long Hasil(long n, long r)
        {
            if (n < r) return 0;
            long hasil = 1;
            hasil *= faktorial(n);
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(n - r));
            hasil %= MOD;
            hasil *= InverseEuler(faktorial(r));
            hasil %= MOD;
            return hasil;
        }

        private long InverseEuler(long n)
        {
            return powerMod(n, MOD - 2);
        }

        private long faktorial(long n)
        {
            long hasil = 1;
            for (int i = 1; i <= n; i++)
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
