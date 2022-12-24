using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetChatBot
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'authDBDataSet.AdminTB'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.adminTBTableAdapter.Fill(this.authDBDataSet.AdminTB);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_pwd.Enabled = value;
            cd_role.Enabled = value;

        }
        //btn_new
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                authDBDataSet.AdminTB.AddAdminTBRow(authDBDataSet.AdminTB.NewAdminTBRow());
                adminTBBindingSource.MoveLast();
                txt_userName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authDBDataSet.AdminTB.RejectChanges();
            }

        }
        //btn_Edit
        private void button2_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_userName.Focus();

        }
        //btn_Save
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                adminTBBindingSource.EndEdit();
                adminTBTableAdapter.Update(authDBDataSet.AdminTB);
                //dgv_adminuser.Refresh();
                txt_userName.Focus();
                MessageBox.Show("your data has been successfuly saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authDBDataSet.AdminTB.RejectChanges();
            }


        }
        //btn_delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete .", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            adminTBBindingSource.RemoveCurrent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit(false);
            adminTBBindingSource.ResetBindings(false);

        }
        //btn_logout
        private void button5_Click(object sender, EventArgs e)
        {
            LogIn L = new LogIn();
            L.Show();
            this.Hide();
        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
