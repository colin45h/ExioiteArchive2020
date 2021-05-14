namespace Contact_Manager_Summer2020
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.NewUser_Button = new System.Windows.Forms.Button();
            this.labelDHA = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.ContactManagerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Login_Button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(327, 283);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(157, 39);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // NewUser_Button
            // 
            this.NewUser_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NewUser_Button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUser_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewUser_Button.Location = new System.Drawing.Point(634, 400);
            this.NewUser_Button.Name = "NewUser_Button";
            this.NewUser_Button.Size = new System.Drawing.Size(154, 28);
            this.NewUser_Button.TabIndex = 3;
            this.NewUser_Button.Text = "Create Account";
            this.NewUser_Button.UseVisualStyleBackColor = false;
            this.NewUser_Button.Click += new System.EventHandler(this.NewUser_Button_Click);
            // 
            // labelDHA
            // 
            this.labelDHA.AutoSize = true;
            this.labelDHA.BackColor = System.Drawing.Color.Transparent;
            this.labelDHA.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDHA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDHA.Location = new System.Drawing.Point(472, 402);
            this.labelDHA.Name = "labelDHA";
            this.labelDHA.Size = new System.Drawing.Size(156, 23);
            this.labelDHA.TabIndex = 4;
            this.labelDHA.Text = "Don\'t have an account?";
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.White;
            this.textPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPass.Location = new System.Drawing.Point(280, 202);
            this.textPass.MinimumSize = new System.Drawing.Size(240, 45);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(240, 20);
            this.textPass.TabIndex = 1;
            this.textPass.Text = "Password";
            this.textPass.Enter += new System.EventHandler(this.textPass_Enter);
            this.textPass.Leave += new System.EventHandler(this.textPass_Leave);
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.White;
            this.textUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textUser.Location = new System.Drawing.Point(280, 147);
            this.textUser.MinimumSize = new System.Drawing.Size(240, 45);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(240, 20);
            this.textUser.TabIndex = 0;
            this.textUser.Text = "Username";
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // ContactManagerLabel
            // 
            this.ContactManagerLabel.AutoSize = true;
            this.ContactManagerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContactManagerLabel.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactManagerLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ContactManagerLabel.Location = new System.Drawing.Point(290, 90);
            this.ContactManagerLabel.MinimumSize = new System.Drawing.Size(250, 30);
            this.ContactManagerLabel.Name = "ContactManagerLabel";
            this.ContactManagerLabel.Size = new System.Drawing.Size(250, 35);
            this.ContactManagerLabel.TabIndex = 5;
            this.ContactManagerLabel.Text = "Contact Manager";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContactManagerLabel);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.labelDHA);
            this.Controls.Add(this.NewUser_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button NewUser_Button;
        private System.Windows.Forms.Label labelDHA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label ContactManagerLabel;
    }
}