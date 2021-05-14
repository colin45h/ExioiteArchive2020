namespace Contact_Manager_Summer2020
{
    partial class MainScreen
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
            this.Title = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonNewContact = new System.Windows.Forms.Button();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft JhengHei", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(293, 9);
            this.Title.MaximumSize = new System.Drawing.Size(300, 125);
            this.Title.MinimumSize = new System.Drawing.Size(315, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(315, 50);
            this.Title.TabIndex = 0;
            this.Title.Text = "Contacts Manager";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(268, 87);
            this.NameLabel.MaximumSize = new System.Drawing.Size(175, 50);
            this.NameLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 35);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(105, 175);
            this.EmailLabel.MaximumSize = new System.Drawing.Size(175, 50);
            this.EmailLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(100, 35);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(167, 241);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(175, 50);
            this.DescriptionLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(100, 35);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneLabel.Location = new System.Drawing.Point(492, 175);
            this.PhoneLabel.MaximumSize = new System.Drawing.Size(175, 50);
            this.PhoneLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(100, 35);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone:";
            // 
            // textName
            // 
            this.textName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textName.Location = new System.Drawing.Point(347, 96);
            this.textName.MinimumSize = new System.Drawing.Size(225, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(225, 20);
            this.textName.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEmail.Location = new System.Drawing.Point(178, 181);
            this.textEmail.MinimumSize = new System.Drawing.Size(225, 25);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(225, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textPhone
            // 
            this.textPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPhone.Location = new System.Drawing.Point(577, 181);
            this.textPhone.MinimumSize = new System.Drawing.Size(225, 25);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(225, 20);
            this.textPhone.TabIndex = 7;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(259, 241);
            this.textDescription.MaximumSize = new System.Drawing.Size(400, 120);
            this.textDescription.MinimumSize = new System.Drawing.Size(400, 120);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(400, 20);
            this.textDescription.TabIndex = 8;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(329, 390);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(212, 33);
            this.buttonAddContact.TabIndex = 9;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            // 
            // buttonNewContact
            // 
            this.buttonNewContact.Location = new System.Drawing.Point(30, 390);
            this.buttonNewContact.Name = "buttonNewContact";
            this.buttonNewContact.Size = new System.Drawing.Size(212, 33);
            this.buttonNewContact.TabIndex = 11;
            this.buttonNewContact.Text = "New Contact";
            this.buttonNewContact.UseVisualStyleBackColor = true;
            this.buttonNewContact.Click += new System.EventHandler(this.buttonNewContact_Click);
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.Location = new System.Drawing.Point(620, 390);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(212, 33);
            this.buttonSaveAndExit.TabIndex = 12;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.buttonSaveAndExit);
            this.Controls.Add(this.buttonNewContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Title);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.OptionsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonNewContact;
        private System.Windows.Forms.Button buttonSaveAndExit;
    }
}

