using DAL.Entities;
using RegisteredUser_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_UI
{
    public partial class Enter : Form
    {
        User currentUser;

        public Enter()
        {
            InitializeComponent();
            currentUser = new User();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string login= loginTextBox.Text;
            string password= passwordTextBox.Text;

            if(!checkInput(login,password))return;

            User_BL user_BL = new User_BL();
            currentUser = user_BL.getUserByLogPas(login,password);

            if(!checkInput(currentUser))return;

            this.Close();
            Thread th = new Thread(openNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void openNewForm() {
            Application.Run(new Home(currentUser));
        }

        bool checkInput(string login,string password) {
            if (login.Length == 0 ||
                password.Length == 0)
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
                MessageBox.Show("Incorrect data!");

                return false;
            }
            return true;
        }

        private void newUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration(currentUser);
            registration.ShowDialog(this);

            if (currentUser != null) {
                loginTextBox.Text = currentUser.login;
                passwordTextBox.Text = currentUser.password;
            }
        }

        private void Enter_Load(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
