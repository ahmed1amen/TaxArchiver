namespace TaxArchiver
{
    partial class settings
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.button1.Location = new System.Drawing.Point(175, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_server.Location = new System.Drawing.Point(136, 21);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(390, 38);
            this.txt_server.TabIndex = 1;
            this.txt_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_username.Location = new System.Drawing.Point(136, 146);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(390, 38);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_password.Location = new System.Drawing.Point(136, 214);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(390, 38);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_database
            // 
            this.txt_database.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_database.Location = new System.Drawing.Point(136, 282);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(390, 38);
            this.txt_database.TabIndex = 4;
            this.txt_database.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_port
            // 
            this.txt_port.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_port.Location = new System.Drawing.Point(136, 83);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(390, 38);
            this.txt_port.TabIndex = 5;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(15, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(72, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_database);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}