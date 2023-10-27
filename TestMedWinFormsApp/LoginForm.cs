using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using TestMedWinFormsApp.DB;
using TestMedWinFormsApp.DB.Interfaces;
using TestMedWinFormsApp.DB.Repositories;

namespace TestMedWinFormsApp
{
    public partial class LoginForm : Form
    {
        private readonly IUsersRepository _usersRepository;

        public LoginForm()
        {
            CheckIfDataExists();
            InitializeComponent();
            _usersRepository = new UsersRepository();
        }

        public LoginForm(IUsersRepository usersRepository)
        {
            CheckIfDataExists();
            InitializeComponent();
            _usersRepository = usersRepository;
        }

        private void CheckIfDataExists()
        {
            if(!File.Exists(DBInfo.DatabaseAddress))
            {
                SQLiteConnection.CreateFile(DBInfo.DatabaseAddress);
                using (var connection = new SQLiteConnection(DBInfo.ConnectionString))
                {
                    connection.Open();
                    string tableUsersCreate = "CREATE TABLE 'Users' ('Id' INTEGER, 'Login' TEXT NOT NULL, 'Password' TEXT NOT NULL, PRIMARY KEY('Id' AUTOINCREMENT))";
                    
                    using(var cmd = new SQLiteCommand(tableUsersCreate, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string tableModesCreate = "CREATE TABLE 'Modes' ('Id' INTEGER, 'Name' TEXT, 'MaxBottleNumber' INTEGER, 'MaxUsedTips' INTEGER, PRIMARY KEY('Id' AUTOINCREMENT))";

                    using (var cmd = new SQLiteCommand(tableModesCreate, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string tableStepsCreate = "CREATE TABLE 'Steps' ('Id' INTEGER, 'ModeId' INTEGER, 'Timer' INTEGER, 'Destination' TEXT, 'Speed' INTEGER, 'Type' TEXT, 'Volume' INTEGER, FOREIGN KEY('ModeId') REFERENCES 'Modes'('Id'), PRIMARY KEY('Id' AUTOINCREMENT))";

                    using (var cmd = new SQLiteCommand(tableStepsCreate, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            this.Visible = false;
            form.ShowDialog();
            LoginTextBox.Text = "";
            PassTextBox.Text = "";
            this.Visible = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTextBox.Text))
            {
                MessageBox.Show("Please, enter your login", "Login warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(PassTextBox.Text))
            {
                MessageBox.Show("Please, enter your password", "Login warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_usersRepository.IsUserExist(LoginTextBox.Text, PassTextBox.Text))
            {
                MessageBox.Show("There is no any user with inputed login and password. Please try again", "Login warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MainForm form = new MainForm();
                this.Visible = false;
                form.ShowDialog();
                LoginTextBox.Text = "";
                PassTextBox.Text = "";
                this.Visible = true;
            }
        }
    }
}
