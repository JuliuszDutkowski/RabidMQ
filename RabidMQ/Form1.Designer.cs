namespace RabidMQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogIn1 = new System.Windows.Forms.Button();
            this.buttonRegister1 = new System.Windows.Forms.Button();
            this.textBoxLogIn = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.buttonLogin2 = new System.Windows.Forms.Button();
            this.buttonRegister2 = new System.Windows.Forms.Button();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.buttonRegistered = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelAdd2 = new System.Windows.Forms.Label();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.buttonBack4 = new System.Windows.Forms.Button();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 63);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogIn1
            // 
            this.buttonLogIn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogIn1.FlatAppearance.BorderSize = 0;
            this.buttonLogIn1.Location = new System.Drawing.Point(12, 81);
            this.buttonLogIn1.Name = "buttonLogIn1";
            this.buttonLogIn1.Size = new System.Drawing.Size(180, 80);
            this.buttonLogIn1.TabIndex = 0;
            this.buttonLogIn1.Text = "Log In";
            this.buttonLogIn1.UseVisualStyleBackColor = true;
            this.buttonLogIn1.Click += new System.EventHandler(this.buttonLogIn1_click);
            // 
            // buttonRegister1
            // 
            this.buttonRegister1.Location = new System.Drawing.Point(12, 167);
            this.buttonRegister1.Name = "buttonRegister1";
            this.buttonRegister1.Size = new System.Drawing.Size(180, 80);
            this.buttonRegister1.TabIndex = 1;
            this.buttonRegister1.Text = "Register";
            this.buttonRegister1.UseVisualStyleBackColor = true;
            this.buttonRegister1.Click += new System.EventHandler(this.buttonRegister1_click);
            // 
            // textBoxLogIn
            // 
            this.textBoxLogIn.Enabled = false;
            this.textBoxLogIn.Location = new System.Drawing.Point(12, 296);
            this.textBoxLogIn.MaxLength = 20;
            this.textBoxLogIn.Name = "textBoxLogIn";
            this.textBoxLogIn.Size = new System.Drawing.Size(180, 23);
            this.textBoxLogIn.TabIndex = 2;
            this.textBoxLogIn.Visible = false;
            this.textBoxLogIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogIn_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(12, 340);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Visible = false;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Enabled = false;
            this.labelLogIn.ForeColor = System.Drawing.Color.White;
            this.labelLogIn.Location = new System.Drawing.Point(12, 278);
            this.labelLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(60, 15);
            this.labelLogIn.TabIndex = 4;
            this.labelLogIn.Text = "Username";
            this.labelLogIn.Visible = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Enabled = false;
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(12, 322);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(57, 15);
            this.labelRegister.TabIndex = 5;
            this.labelRegister.Text = "Password";
            this.labelRegister.Visible = false;
            // 
            // buttonLogin2
            // 
            this.buttonLogin2.Enabled = false;
            this.buttonLogin2.Location = new System.Drawing.Point(198, 81);
            this.buttonLogin2.Name = "buttonLogin2";
            this.buttonLogin2.Size = new System.Drawing.Size(180, 80);
            this.buttonLogin2.TabIndex = 10;
            this.buttonLogin2.Text = "Log In";
            this.buttonLogin2.UseVisualStyleBackColor = true;
            this.buttonLogin2.Visible = false;
            this.buttonLogin2.Click += new System.EventHandler(this.buttonLogIn2_click);
            // 
            // buttonRegister2
            // 
            this.buttonRegister2.Enabled = false;
            this.buttonRegister2.Location = new System.Drawing.Point(198, 167);
            this.buttonRegister2.Name = "buttonRegister2";
            this.buttonRegister2.Size = new System.Drawing.Size(180, 80);
            this.buttonRegister2.TabIndex = 11;
            this.buttonRegister2.Text = "Register";
            this.buttonRegister2.UseVisualStyleBackColor = true;
            this.buttonRegister2.Visible = false;
            this.buttonRegister2.Click += new System.EventHandler(this.buttonRegister2_click);
            // 
            // buttonBack1
            // 
            this.buttonBack1.Enabled = false;
            this.buttonBack1.Location = new System.Drawing.Point(0, 59);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(100, 40);
            this.buttonBack1.TabIndex = 12;
            this.buttonBack1.Text = "Back";
            this.buttonBack1.UseVisualStyleBackColor = true;
            this.buttonBack1.Visible = false;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack1_click);
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Enabled = false;
            this.labelRegistered.ForeColor = System.Drawing.Color.White;
            this.labelRegistered.Location = new System.Drawing.Point(-36, 114);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(121, 30);
            this.labelRegistered.TabIndex = 14;
            this.labelRegistered.Text = "Congratulations!\r\nSuccesfully registered";
            this.labelRegistered.Visible = false;
            // 
            // buttonRegistered
            // 
            this.buttonRegistered.Enabled = false;
            this.buttonRegistered.Location = new System.Drawing.Point(-56, 167);
            this.buttonRegistered.Name = "buttonRegistered";
            this.buttonRegistered.Size = new System.Drawing.Size(180, 80);
            this.buttonRegistered.TabIndex = 15;
            this.buttonRegistered.Text = "Go To Start";
            this.buttonRegistered.UseVisualStyleBackColor = true;
            this.buttonRegistered.Visible = false;
            this.buttonRegistered.Click += new System.EventHandler(this.buttonRegistered_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Enabled = false;
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(198, 266);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(63, 15);
            this.labelWelcome.TabIndex = 16;
            this.labelWelcome.Text = "Welcome, ";
            this.labelWelcome.Visible = false;
            // 
            // buttonContacts
            // 
            this.buttonContacts.Enabled = false;
            this.buttonContacts.Location = new System.Drawing.Point(198, 319);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(180, 80);
            this.buttonContacts.TabIndex = 17;
            this.buttonContacts.Text = "Contacts";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Visible = false;
            this.buttonContacts.Click += new System.EventHandler(this.buttonContacts_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(198, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(180, 80);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add Contacts";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Enabled = false;
            this.textBoxAdd.Location = new System.Drawing.Point(12, 419);
            this.textBoxAdd.MaxLength = 20;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(180, 23);
            this.textBoxAdd.TabIndex = 20;
            this.textBoxAdd.Visible = false;
            this.textBoxAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAdd_KeyDown);
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Enabled = false;
            this.buttonAdd2.Location = new System.Drawing.Point(12, 460);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(180, 80);
            this.buttonAdd2.TabIndex = 21;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Visible = false;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Enabled = false;
            this.labelAdd.ForeColor = System.Drawing.Color.White;
            this.labelAdd.Location = new System.Drawing.Point(12, 401);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(59, 15);
            this.labelAdd.TabIndex = 22;
            this.labelAdd.Text = "username";
            this.labelAdd.Visible = false;
            // 
            // labelAdd2
            // 
            this.labelAdd2.AutoSize = true;
            this.labelAdd2.Enabled = false;
            this.labelAdd2.ForeColor = System.Drawing.Color.White;
            this.labelAdd2.Location = new System.Drawing.Point(52, 373);
            this.labelAdd2.Name = "labelAdd2";
            this.labelAdd2.Size = new System.Drawing.Size(72, 15);
            this.labelAdd2.TabIndex = 23;
            this.labelAdd2.Text = "Add contact";
            this.labelAdd2.Visible = false;
            // 
            // buttonBack2
            // 
            this.buttonBack2.Enabled = false;
            this.buttonBack2.Location = new System.Drawing.Point(12, 562);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(100, 40);
            this.buttonBack2.TabIndex = 24;
            this.buttonBack2.Text = "Back";
            this.buttonBack2.UseVisualStyleBackColor = true;
            this.buttonBack2.Visible = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonBack3
            // 
            this.buttonBack3.Enabled = false;
            this.buttonBack3.Location = new System.Drawing.Point(402, 101);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(100, 40);
            this.buttonBack3.TabIndex = 25;
            this.buttonBack3.Text = "Back";
            this.buttonBack3.UseVisualStyleBackColor = true;
            this.buttonBack3.Visible = false;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // buttonBack4
            // 
            this.buttonBack4.Enabled = false;
            this.buttonBack4.Location = new System.Drawing.Point(833, 101);
            this.buttonBack4.Name = "buttonBack4";
            this.buttonBack4.Size = new System.Drawing.Size(100, 40);
            this.buttonBack4.TabIndex = 0;
            this.buttonBack4.Text = "Back";
            this.buttonBack4.UseVisualStyleBackColor = true;
            this.buttonBack4.Visible = false;
            this.buttonBack4.Click += new System.EventHandler(this.buttonBack4_Click);
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelContacts.Location = new System.Drawing.Point(402, 147);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(400, 320);
            this.panelContacts.TabIndex = 28;
            this.panelContacts.Visible = false;
            // 
            // panelMessages
            // 
            this.panelMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMessages.Location = new System.Drawing.Point(833, 147);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(385, 380);
            this.panelMessages.TabIndex = 29;
            this.panelMessages.Visible = false;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxMessage.Location = new System.Drawing.Point(833, 473);
            this.textBoxMessage.MaxLength = 300;
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(315, 70);
            this.textBoxMessage.TabIndex = 30;
            this.textBoxMessage.Visible = false;
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(1143, 473);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(70, 70);
            this.buttonSend.TabIndex = 31;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1280, 640);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.panelContacts);
            this.Controls.Add(this.buttonBack4);
            this.Controls.Add(this.buttonBack3);
            this.Controls.Add(this.buttonBack2);
            this.Controls.Add(this.labelAdd2);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonRegistered);
            this.Controls.Add(this.labelRegistered);
            this.Controls.Add(this.buttonBack1);
            this.Controls.Add(this.buttonRegister2);
            this.Controls.Add(this.buttonLogin2);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogIn);
            this.Controls.Add(this.buttonRegister1);
            this.Controls.Add(this.buttonLogIn1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RabidMQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button buttonLogIn1;
        private Button buttonRegister1;
        private TextBox textBoxLogIn;
        private TextBox textBoxPassword;
        private Label labelLogIn;
        private Label labelRegister;
        private Button buttonLogin2;
        private Button buttonRegister2;
        private Button buttonBack1;
        private Label labelRegistered;
        private Button buttonRegistered;
        private Label labelWelcome;
        private Button buttonContacts;
        private Button buttonAdd;
        private TextBox textBoxAdd;
        private Button buttonAdd2;
        private Label labelAdd;
        private Label labelAdd2;
        private Button buttonBack2;
        private Button buttonBack3;
        private Button buttonBack4;
        private Panel panelContacts;
        private TextBox textBoxMessage;
        private Button buttonSend;
        public Panel panelMessages;
    }
}