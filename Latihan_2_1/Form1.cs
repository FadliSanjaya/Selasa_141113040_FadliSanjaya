using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void calender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            calender.ScrollChange = 2;

            int x = 2021;
            while (x >= 1996)
            {
                DateTime awal = new DateTime(x, 1, 1);
                DateTime akhir = new DateTime(x, 12, 31);
                for (int i = 0; i < akhir.DayOfYear; i++)
                {
                    if (awal.DayOfWeek.ToString() == "Sunday" || awal.DayOfWeek.ToString() == "Monday")
                    {
                        calender.AddBoldedDate(awal);
                    }
                    awal = awal.AddDays(1);
                }

                calender.AddBoldedDate(new DateTime(x, 9, 1));
                x--;
            }

            calender.UpdateBoldedDates();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = 2021;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] DaftarBulan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (y >= 1996)
            {
                calender.AddBoldedDate(new DateTime(y, DaftarBulan[bulan], tanggal));
                y--;
            }

            calender.UpdateBoldedDates();

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int z = 2021;
            int tanggal = Convert.ToInt32(numericUpDown1.Value.ToString());
            int bulan = domainUpDown1.SelectedIndex;

            int[] DaftarBulan = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            while (z >= 1996)
            {
                calender.RemoveBoldedDate(new DateTime(z, DaftarBulan[bulan], tanggal));
                z--;
            }

            calender.UpdateBoldedDates();
        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }   
   }
}
   

