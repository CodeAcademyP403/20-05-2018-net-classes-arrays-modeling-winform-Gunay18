using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Login_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createUsers();

        }

        ArrayList users = new ArrayList();
        public void createUsers()
        {
            User user1 = new User("Aydin", "aydin42");
            User user2 = new User("Aytac", "276326");
            User user3 = new User("Sadiq", "sjhdj");
            users.AddRange(new User[3]{
                user1,user2, user3
            });
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach (User item in users)
            {
                if(txtbx_username.Text==item.Username && txbx_password.Text == item.Password)
                {
                    MessageBox.Show("Login is successful");
                    this.Close();
                    break;
                }
                else if(users.IndexOf(item) == users.Count-1)
                {
                    MessageBox.Show("Login failed");
                    txtbx_username.Text = "";
                    txbx_password.Text = "";
                }
            }
        }
    }
}
