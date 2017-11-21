namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.tbNameOrId = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnRefreshConnection = new MetroFramework.Controls.MetroButton();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.tpEntrance = new MetroFramework.Controls.MetroTabPage();
            this.lblInterface = new System.Windows.Forms.Label();
            this.pnlSuccess = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlNotFound = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.tbCreditCardDetails = new MetroFramework.Controls.MetroTextBox();
            this.tbeMail = new MetroFramework.Controls.MetroTextBox();
            this.tbDoB = new MetroFramework.Controls.MetroTextBox();
            this.tbLastName = new MetroFramework.Controls.MetroTextBox();
            this.tbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tpEntrance.SuspendLayout();
            this.pnlSuccess.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlNotFound.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time until disconnection:  ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(729, 591);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(49, 20);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "20:00";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.lblConnection);
            this.metroTabPage1.Controls.Add(this.tbNameOrId);
            this.metroTabPage1.Controls.Add(this.tbPassword);
            this.metroTabPage1.Controls.Add(this.btnLogOut);
            this.metroTabPage1.Controls.Add(this.btnLogin);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(790, 472);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1098, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Refresh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(663, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 55);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(663, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 55);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(649, 68);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(132, 24);
            this.lblConnection.TabIndex = 7;
            this.lblConnection.Text = "Account status";
            this.lblConnection.Click += new System.EventHandler(this.lblConnection_Click);
            // 
            // tbNameOrId
            // 
            this.tbNameOrId.Lines = new string[] {
        "Name/Id"};
            this.tbNameOrId.Location = new System.Drawing.Point(191, 111);
            this.tbNameOrId.MaxLength = 32767;
            this.tbNameOrId.Multiline = true;
            this.tbNameOrId.Name = "tbNameOrId";
            this.tbNameOrId.PasswordChar = '\0';
            this.tbNameOrId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNameOrId.SelectedText = "";
            this.tbNameOrId.Size = new System.Drawing.Size(410, 43);
            this.tbNameOrId.TabIndex = 5;
            this.tbNameOrId.Text = "Name/Id";
            this.tbNameOrId.UseSelectable = true;
            this.tbNameOrId.Click += new System.EventHandler(this.tbNameOrId_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Lines = new string[] {
        "Password"};
            this.tbPassword.Location = new System.Drawing.Point(191, 160);
            this.tbPassword.MaxLength = 10;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(410, 43);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSelectable = true;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(399, 209);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(202, 41);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(191, 209);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRefreshConnection
            // 
            this.btnRefreshConnection.Location = new System.Drawing.Point(23, 583);
            this.btnRefreshConnection.Name = "btnRefreshConnection";
            this.btnRefreshConnection.Size = new System.Drawing.Size(140, 35);
            this.btnRefreshConnection.TabIndex = 4;
            this.btnRefreshConnection.Text = "Refresh Connection";
            this.btnRefreshConnection.UseSelectable = true;
            this.btnRefreshConnection.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.metroTabPage1);
            this.Tabs.Controls.Add(this.tpEntrance);
            this.Tabs.Location = new System.Drawing.Point(0, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 1;
            this.Tabs.Size = new System.Drawing.Size(798, 514);
            this.Tabs.TabIndex = 0;
            this.Tabs.UseSelectable = true;
            // 
            // tpEntrance
            // 
            this.tpEntrance.Controls.Add(this.lblInterface);
            this.tpEntrance.Controls.Add(this.pnlSuccess);
            this.tpEntrance.Controls.Add(this.panel5);
            this.tpEntrance.Controls.Add(this.btnCreateAccount);
            this.tpEntrance.Controls.Add(this.label1);
            this.tpEntrance.Controls.Add(this.lblPhoneNumber);
            this.tpEntrance.Controls.Add(this.label27);
            this.tpEntrance.Controls.Add(this.label26);
            this.tpEntrance.Controls.Add(this.label25);
            this.tpEntrance.Controls.Add(this.label24);
            this.tpEntrance.Controls.Add(this.lblFirstName);
            this.tpEntrance.Controls.Add(this.label28);
            this.tpEntrance.Controls.Add(this.label31);
            this.tpEntrance.Controls.Add(this.lblPassword);
            this.tpEntrance.Controls.Add(this.tbPhoneNumber);
            this.tpEntrance.Controls.Add(this.tbCreditCardDetails);
            this.tpEntrance.Controls.Add(this.tbeMail);
            this.tpEntrance.Controls.Add(this.tbDoB);
            this.tpEntrance.Controls.Add(this.tbLastName);
            this.tpEntrance.Controls.Add(this.tbFirstName);
            this.tpEntrance.HorizontalScrollbarBarColor = true;
            this.tpEntrance.HorizontalScrollbarHighlightOnWheel = false;
            this.tpEntrance.HorizontalScrollbarSize = 10;
            this.tpEntrance.Location = new System.Drawing.Point(4, 38);
            this.tpEntrance.Name = "tpEntrance";
            this.tpEntrance.Size = new System.Drawing.Size(790, 472);
            this.tpEntrance.TabIndex = 6;
            this.tpEntrance.Text = "Entrance";
            this.tpEntrance.VerticalScrollbarBarColor = true;
            this.tpEntrance.VerticalScrollbarHighlightOnWheel = false;
            this.tpEntrance.VerticalScrollbarSize = 10;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(20, 15);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(91, 13);
            this.lblInterface.TabIndex = 14;
            this.lblInterface.Text = "Scaning Interface";
            // 
            // pnlSuccess
            // 
            this.pnlSuccess.BackColor = System.Drawing.Color.Green;
            this.pnlSuccess.Controls.Add(this.label30);
            this.pnlSuccess.Location = new System.Drawing.Point(198, 31);
            this.pnlSuccess.Name = "pnlSuccess";
            this.pnlSuccess.Size = new System.Drawing.Size(401, 44);
            this.pnlSuccess.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(168, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 20);
            this.label30.TabIndex = 1;
            this.label30.Text = "Success";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlNotFound);
            this.panel5.Location = new System.Drawing.Point(19, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(754, 100);
            this.panel5.TabIndex = 13;
            // 
            // pnlNotFound
            // 
            this.pnlNotFound.Controls.Add(this.label29);
            this.pnlNotFound.Location = new System.Drawing.Point(179, 56);
            this.pnlNotFound.Name = "pnlNotFound";
            this.pnlNotFound.Size = new System.Drawing.Size(401, 44);
            this.pnlNotFound.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(132, 14);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 20);
            this.label29.TabIndex = 1;
            this.label29.Text = "Account Not Found";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(532, 296);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(191, 39);
            this.btnCreateAccount.TabIndex = 12;
            this.btnCreateAccount.Text = "Create account ";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 386);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 18);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 341);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 18);
            this.label27.TabIndex = 11;
            this.label27.Text = "Email";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 296);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 18);
            this.label26.TabIndex = 11;
            this.label26.Text = "Iban";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 251);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 18);
            this.label25.TabIndex = 11;
            this.label25.Text = "Date Of Birth";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 18);
            this.label24.TabIndex = 11;
            this.label24.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 161);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 18);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First Name";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(527, 175);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 25);
            this.label28.TabIndex = 10;
            this.label28.Text = "Ticket Price: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(529, 345);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(230, 39);
            this.label31.TabIndex = 10;
            this.label31.Text = "Password will be sent to the specified email. \r\nClients email and password will o" +
    "nly be needed \r\nto log into their account";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(529, 210);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(188, 39);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Ticket price is subject to an additional \r\n10 euro fee, due to not being \r\nbought" +
    " in advance.";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Lines = new string[] {
        "0882829995"};
            this.tbPhoneNumber.Location = new System.Drawing.Point(127, 386);
            this.tbPhoneNumber.MaxLength = 32767;
            this.tbPhoneNumber.Multiline = true;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.PasswordChar = '\0';
            this.tbPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPhoneNumber.SelectedText = "";
            this.tbPhoneNumber.Size = new System.Drawing.Size(381, 39);
            this.tbPhoneNumber.TabIndex = 6;
            this.tbPhoneNumber.Text = "0882829995";
            this.tbPhoneNumber.UseSelectable = true;
            // 
            // tbCreditCardDetails
            // 
            this.tbCreditCardDetails.Lines = new string[] {
        "NLBB 756 46 777 68"};
            this.tbCreditCardDetails.Location = new System.Drawing.Point(127, 296);
            this.tbCreditCardDetails.MaxLength = 32767;
            this.tbCreditCardDetails.Multiline = true;
            this.tbCreditCardDetails.Name = "tbCreditCardDetails";
            this.tbCreditCardDetails.PasswordChar = '\0';
            this.tbCreditCardDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCreditCardDetails.SelectedText = "";
            this.tbCreditCardDetails.Size = new System.Drawing.Size(381, 39);
            this.tbCreditCardDetails.TabIndex = 6;
            this.tbCreditCardDetails.Text = "NLBB 756 46 777 68";
            this.tbCreditCardDetails.UseSelectable = true;
            this.tbCreditCardDetails.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // tbeMail
            // 
            this.tbeMail.Lines = new string[] {
        "gramatikovbobby@gmail.com"};
            this.tbeMail.Location = new System.Drawing.Point(127, 341);
            this.tbeMail.MaxLength = 32767;
            this.tbeMail.Multiline = true;
            this.tbeMail.Name = "tbeMail";
            this.tbeMail.PasswordChar = '\0';
            this.tbeMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbeMail.SelectedText = "";
            this.tbeMail.Size = new System.Drawing.Size(381, 39);
            this.tbeMail.TabIndex = 6;
            this.tbeMail.Text = "gramatikovbobby@gmail.com";
            this.tbeMail.UseSelectable = true;
            // 
            // tbDoB
            // 
            this.tbDoB.Lines = new string[] {
        "01/01/1999"};
            this.tbDoB.Location = new System.Drawing.Point(127, 251);
            this.tbDoB.MaxLength = 32767;
            this.tbDoB.Multiline = true;
            this.tbDoB.Name = "tbDoB";
            this.tbDoB.PasswordChar = '\0';
            this.tbDoB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDoB.SelectedText = "";
            this.tbDoB.Size = new System.Drawing.Size(381, 39);
            this.tbDoB.TabIndex = 6;
            this.tbDoB.Text = "01/01/1999";
            this.tbDoB.UseSelectable = true;
            // 
            // tbLastName
            // 
            this.tbLastName.Lines = new string[] {
        "Bravo"};
            this.tbLastName.Location = new System.Drawing.Point(127, 206);
            this.tbLastName.MaxLength = 32767;
            this.tbLastName.Multiline = true;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(381, 39);
            this.tbLastName.TabIndex = 6;
            this.tbLastName.Text = "Bravo";
            this.tbLastName.UseSelectable = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Lines = new string[] {
        "Jonny"};
            this.tbFirstName.Location = new System.Drawing.Point(127, 161);
            this.tbFirstName.MaxLength = 32767;
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(381, 39);
            this.tbFirstName.TabIndex = 6;
            this.tbFirstName.Text = "Jonny";
            this.tbFirstName.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of days ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshConnection);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tpEntrance.ResumeLayout(false);
            this.tpEntrance.PerformLayout();
            this.pnlSuccess.ResumeLayout(false);
            this.pnlSuccess.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlNotFound.ResumeLayout(false);
            this.pnlNotFound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConnection;
        private MetroFramework.Controls.MetroTextBox tbNameOrId;
        private MetroFramework.Controls.MetroButton btnRefreshConnection;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroTabPage tpEntrance;
        private System.Windows.Forms.Label lblPassword;
        private MetroFramework.Controls.MetroTextBox tbCreditCardDetails;
        private MetroFramework.Controls.MetroTextBox tbeMail;
        private MetroFramework.Controls.MetroTextBox tbDoB;
        private MetroFramework.Controls.MetroTextBox tbLastName;
        private MetroFramework.Controls.MetroTextBox tbFirstName;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Panel pnlSuccess;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlNotFound;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private MetroFramework.Controls.MetroTextBox tbPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}

