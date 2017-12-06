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
            this.Tabs = new MetroFramework.Controls.MetroTabControl();
            this.tpEntrance = new MetroFramework.Controls.MetroTabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblInterface = new System.Windows.Forms.Label();
            this.pnlSuccess = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.tpEntrance.SuspendLayout();
            this.pnlSuccess.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel28.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tpEntrance);
            this.Tabs.Location = new System.Drawing.Point(0, 63);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(798, 514);
            this.Tabs.TabIndex = 0;
            this.Tabs.UseSelectable = true;
            // 
            // tpEntrance
            // 
            this.tpEntrance.Controls.Add(this.button2);
            this.tpEntrance.Controls.Add(this.lblInterface);
            this.tpEntrance.Controls.Add(this.pnlSuccess);
            this.tpEntrance.Controls.Add(this.panel3);
            this.tpEntrance.Controls.Add(this.label4);
            this.tpEntrance.Controls.Add(this.label3);
            this.tpEntrance.Controls.Add(this.panel4);
            this.tpEntrance.Controls.Add(this.panel28);
            this.tpEntrance.HorizontalScrollbarBarColor = true;
            this.tpEntrance.HorizontalScrollbarHighlightOnWheel = false;
            this.tpEntrance.HorizontalScrollbarSize = 10;
            this.tpEntrance.Location = new System.Drawing.Point(4, 38);
            this.tpEntrance.Name = "tpEntrance";
            this.tpEntrance.Size = new System.Drawing.Size(790, 472);
            this.tpEntrance.TabIndex = 6;
            this.tpEntrance.Text = "My account";
            this.tpEntrance.VerticalScrollbarBarColor = true;
            this.tpEntrance.VerticalScrollbarHighlightOnWheel = false;
            this.tpEntrance.VerticalScrollbarSize = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(418, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
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
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(69, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 18);
            this.label26.TabIndex = 11;
            this.label26.Text = "Account balance:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(69, 50);
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
            this.lblFirstName.Location = new System.Drawing.Point(68, 9);
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
            this.panel3.Location = new System.Drawing.Point(31, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 95);
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
            this.comboBox1.Items.AddRange(new object[] {
            "5 Euro",
            "10 Euro",
            "20 Euro",
            "50 Euro",
            "100 Euro",
            "200 Euro"});
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
            // panel28
            // 
            this.panel28.Controls.Add(this.label48);
            this.panel28.Controls.Add(this.label49);
            this.panel28.Controls.Add(this.label46);
            this.panel28.Controls.Add(this.label45);
            this.panel28.Controls.Add(this.label26);
            this.panel28.Controls.Add(this.label24);
            this.panel28.Controls.Add(this.lblFirstName);
            this.panel28.Location = new System.Drawing.Point(31, 166);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(717, 117);
            this.panel28.TabIndex = 30;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(288, 88);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(161, 18);
            this.label48.TabIndex = 15;
            this.label48.Text = "Camping Spots Rented";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(527, 9);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(132, 18);
            this.label49.TabIndex = 15;
            this.label49.Text = "Total money Spent";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(288, 9);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(132, 18);
            this.label46.TabIndex = 15;
            this.label46.Text = "Total Items Rented";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(288, 50);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(132, 18);
            this.label45.TabIndex = 15;
            this.label45.Text = "Total Items Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "My details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Make a deposit";
            // 
            // ATM_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.Tabs);
            this.Name = "ATM_Application";
            this.Text = " ATM Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.tpEntrance.ResumeLayout(false);
            this.tpEntrance.PerformLayout();
            this.pnlSuccess.ResumeLayout(false);
            this.pnlSuccess.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl Tabs;
        private MetroFramework.Controls.MetroTabPage tpEntrance;
        private System.Windows.Forms.Label lblInterface;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
    }
}

