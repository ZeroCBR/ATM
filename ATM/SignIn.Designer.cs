﻿namespace WindowsFormsApplication1
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.accountID = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.conPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.n6 = new System.Windows.Forms.Label();
            this.n7 = new System.Windows.Forms.Label();
            this.n8 = new System.Windows.Forms.Label();
            this.n9 = new System.Windows.Forms.Label();
            this.n0 = new System.Windows.Forms.Label();
            this.n00 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accountNum = new System.Windows.Forms.TextBox();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountID
            // 
            this.accountID.Location = new System.Drawing.Point(272, 61);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(100, 21);
            this.accountID.TabIndex = 1;
            this.accountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(272, 118);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 21);
            this.password.TabIndex = 3;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(172, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(172, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Register An Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(103, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password: ";
            // 
            // conPassword
            // 
            this.conPassword.Location = new System.Drawing.Point(272, 147);
            this.conPassword.Name = "conPassword";
            this.conPassword.PasswordChar = '*';
            this.conPassword.Size = new System.Drawing.Size(100, 21);
            this.conPassword.TabIndex = 4;
            this.conPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(236, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Press \"ENTER\" to continue";
            // 
            // n1
            // 
            this.n1.Image = global::WindowsFormsApplication1.Properties.Resources._20120222195943;
            this.n1.Location = new System.Drawing.Point(191, 249);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(37, 37);
            this.n1.TabIndex = 4;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            this.n1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n1_MouseDown);
            this.n1.MouseLeave += new System.EventHandler(this.n1_MouseLeave);
            this.n1.MouseHover += new System.EventHandler(this.n1_MouseHover);
            // 
            // n2
            // 
            this.n2.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200004;
            this.n2.Location = new System.Drawing.Point(231, 249);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(37, 37);
            this.n2.TabIndex = 4;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            this.n2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n2_MouseDown);
            this.n2.MouseLeave += new System.EventHandler(this.n2_MouseLeave);
            this.n2.MouseHover += new System.EventHandler(this.n2_MouseHover);
            // 
            // n3
            // 
            this.n3.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200020;
            this.n3.Location = new System.Drawing.Point(271, 249);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(37, 37);
            this.n3.TabIndex = 4;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            this.n3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n3_MouseDown);
            this.n3.MouseLeave += new System.EventHandler(this.n3_MouseLeave);
            this.n3.MouseHover += new System.EventHandler(this.n3_MouseHover);
            // 
            // n4
            // 
            this.n4.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200037;
            this.n4.Location = new System.Drawing.Point(191, 289);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(37, 37);
            this.n4.TabIndex = 4;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            this.n4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n4_MouseDown);
            this.n4.MouseLeave += new System.EventHandler(this.n4_MouseLeave);
            this.n4.MouseHover += new System.EventHandler(this.n4_MouseHover);
            // 
            // n5
            // 
            this.n5.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200053;
            this.n5.Location = new System.Drawing.Point(231, 289);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(37, 37);
            this.n5.TabIndex = 4;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            this.n5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n5_MouseDown);
            this.n5.MouseLeave += new System.EventHandler(this.n5_MouseLeave);
            this.n5.MouseHover += new System.EventHandler(this.n5_MouseHover);
            // 
            // n6
            // 
            this.n6.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200119;
            this.n6.Location = new System.Drawing.Point(271, 289);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(37, 37);
            this.n6.TabIndex = 4;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            this.n6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n6_MouseDown);
            this.n6.MouseLeave += new System.EventHandler(this.n6_MouseLeave);
            this.n6.MouseHover += new System.EventHandler(this.n6_MouseHover);
            // 
            // n7
            // 
            this.n7.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200138;
            this.n7.Location = new System.Drawing.Point(191, 329);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(37, 37);
            this.n7.TabIndex = 4;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            this.n7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n7_MouseDown);
            this.n7.MouseLeave += new System.EventHandler(this.n7_MouseLeave);
            this.n7.MouseHover += new System.EventHandler(this.n7_MouseHover);
            // 
            // n8
            // 
            this.n8.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200210;
            this.n8.Location = new System.Drawing.Point(231, 329);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(37, 37);
            this.n8.TabIndex = 4;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            this.n8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n8_MouseDown);
            this.n8.MouseLeave += new System.EventHandler(this.n8_MouseLeave);
            this.n8.MouseHover += new System.EventHandler(this.n8_MouseHover);
            // 
            // n9
            // 
            this.n9.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200225;
            this.n9.Location = new System.Drawing.Point(271, 329);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(37, 37);
            this.n9.TabIndex = 4;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            this.n9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n9_MouseDown);
            this.n9.MouseLeave += new System.EventHandler(this.n9_MouseLeave);
            this.n9.MouseHover += new System.EventHandler(this.n9_MouseHover);
            // 
            // n0
            // 
            this.n0.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200351;
            this.n0.Location = new System.Drawing.Point(231, 368);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(37, 37);
            this.n0.TabIndex = 4;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            this.n0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n0_MouseDown);
            this.n0.MouseLeave += new System.EventHandler(this.n0_MouseLeave);
            this.n0.MouseHover += new System.EventHandler(this.n0_MouseHover);
            // 
            // n00
            // 
            this.n00.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200414;
            this.n00.Location = new System.Drawing.Point(271, 368);
            this.n00.Name = "n00";
            this.n00.Size = new System.Drawing.Size(37, 37);
            this.n00.TabIndex = 4;
            this.n00.Click += new System.EventHandler(this.n00_Click);
            this.n00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.n00_MouseDown);
            this.n00.MouseLeave += new System.EventHandler(this.n00_MouseLeave);
            this.n00.MouseHover += new System.EventHandler(this.n00_MouseHover);
            // 
            // clear
            // 
            this.clear.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200647;
            this.clear.Location = new System.Drawing.Point(312, 268);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(37, 37);
            this.clear.TabIndex = 4;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clear_MouseDown);
            this.clear.MouseLeave += new System.EventHandler(this.clear_MouseLeave);
            this.clear.MouseHover += new System.EventHandler(this.clear_MouseHover);
            // 
            // exit
            // 
            this.exit.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200511;
            this.exit.Location = new System.Drawing.Point(312, 308);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(37, 37);
            this.exit.TabIndex = 4;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_MouseDown);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            this.exit.MouseHover += new System.EventHandler(this.exit_MouseHover);
            // 
            // enter
            // 
            this.enter.Image = global::WindowsFormsApplication1.Properties.Resources._20120222200542;
            this.enter.Location = new System.Drawing.Point(312, 348);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(37, 37);
            this.enter.TabIndex = 4;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            this.enter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.enter_MouseDown);
            this.enter.MouseLeave += new System.EventHandler(this.enter_MouseLeave);
            this.enter.MouseHover += new System.EventHandler(this.enter_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(143, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Account Num:";
            // 
            // accountNum
            // 
            this.accountNum.Location = new System.Drawing.Point(271, 90);
            this.accountNum.Name = "accountNum";
            this.accountNum.Size = new System.Drawing.Size(100, 21);
            this.accountNum.TabIndex = 2;
            this.accountNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(386, 316);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(211, 99);
            this.axShockwaveFlash1.TabIndex = 3;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._20120219204556副本;
            this.ClientSize = new System.Drawing.Size(638, 481);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.n00);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.accountNum);
            this.Controls.Add(this.accountID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n6;
        private System.Windows.Forms.Label n7;
        private System.Windows.Forms.Label n8;
        private System.Windows.Forms.Label n9;
        private System.Windows.Forms.Label n0;
        private System.Windows.Forms.Label n00;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountNum;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}