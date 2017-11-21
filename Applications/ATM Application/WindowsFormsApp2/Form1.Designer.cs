namespace WindowsFormsApp2
{
    partial class ATM_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM_Application));
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
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.metroTabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tpEntrance.SuspendLayout();
            this.pnlSuccess.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tpEntrance.Controls.Add(this.button2);
            this.tpEntrance.Controls.Add(this.lblInterface);
            this.tpEntrance.Controls.Add(this.pnlSuccess);
            this.tpEntrance.Controls.Add(this.lblPhoneNumber);
            this.tpEntrance.Controls.Add(this.label26);
            this.tpEntrance.Controls.Add(this.label24);
            this.tpEntrance.Controls.Add(this.lblFirstName);
            this.tpEntrance.Controls.Add(this.panel3);
            this.tpEntrance.Controls.Add(this.panel4);
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
            this.lblInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterface.Location = new System.Drawing.Point(60, 47);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(185, 50);
            this.lblInterface.TabIndex = 14;
            this.lblInterface.Text = "Please Scan Your\r\nRFID chip";
            // 
            // pnlSuccess
            // 
            this.pnlSuccess.BackColor = System.Drawing.Color.Green;
            this.pnlSuccess.Controls.Add(this.label30);
            this.pnlSuccess.Location = new System.Drawing.Point(312, 47);
            this.pnlSuccess.Name = "pnlSuccess";
            this.pnlSuccess.Size = new System.Drawing.Size(384, 50);
            this.pnlSuccess.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(162, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 20);
            this.label30.TabIndex = 1;
            this.label30.Text = "Success";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(358, 201);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 18);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(358, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 18);
            this.label26.TabIndex = 11;
            this.label26.Text = "Account balance:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(37, 201);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 18);
            this.label24.TabIndex = 11;
            this.label24.Text = "Last name:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(37, 156);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 18);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "First name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(40, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 95);
            this.panel3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select the amount of money you would like to deposit";
            this.label1.Click += new System.EventHandler(this.label24_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(31, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(717, 95);
            this.panel4.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ATM_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshConnection);
            this.Name = "ATM_Application";
            this.Text = " ATM Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tpEntrance.ResumeLayout(false);
            this.tpEntrance.PerformLayout();
            this.pnlSuccess.ResumeLayout(false);
            this.pnlSuccess.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel pnlSuccess;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}

