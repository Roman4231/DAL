using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using RegisteredUser_BL;

namespace shop_UI
{
    public partial class Registration : Form
    {
        private User currentUser;

        public Registration()
        {
            InitializeComponent();
        }

        public Registration(User currentUser)
        {
            InitializeComponent();

            this.currentUser = currentUser;
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.login = loginTextBox.Text;
            newUser.email = emailTextBox.Text;
            newUser.password= passwordTextBox.Text;

            if (!(checkInput(newUser.login,
                             newUser.email,
                             newUser.password))) return;


            User_BL bl = new User_BL();
            newUser = bl.createUser(newUser);

            if (!checkInput(newUser)) {
                this.DialogResult = DialogResult.None;
                return;
            }
            currentUser.user_ID = newUser.user_ID;
            currentUser.login = newUser.login;
            currentUser.email = newUser.email;
            currentUser.password = newUser.password;
        }

        bool checkInput(string login,string email, string password)
        {
            if (login.Length == 0 ||
                password.Length == 0 ||
                email.Length==0)
            {
                MessageBox.Show("Please fill all fields!");
                return false;
            }
            return true;
        }

        bool checkInput(User user)
        {
            if (user == null)
            {
                MessageBox.Show("User already exist!");

                return false;
            }
            return true;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
