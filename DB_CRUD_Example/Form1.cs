using System;
using System.Windows.Forms;

namespace DB_CRUD_Example
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            dgv_user_info.DataSource = User.GetUsers();
         
          
        }





        private void but_add_Click_1(object sender, EventArgs e)
        {
            user.UserId = tex_userID.Text;
            user.UserPass = tex_Password.Text;
            user.Email = tex_Email.Text;
            user.Address = tex_address.Text;

            bool success = user.InsertUser(user);

            dgv_user_info.DataSource = User.GetUsers();

            if (success)
            {
                ClearControls();
                MessageBox.Show(@"User has been added successfully");
            }
            else
                MessageBox.Show(@"Error occured Please try again...");
        }

        private void but_update_Click_1(object sender, EventArgs e)
        {
            user.Id = lb_id.Text;
            user.UserId = tex_userID.Text;
            user.UserPass = tex_Password.Text;
            user.Email = tex_Email.Text;
            user.Address = tex_address.Text;

            bool success = user.UpdateUser(user);

            dgv_user_info.DataSource = User.GetUsers();

            if (success)
            {
                ClearControls();
                MessageBox.Show(@"User has been update successfully");
            }
            else
                MessageBox.Show(@"Error occured Please try again...");
        }

        private void but_delete_Click_1(object sender, EventArgs e)
        {
            user.Id = lb_id.Text;
            user.UserId = tex_userID.Text;

            bool success = user.DeletetUser(user);

            dgv_user_info.DataSource = User.GetUsers();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"User has been delete successfully");
            }
            else
                MessageBox.Show(@"Error occured Please try again...");
        }


        private void But_cleare_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            foreach (Control control in pnl_controls.Controls)
            {
                control.Text = "";
            }
        }
        private void dgv_user_info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            lb_id.Text = dgv_user_info.Rows[index].Cells[0].Value.ToString();
            tex_userID.Text = dgv_user_info.Rows[index].Cells[1].Value.ToString();
            tex_Email.Text = dgv_user_info.Rows[index].Cells[2].Value.ToString();
            tex_address.Text = dgv_user_info.Rows[index].Cells[3].Value.ToString();
        }

       
    }
}