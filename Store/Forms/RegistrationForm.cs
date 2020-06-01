using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Store.DataModel;
using Store.Adding;

namespace Store
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        { 
            InitializeComponent();
        }
        public RegistrationForm(AutorizationForm f)
        {
            InitializeComponent();
        }

        public bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success && email != "login@email.com";
        }
        private void loginTextbox_Enter(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "login@email.com") loginTextbox.Text = null;
            loginTextbox.ForeColor = Color.Black;
        }
        
        private void loginTextbox_Leave(object sender, EventArgs e)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(loginTextbox.Text, pattern, RegexOptions.IgnoreCase);
            
            if (String.IsNullOrEmpty(loginTextbox.Text))
            {
                loginTextbox.ForeColor = Color.Gray;
                loginTextbox.Text = "login@email.com";
                return;
            }

            if (isMatch.Success && loginTextbox.Text != "login@email.com")
            {
                return;
            }
            else
            {
                loginTextbox.ForeColor = Color.Gray;
                loginTextbox.Text = "login@email.com";
                MessageBox.Show("Email is not correct." + Environment.NewLine +
                "Format login will be: login@email.com");
            }
        }

        private void passwordTextbox_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "***********") passwordTextbox.Text = null;
            passwordTextbox.ForeColor = Color.Black;
        }

        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            string pattern = "[a-zA-Z0-9_]{6,16}";
            Match isMatch = Regex.Match(passwordTextbox.Text, pattern, RegexOptions.IgnoreCase);
            if (String.IsNullOrEmpty(passwordTextbox.Text) || !isMatch.Success)
            {
                passwordTextbox.ForeColor = Color.Gray;
                passwordTextbox.Text = "***********";
                checkingPasswordLabel.Text = "Password must be more than 6 characters.";
            }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if(passwordTextbox.Text.Length < 6)
            {
                checkingPasswordLabel.Text = "Password must be more than 6 characters.";
            }
            else
            {
                checkingPasswordLabel.Text = CheckingPassword.CheckingPW(passwordTextbox.Text);
            }
        }

        private void firstNameTextbox_Enter(object sender, EventArgs e)
        {
            if (firstNameTextbox.Text == "Will")
            {
                firstNameTextbox.Text = null;
                firstNameTextbox.ForeColor = Color.Black;
            }    
        }

        private void firstNameTextbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNameTextbox.Text))
            {
                firstNameTextbox.ForeColor = Color.Gray;
                firstNameTextbox.Text = "Will";
            }
        }

        private void lastNameTextbox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextbox.Text == "Smith" && lastNameTextbox.ForeColor == Color.Gray)
            {
                lastNameTextbox.Text = null;
                lastNameTextbox.ForeColor = Color.Black;
            }
        }

        private void lastNameTextbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lastNameTextbox.Text))
            {
                lastNameTextbox.ForeColor = Color.Gray;
                lastNameTextbox.Text = "Smith";
            }
        }

        private void birthdayTextbox_Enter(object sender, EventArgs e)
        {
            if (birthdayTextbox.Text == "31.12.1999" && birthdayTextbox.ForeColor == Color.Gray)
            {
                birthdayTextbox.Text = null;
                birthdayTextbox.ForeColor = Color.Black;
            }
        }

        private void birthdayTextbox_Leave(object sender, EventArgs e)
        {
            DateTime birthday;
            if (String.IsNullOrEmpty(birthdayTextbox.Text))
            {
                birthdayTextbox.ForeColor = Color.Gray;
                birthdayTextbox.Text = "31.12.1999";
                return;
            }
            string pattern = "[0-9]+.[0-9].[0-9]";
            Match isMatch = Regex.Match(birthdayTextbox.Text, pattern, RegexOptions.IgnoreCase);
            if (isMatch.Success)
            {
                if (!DateTime.TryParse(birthdayTextbox.Text, out birthday))
                {
                    birthdayTextbox.ForeColor = Color.Gray;
                    birthdayTextbox.Text = "31.12.1999";
                    MessageBox.Show("Date birthday is not correct." + Environment.NewLine +
                        "Format date will be: dd.mm.yyyy");
                }
            }
        }

        public void registrationButton_Click(object sender, EventArgs e)
        {
            using (StoreDB db = new StoreDB())
            {
                foreach (var user in db.Users)
                {
                    if (user.mail == loginTextbox.Text)
                    {
                        MessageBox.Show("A user with this email has already been created.", "Error");
                        return;
                    }
                }

                User tempUser = db.Users.Add(new User(string.Format(firstNameTextbox.Text + " " + lastNameTextbox.Text),
                loginTextbox.Text,
                Convert.ToDateTime(birthdayTextbox.Text),
                EncodingPassword.Encryption(passwordTextbox.Text)));
                db.SaveChanges();

                if(GlobalVars.CurrentUser.name == null)
                {
                    MessageBox.Show("Registration is complited. Use your login and password to autorization.");
                    GlobalVars.registrationForm.Visible = false;
                    GlobalVars.autorizationForm.Visible = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Make new user as manager ?", "Registration is complited", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        tempUser.IsManager = true;
                        db.SaveChanges();
                    }
                    Hide();
                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            registrationButton_Click(sender, e);
        }
    }
}
