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
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lblClientBalance = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeactivateAccount = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lblIemsforReturn = new System.Windows.Forms.Label();
            this.metroTabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time until disconnection:  ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(721, 585);
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
            this.btnRefreshConnection.Location = new System.Drawing.Point(23, 579);
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
            this.Tabs.Controls.Add(this.metroTabPage5);
            this.Tabs.Location = new System.Drawing.Point(0, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(798, 514);
            this.Tabs.TabIndex = 0;
            this.Tabs.UseSelectable = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.panel4);
            this.metroTabPage5.Controls.Add(this.lblClientBalance);
            this.metroTabPage5.Controls.Add(this.lblClientName);
            this.metroTabPage5.Controls.Add(this.label13);
            this.metroTabPage5.Controls.Add(this.btnDeactivateAccount);
            this.metroTabPage5.Controls.Add(this.panel3);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(790, 472);
            this.metroTabPage5.TabIndex = 5;
            this.metroTabPage5.Text = "Deactivation ";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnCharge);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Location = new System.Drawing.Point(107, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 110);
            this.panel4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return via cash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharge.Location = new System.Drawing.Point(44, 64);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(243, 34);
            this.btnCharge.TabIndex = 3;
            this.btnCharge.Text = "Return via bank account";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(226, 20);
            this.label23.TabIndex = 6;
            this.label23.Text = "Amount that must be returned:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // lblClientBalance
            // 
            this.lblClientBalance.AutoSize = true;
            this.lblClientBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientBalance.Location = new System.Drawing.Point(110, 46);
            this.lblClientBalance.Name = "lblClientBalance";
            this.lblClientBalance.Size = new System.Drawing.Size(119, 20);
            this.lblClientBalance.TabIndex = 6;
            this.lblClientBalance.Text = "Client Balance: ";
            this.lblClientBalance.Click += new System.EventHandler(this.lblClientBalance_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(110, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(103, 20);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "Client Name: ";
            this.lblClientName.Click += new System.EventHandler(this.lblClientName_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, -82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Items That Have Not Been Returned ";
            // 
            // btnDeactivateAccount
            // 
            this.btnDeactivateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateAccount.Location = new System.Drawing.Point(107, 398);
            this.btnDeactivateAccount.Name = "btnDeactivateAccount";
            this.btnDeactivateAccount.Size = new System.Drawing.Size(172, 34);
            this.btnDeactivateAccount.TabIndex = 3;
            this.btnDeactivateAccount.Text = "Deactivate account";
            this.btnDeactivateAccount.UseVisualStyleBackColor = true;
            this.btnDeactivateAccount.Click += new System.EventHandler(this.btnDeactivateAccount_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAmountDue);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.lblIemsforReturn);
            this.panel3.Location = new System.Drawing.Point(107, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 202);
            this.panel3.TabIndex = 7;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(3, 169);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(445, 16);
            this.lblAmountDue.TabIndex = 6;
            this.lblAmountDue.Text = "*If there are any unreturned items please send the guest to the items stand.";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(7, 35);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(560, 121);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // lblIemsforReturn
            // 
            this.lblIemsforReturn.AutoSize = true;
            this.lblIemsforReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIemsforReturn.Location = new System.Drawing.Point(3, 12);
            this.lblIemsforReturn.Name = "lblIemsforReturn";
            this.lblIemsforReturn.Size = new System.Drawing.Size(272, 20);
            this.lblIemsforReturn.TabIndex = 4;
            this.lblIemsforReturn.Text = "Items That Have Not Been Returned ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshConnection);
            this.Name = "Form1";
            this.Text = "Festival - Deactivation Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private System.Windows.Forms.Button btnDeactivateAccount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIemsforReturn;
        private System.Windows.Forms.Label lblClientBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.ListBox listBox3;
    }
}

