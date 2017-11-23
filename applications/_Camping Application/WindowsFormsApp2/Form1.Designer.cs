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
            this.btnRefreshConnection = new MetroFramework.Controls.MetroButton();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.tpCamping = new MetroFramework.Controls.MetroTabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.lbAmountPayable = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbVisitors = new System.Windows.Forms.ListBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.metroTabPage1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tpCamping.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time until disconnection:  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(731, 595);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(49, 20);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "20:00";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
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
            // btnRefreshConnection
            // 
            this.btnRefreshConnection.Location = new System.Drawing.Point(23, 580);
            this.btnRefreshConnection.Name = "btnRefreshConnection";
            this.btnRefreshConnection.Size = new System.Drawing.Size(140, 35);
            this.btnRefreshConnection.TabIndex = 4;
            this.btnRefreshConnection.Text = "Refresh Connection";
            this.btnRefreshConnection.UseSelectable = true;
            this.btnRefreshConnection.Click += new System.EventHandler(this.btnLogin_Click);
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
            // Tabs
            // 
            this.Tabs.Controls.Add(this.metroTabPage1);
            this.Tabs.Controls.Add(this.tpCamping);
            this.Tabs.Controls.Add(this.metroTabPage2);
            this.Tabs.Location = new System.Drawing.Point(0, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 2;
            this.Tabs.Size = new System.Drawing.Size(798, 514);
            this.Tabs.TabIndex = 0;
            this.Tabs.UseSelectable = true;
            // 
            // tpCamping
            // 
            this.tpCamping.Controls.Add(this.label22);
            this.tpCamping.Controls.Add(this.lbAmountPayable);
            this.tpCamping.Controls.Add(this.btnPay);
            this.tpCamping.Controls.Add(this.lbVisitors);
            this.tpCamping.HorizontalScrollbarBarColor = true;
            this.tpCamping.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCamping.HorizontalScrollbarSize = 10;
            this.tpCamping.Location = new System.Drawing.Point(4, 38);
            this.tpCamping.Name = "tpCamping";
            this.tpCamping.Size = new System.Drawing.Size(790, 472);
            this.tpCamping.TabIndex = 4;
            this.tpCamping.Text = "Check In/Pay For Reservation ";
            this.tpCamping.VerticalScrollbarBarColor = true;
            this.tpCamping.VerticalScrollbarHighlightOnWheel = false;
            this.tpCamping.VerticalScrollbarSize = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 196);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(231, 91);
            this.label22.TabIndex = 10;
            this.label22.Text = resources.GetString("label22.Text");
            // 
            // lbAmountPayable
            // 
            this.lbAmountPayable.AutoSize = true;
            this.lbAmountPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPayable.Location = new System.Drawing.Point(51, 133);
            this.lbAmountPayable.Name = "lbAmountPayable";
            this.lbAmountPayable.Size = new System.Drawing.Size(134, 20);
            this.lbAmountPayable.TabIndex = 9;
            this.lbAmountPayable.Text = "Amount Due: 130";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(19, 43);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(204, 78);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay Camping Spot";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbVisitors
            // 
            this.lbVisitors.FormattingEnabled = true;
            this.lbVisitors.Location = new System.Drawing.Point(243, 43);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(539, 329);
            this.lbVisitors.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.button2);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.comboBox1);
            this.metroTabPage2.Controls.Add(this.listBox1);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.panel3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(790, 472);
            this.metroTabPage2.TabIndex = 5;
            this.metroTabPage2.Text = "Make Reservation";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 108);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose a champing spot";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 25);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add participant ( Maximum of 6 )";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(51, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 83);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add participant to reservation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Participant ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(48, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "List of all participants ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(51, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Make reservation ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightCoral;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(450, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 96);
            this.label12.TabIndex = 14;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshConnection);
            this.Name = "Form1";
            this.Text = "Festival - Camping Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tpCamping.ResumeLayout(false);
            this.tpCamping.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage tpCamping;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbAmountPayable;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListBox lbVisitors;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

