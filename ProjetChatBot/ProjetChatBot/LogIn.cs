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


namespace ProjetChatBot
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.AuthDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
       
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM adminTB WHERE Username='" + textBox1.Text + "'and password='" + maskedTextBox1.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i == 1)
            {
                string role = cd_role.SelectedItem.ToString();
                if (role == "Admin")
                {
                    AddUser A = new AddUser();
                    A.Show();
                    this.Hide();
                }
                else if (role == "User")
                {
                    DashbordUser u = new DashbordUser();
                    u.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid role selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please check your User Name or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
