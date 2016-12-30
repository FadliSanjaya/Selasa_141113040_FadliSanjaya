using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Latihan_DA
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter customerDA;
        //DataSet ds;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=testing;Uid=root;Pwd=root;";
            conn = new SqlConnection(myConnectionString);
            conn.Open();
            //ds = new DataSet();
            dt = new DataTable();
            initializeDA();
            customerDA.SelectCommand.ExecuteScalar();
            //customerDA.Fill(ds, "customer");
            customerDA.Fill(dt);
            dgvDaftar.ReadOnly = true;
            dgvDaftar.AllowUserToAddRows = false;
            dgvDaftar.AllowUserToDeleteRows = false;
            dgvDaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingSource bs = new BindingSource();
            //bs.DataSource = ds.Tables["customer"];
            bs.DataSource = dt;
            dgvDaftar.DataSource = bs;
            //dgvDaftar.DataSource = ds.Tables["customer"];

        }

        private void initializeDA()
        {
            customerDA = new SqlDataAdapter();

            //select
            string customerSelectSql = String.Concat("Select * from customer");
            customerDA.SelectCommand = new SqlCommand(customerSelectSql, conn);

            //insert
            string customerInsertSql = String.Concat("Insert into customer (name, address, zip_code, phone_number, email) values (@name, @address, @zip_code, @phone_number, @email)");
            SqlCommand customerInsertCommand = new SqlCommand(customerInsertSql, conn);
            customerInsertCommand.Parameters.AddWithValue("@name", txName.Text);
            customerInsertCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerInsertCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerInsertCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerInsertCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerDA.InsertCommand = customerInsertCommand;

            //update
            string customerUpdateSql = String.Concat("Update customer set name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email where id = @id");
            SqlCommand customerUpdateCommand = new SqlCommand(customerUpdateSql, conn);
            customerUpdateCommand.Parameters.AddWithValue("@id", txId.Text);
            customerUpdateCommand.Parameters.AddWithValue("@name", txName.Text);
            customerUpdateCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerUpdateCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerUpdateCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerUpdateCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerDA.UpdateCommand = customerUpdateCommand;

            //delete

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=testing;Uid=root;Pwd=root;";
            conn = new SqlConnection(myConnectionString);
            string pesan = "";
            if (txId.Text == "")
            {
                pesan = String.Concat(customerDA.InsertCommand.ExecuteNonQuery(), " Record succesfully saved.");
            }
            else
            {
                pesan = String.Concat(customerDA.UpdateCommand.ExecuteNonQuery(), " Record succesfully updated.");
            }
            MessageBox.Show(pesan, "Save Information");
            customerDA.SelectCommand.ExecuteScalar();
            dt.Clear();
            customerDA.Fill(dt);
        }
        private void reset()
        {
            txId.Text = "";
            txName.Text = "";
            txAddress.Text = "";
            txPhoneNumber.Text = "";
            txZipCode.Text = "";
            txEmail.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            reset();
        }
        private void deklarasiDA(TextBox txnama)
        {


        }
        private void txId_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgvDaftar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDaftar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
