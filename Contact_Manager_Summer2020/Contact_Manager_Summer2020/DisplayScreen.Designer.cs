namespace Contact_Manager_Summer2020
{
    partial class DisplayScreen
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
            this.displayContacts = new System.Windows.Forms.ListView();
            this.colFirst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelContactsList = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // displayContacts
            // 
            this.displayContacts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.displayContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFirst,
            this.colLast,
            this.colPhone,
            this.colEmail,
            this.colStreet,
            this.colCity,
            this.colState,
            this.colZip,
            this.colDescript});
            this.displayContacts.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayContacts.ForeColor = System.Drawing.Color.White;
            this.displayContacts.GridLines = true;
            this.displayContacts.HideSelection = false;
            this.displayContacts.Location = new System.Drawing.Point(17, 30);
            this.displayContacts.Name = "displayContacts";
            this.displayContacts.Size = new System.Drawing.Size(763, 351);
            this.displayContacts.TabIndex = 0;
            this.displayContacts.UseCompatibleStateImageBehavior = false;
            this.displayContacts.View = System.Windows.Forms.View.Details;
            // 
            // colFirst
            // 
            this.colFirst.Text = "First";
            this.colFirst.Width = 75;
            // 
            // colLast
            // 
            this.colLast.Text = "Last";
            this.colLast.Width = 75;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone";
            this.colPhone.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            this.colEmail.Width = 100;
            // 
            // colStreet
            // 
            this.colStreet.Text = "Street";
            this.colStreet.Width = 110;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 100;
            // 
            // colState
            // 
            this.colState.Text = "State";
            // 
            // colZip
            // 
            this.colZip.Text = "Zip";
            this.colZip.Width = 50;
            // 
            // colDescript
            // 
            this.colDescript.Text = "Description";
            this.colDescript.Width = 150;
            // 
            // labelContactsList
            // 
            this.labelContactsList.AutoSize = true;
            this.labelContactsList.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactsList.ForeColor = System.Drawing.SystemColors.Window;
            this.labelContactsList.Location = new System.Drawing.Point(12, -2);
            this.labelContactsList.Name = "labelContactsList";
            this.labelContactsList.Size = new System.Drawing.Size(82, 29);
            this.labelContactsList.TabIndex = 1;
            this.labelContactsList.Text = "Contacts";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(12, 387);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(212, 33);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView.Location = new System.Drawing.Point(17, 30);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(763, 351);
            this.dataGridView.TabIndex = 13;
            // 
            // DisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelContactsList);
            this.Controls.Add(this.displayContacts);
            this.Name = "DisplayScreen";
            this.Text = "DisplayScreen";
            this.Load += new System.EventHandler(this.DisplayScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView displayContacts;
        private System.Windows.Forms.ColumnHeader colFirst;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colDescript;
        private System.Windows.Forms.Label labelContactsList;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ColumnHeader colStreet;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colZip;
        private System.Windows.Forms.ColumnHeader colLast;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}