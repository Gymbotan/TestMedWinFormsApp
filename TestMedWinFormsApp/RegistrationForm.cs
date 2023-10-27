using System;
using System.Linq;
using System.Windows.Forms;
using TestMedWinFormsApp.DB.Interfaces;
using TestMedWinFormsApp.DB.Repositories;
using TestMedWinFormsApp.Exceptions;

namespace TestMedWinFormsApp
{
    public partial class RegistrationForm : Form
    {
        private readonly IUsersRepository usersRepository;
        public RegistrationForm()
        {
            InitializeComponent();
            usersRepository = new UsersRepository();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            try
            {
                IsLoginCorrect();
                IsPasswordCorrect();

                usersRepository.AddUser(LoginTextBox.Text, PassTextBox.Text);
                
                MessageBox.Show("New user is successfully created");
                this.Close();
            }
            catch (RegistrationException ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IsLoginCorrect()
        {
            var login = LoginTextBox.Text;
            if (string.IsNullOrEmpty(login))
            {
                throw new RegistrationException("Login can not be a null");
            }

            if (usersRepository.IsLoginExist(login))
            {
                throw new RegistrationException("Inputed login is already exists. Please input another login");
            }
        }

        private void IsPasswordCorrect()
        {
            var pass1 = PassTextBox.Text;
            var pass2 = confirmPassTextBox.Text;

            if (!string.Equals(pass2, pass1)) 
            {
                throw new RegistrationException("Password and confirmed password are not equal");
            }

            if (pass1.Length < 6)
            {
                throw new RegistrationException("Password should contain at least 6 symbols.");
            }

            if (!pass1.Any(c => char.IsDigit(c))) 
            {
                throw new RegistrationException("Password should contain at least 1 digit.");
            }

            if (!pass1.Any(c => char.IsLetter(c)))
            {
                throw new RegistrationException("Password should contain at least 1 letter.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}