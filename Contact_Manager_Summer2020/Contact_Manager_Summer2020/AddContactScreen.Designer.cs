namespace Contact_Manager_Summer2020
{
    partial class AddContactScreen
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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.buttonNewContact = new System.Windows.Forms.Button();
            this.buttonSaveAndExit = new System.Windows.Forms.Button();
            this.textStreet = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.textState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(-1, 0);
            this.Title.MaximumSize = new System.Drawing.Size(300, 125);
            this.Title.MinimumSize = new System.Drawing.Size(315, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(315, 58);
            this.Title.TabIndex = 0;
            this.Title.Text = "Contact";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(52, 75);
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
            this.EmailLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(52, 152);
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
            this.DescriptionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(615, 53);
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
            this.PhoneLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneLabel.Location = new System.Drawing.Point(52, 113);
            this.PhoneLabel.MaximumSize = new System.Drawing.Size(175, 50);
            this.PhoneLabel.MinimumSize = new System.Drawing.Size(100, 35);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(100, 35);
            this.PhoneLabel.TabIndex = 4;
            this.PhoneLabel.Text = "Phone:";
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textFirstName.Location = new System.Drawing.Point(131, 81);
            this.textFirstName.MinimumSize = new System.Drawing.Size(225, 25);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(225, 29);
            this.textFirstName.TabIndex = 0;
            this.textFirstName.Text = "First";
            this.textFirstName.Click += new System.EventHandler(this.textFirstName_Enter);
            this.textFirstName.Enter += new System.EventHandler(this.textFirstName_Enter);
            this.textFirstName.Leave += new System.EventHandler(this.textFirstName_Leave);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textEmail.Location = new System.Drawing.Point(168, 158);
            this.textEmail.MinimumSize = new System.Drawing.Size(225, 25);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(383, 29);
            this.textEmail.TabIndex = 3;
            this.textEmail.Text = "someone@example.com";
            this.textEmail.Click += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textPhone.Location = new System.Drawing.Point(168, 120);
            this.textPhone.MinimumSize = new System.Drawing.Size(225, 25);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(383, 29);
            this.textPhone.TabIndex = 2;
            this.textPhone.Text = "###-###-####";
            this.textPhone.Click += new System.EventHandler(this.textPhone_Enter);
            this.textPhone.Enter += new System.EventHandler(this.textPhone_Enter);
            this.textPhone.Leave += new System.EventHandler(this.textPhone_Leave);
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.textDescription.Location = new System.Drawing.Point(620, 84);
            this.textDescription.MaximumSize = new System.Drawing.Size(160, 120);
            this.textDescription.MinimumSize = new System.Drawing.Size(220, 300);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(220, 300);
            this.textDescription.TabIndex = 8;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddContact.Location = new System.Drawing.Point(324, 393);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(212, 33);
            this.buttonAddContact.TabIndex = 10;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // buttonNewContact
            // 
            this.buttonNewContact.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewContact.Location = new System.Drawing.Point(12, 393);
            this.buttonNewContact.Name = "buttonNewContact";
            this.buttonNewContact.Size = new System.Drawing.Size(212, 33);
            this.buttonNewContact.TabIndex = 9;
            this.buttonNewContact.Text = "New Contact";
            this.buttonNewContact.UseVisualStyleBackColor = true;
            this.buttonNewContact.Click += new System.EventHandler(this.buttonNewContact_Click);
            // 
            // buttonSaveAndExit
            // 
            this.buttonSaveAndExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAndExit.Location = new System.Drawing.Point(628, 393);
            this.buttonSaveAndExit.Name = "buttonSaveAndExit";
            this.buttonSaveAndExit.Size = new System.Drawing.Size(212, 33);
            this.buttonSaveAndExit.TabIndex = 11;
            this.buttonSaveAndExit.Text = "Save and Exit";
            this.buttonSaveAndExit.UseVisualStyleBackColor = true;
            this.buttonSaveAndExit.Click += new System.EventHandler(this.buttonSaveAndExit_Click);
            // 
            // textStreet
            // 
            this.textStreet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStreet.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textStreet.Location = new System.Drawing.Point(30, 232);
            this.textStreet.MinimumSize = new System.Drawing.Size(225, 25);
            this.textStreet.Name = "textStreet";
            this.textStreet.Size = new System.Drawing.Size(383, 29);
            this.textStreet.TabIndex = 4;
            this.textStreet.Text = "Street";
            this.textStreet.Click += new System.EventHandler(this.textStreet_Enter);
            this.textStreet.Enter += new System.EventHandler(this.textStreet_Enter);
            this.textStreet.Leave += new System.EventHandler(this.textStreet_Leave);
            // 
            // textCity
            // 
            this.textCity.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCity.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCity.Location = new System.Drawing.Point(30, 267);
            this.textCity.MinimumSize = new System.Drawing.Size(225, 25);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(383, 29);
            this.textCity.TabIndex = 5;
            this.textCity.Text = "City";
            this.textCity.Click += new System.EventHandler(this.textCity_Enter);
            this.textCity.Enter += new System.EventHandler(this.textCity_Enter);
            this.textCity.Leave += new System.EventHandler(this.textCity_Leave);
            // 
            // textLastName
            // 
            this.textLastName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textLastName.Location = new System.Drawing.Point(371, 81);
            this.textLastName.MinimumSize = new System.Drawing.Size(225, 25);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(225, 29);
            this.textLastName.TabIndex = 1;
            this.textLastName.Text = "Last";
            this.textLastName.Click += new System.EventHandler(this.textLastName_Enter);
            this.textLastName.Enter += new System.EventHandler(this.textLastName_Enter);
            this.textLastName.Leave += new System.EventHandler(this.textLastName_Leave);
            // 
            // textZip
            // 
            this.textZip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textZip.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textZip.Location = new System.Drawing.Point(30, 337);
            this.textZip.MinimumSize = new System.Drawing.Size(225, 25);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(383, 29);
            this.textZip.TabIndex = 7;
            this.textZip.Text = "Zip";
            this.textZip.Click += new System.EventHandler(this.textZip_Enter);
            this.textZip.Enter += new System.EventHandler(this.textZip_Enter);
            this.textZip.Leave += new System.EventHandler(this.textZip_Leave);
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StreetLabel.Location = new System.Drawing.Point(3, 196);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(93, 33);
            this.StreetLabel.TabIndex = 18;
            this.StreetLabel.Text = "Address:";
            // 
            // textState
            // 
            this.textState.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textState.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textState.Location = new System.Drawing.Point(30, 302);
            this.textState.MinimumSize = new System.Drawing.Size(225, 25);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(383, 29);
            this.textState.TabIndex = 6;
            this.textState.Text = "State";
            this.textState.Click += new System.EventHandler(this.textStreet_Enter);
            this.textState.Enter += new System.EventHandler(this.textState_Enter);
            this.textState.Leave += new System.EventHandler(this.textState_Leave);
            // 
            // AddContactScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textStreet);
            this.Controls.Add(this.buttonSaveAndExit);
            this.Controls.Add(this.buttonNewContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Title);
            this.Name = "AddContactScreen";
            this.Text = "AddContactScreen";
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
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonNewContact;
        private System.Windows.Forms.Button buttonSaveAndExit;
        private System.Windows.Forms.TextBox textStreet;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox textState;
    }
}

