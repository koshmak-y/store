namespace Store
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.autoFillAutorization = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextbox.ForeColor = System.Drawing.Color.Gray;
            this.loginTextbox.Location = new System.Drawing.Point(95, 29);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(210, 26);
            this.loginTextbox.TabIndex = 2;
            this.loginTextbox.Text = "login@email.com";
            this.loginTextbox.Enter += new System.EventHandler(this.loginTextbox_Enter);
            this.loginTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextbox_KeyDown);
            this.loginTextbox.Leave += new System.EventHandler(this.loginTextbox_Leave);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextbox.Location = new System.Drawing.Point(95, 63);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(210, 26);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.Text = "***********";
            this.passwordTextbox.Enter += new System.EventHandler(this.passwordTextbox_Enter);
            this.passwordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextbox_KeyDown);
            this.passwordTextbox.Leave += new System.EventHandler(this.passwordTextbox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(13, 118);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(139, 32);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(172, 118);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(139, 32);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // autoFillAutorization
            // 
            this.autoFillAutorization.AutoSize = true;
            this.autoFillAutorization.Location = new System.Drawing.Point(95, 96);
            this.autoFillAutorization.Name = "autoFillAutorization";
            this.autoFillAutorization.Size = new System.Drawing.Size(145, 17);
            this.autoFillAutorization.TabIndex = 6;
            this.autoFillAutorization.Text = "Save login and password";
            this.autoFillAutorization.UseVisualStyleBackColor = true;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 165);
            this.Controls.Add(this.autoFillAutorization);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationButton;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox autoFillAutorization;
    }
}

