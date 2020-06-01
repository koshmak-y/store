using System;
using System.Configuration;
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
using Store.Forms;
using System.Collections.Specialized;

namespace Store
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }
        /*---------------------------------------------------------------    Login    ----------------------------------------------------------------*/
        public bool isValidEmail(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success && email != "login@email.com";
        }
        private void loginTextbox_Enter(object sender, EventArgs e)
        {
            loginTextbox.ForeColor = Color.Black;

            if (loginTextbox.Text == "login@email.com")
            {
                loginTextbox.Text = null;
            }
                
        }
        private void loginTextbox_Leave(object sender, EventArgs e)
        {
            if (isValidEmail(loginTextbox.Text))
            {
                return;
            } 
            else
            {
                if (string.IsNullOrEmpty(loginTextbox.Text))
                {
                    loginTextbox.Text = "login@email.com";
                    loginTextbox.ForeColor = Color.Gray;
                }
                else 
                {
                    loginTextbox.ForeColor = Color.Red;
                    MessageBox.Show("Email is not correct." + Environment.NewLine +
                    "Format login will be: login@email.com");
                    return;
                }
            }
        }

        private void loginTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginButton_Click(sender, e);
        }
        /*---------------------------------------------------------------    /Login    ----------------------------------------------------------------*/

        /*---------------------------------------------------------------    Password    ----------------------------------------------------------------*/
        private void passwordTextbox_Enter(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "***********") passwordTextbox.Text = null;
            passwordTextbox.ForeColor = Color.Black;
        }
        private void passwordTextbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTextbox.Text))
            {
                passwordTextbox.ForeColor = Color.Gray;
                passwordTextbox.Text = "***********";
            }
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) loginButton_Click(sender, e);
        }
        /*---------------------------------------------------------------    end_ShoppingCart    ----------------------------------------------------------------*/

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextbox.Text == "login@email.com")
            {
                MessageBox.Show("Login line is empty.", "Incorrect login");
                return;
            }
            if (!isValidEmail(loginTextbox.Text))
            {
                MessageBox.Show("Email is not correct." + Environment.NewLine +
                   "Format login will be: login@email.com", "Incorrect login");
                return;
            }
            using (StoreDB db = new StoreDB())
            {
                if (db.Users.Count() == 0)
                {
                    MessageBox.Show("User not found", "Error");
                    return;
                }
                else
                {
                    foreach (var user in db.Users)
                    {
                        if (user.mail == loginTextbox.Text)
                        {
                            if (user.password == EncodingPassword.Encryption(passwordTextbox.Text))
                            {
                                GlobalVars.CurrentUser = user;
                                GlobalVars.userIsConnected = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Password is not correct");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Error");
                        }
                    }
                }
            }
            if (autoFillAutorization.Checked == true)
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    if (settings["email"] == null)
                    {
                        settings.Add("email", loginTextbox.Text);
                    }
                    else
                    {

                        settings["email"].Value = loginTextbox.Text;
                    }
                    if (settings["password"] == null)
                    {
                        settings.Add("password", passwordTextbox.Text);
                    }
                    else
                    {

                        settings["password"].Value = passwordTextbox.Text;
                    }
                    if (settings["autofill"] == null)
                    {
                        settings.Add("autofill", "true");
                    }
                    else
                    {

                        settings["autofill"].Value = "true";
                    }
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (ConfigurationErrorsException)
                {
                    MessageBox.Show("Error writing app settings");
                }

                GlobalVars.autorizationForm.Close();
            }
            else
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["email"] != null)
                {
                    settings.Remove("email");
                    settings.Remove("password");
                    settings.Remove("autofill");
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            GlobalVars.autorizationForm.Visible = false;
            GlobalVars.registrationForm.ShowDialog();
        }

        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVars.userIsConnected == false)
            {
                Application.Exit();
            }
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            NameValueCollection LoadFromConfig = ConfigurationManager.AppSettings;
            if (LoadFromConfig["email"] != null)
            {
                loginTextbox.Text = LoadFromConfig["email"];
                passwordTextbox.Text = LoadFromConfig["password"];
                autoFillAutorization.Checked = true;
            }
        }
    }
}
