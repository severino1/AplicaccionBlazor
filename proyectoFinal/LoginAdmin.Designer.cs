﻿namespace proyectoFinal
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAdminUser = new System.Windows.Forms.TextBox();
            this.TextAdminContra = new System.Windows.Forms.TextBox();
            this.btnIncioAdmin = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TxtAdminUser
            // 
            this.TxtAdminUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminUser.Location = new System.Drawing.Point(56, 187);
            this.TxtAdminUser.Name = "TxtAdminUser";
            this.TxtAdminUser.Size = new System.Drawing.Size(238, 23);
            this.TxtAdminUser.TabIndex = 1;
            this.TxtAdminUser.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TextAdminContra
            // 
            this.TextAdminContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAdminContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAdminContra.Location = new System.Drawing.Point(56, 239);
            this.TextAdminContra.Name = "TextAdminContra";
            this.TextAdminContra.PasswordChar = '*';
            this.TextAdminContra.Size = new System.Drawing.Size(238, 23);
            this.TextAdminContra.TabIndex = 2;
            // 
            // btnIncioAdmin
            // 
            this.btnIncioAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnIncioAdmin.FlatAppearance.BorderSize = 0;
            this.btnIncioAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncioAdmin.Location = new System.Drawing.Point(56, 279);
            this.btnIncioAdmin.Name = "btnIncioAdmin";
            this.btnIncioAdmin.Size = new System.Drawing.Size(238, 37);
            this.btnIncioAdmin.TabIndex = 3;
            this.btnIncioAdmin.UseVisualStyleBackColor = false;
            this.btnIncioAdmin.Click += new System.EventHandler(this.BtnIncioAdmin_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Location = new System.Drawing.Point(53, 158);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(53, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(148, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(303, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 18);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User);
            this.Controls.Add(this.btnIncioAdmin);
            this.Controls.Add(this.TextAdminContra);
            this.Controls.Add(this.TxtAdminUser);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginAdmin";
            this.Text = "loginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAdminUser;
        private System.Windows.Forms.TextBox TextAdminContra;
        private System.Windows.Forms.Button btnIncioAdmin;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}