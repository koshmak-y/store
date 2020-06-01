namespace Store
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayTextbox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.checkingPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextbox.ForeColor = System.Drawing.Color.Gray;
            this.loginTextbox.Location = new System.Drawing.Point(132, 30);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(279, 26);
            this.loginTextbox.TabIndex = 3;
            this.loginTextbox.Text = "login@email.com";
            this.loginTextbox.Enter += new System.EventHandler(this.loginTextbox_Enter);
            this.loginTextbox.Leave += new System.EventHandler(this.loginTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextbox.Location = new System.Drawing.Point(132, 80);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(279, 26);
            this.passwordTextbox.TabIndex = 5;
            this.passwordTextbox.Text = "***********";
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            this.passwordTextbox.Enter += new System.EventHandler(this.passwordTextbox_Enter);
            this.passwordTextbox.Leave += new System.EventHandler(this.passwordTextbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextbox.ForeColor = System.Drawing.Color.Gray;
            this.firstNameTextbox.Location = new System.Drawing.Point(132, 130);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(279, 26);
            this.firstNameTextbox.TabIndex = 7;
            this.firstNameTextbox.Text = "Will";
            this.firstNameTextbox.Enter += new System.EventHandler(this.firstNameTextbox_Enter);
            this.firstNameTextbox.Leave += new System.EventHandler(this.firstNameTextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextbox.ForeColor = System.Drawing.Color.Gray;
            this.lastNameTextbox.Location = new System.Drawing.Point(132, 180);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(279, 26);
            this.lastNameTextbox.TabIndex = 10;
            this.lastNameTextbox.Text = "Smith";
            this.lastNameTextbox.Enter += new System.EventHandler(this.lastNameTextbox_Enter);
            this.lastNameTextbox.Leave += new System.EventHandler(this.lastNameTextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthday:";
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayTextbox.ForeColor = System.Drawing.Color.Gray;
            this.birthdayTextbox.Location = new System.Drawing.Point(132, 230);
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.Size = new System.Drawing.Size(279, 26);
            this.birthdayTextbox.TabIndex = 12;
            this.birthdayTextbox.Text = "31.12.1999";
            this.birthdayTextbox.Enter += new System.EventHandler(this.birthdayTextbox_Enter);
            this.birthdayTextbox.Leave += new System.EventHandler(this.birthdayTextbox_Leave);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(122, 290);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(185, 40);
            this.registrationButton.TabIndex = 13;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // checkingPasswordLabel
            // 
            this.checkingPasswordLabel.AutoSize = true;
            this.checkingPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkingPasswordLabel.Location = new System.Drawing.Point(129, 107);
            this.checkingPasswordLabel.Name = "checkingPasswordLabel";
            this.checkingPasswordLabel.Size = new System.Drawing.Size(125, 17);
            this.checkingPasswordLabel.TabIndex = 14;
            this.checkingPasswordLabel.Text = "Password strength";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.checkingPasswordLabel);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.birthdayTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrationForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birthdayTextbox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label checkingPasswordLabel;
    }
}