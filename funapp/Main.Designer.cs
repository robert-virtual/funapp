
namespace funapp
{
    partial class Main
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.btn_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(958, 131);
            this.txt_user.Name = "txt_user";
            this.txt_user.PlaceholderText = "User";
            this.txt_user.Size = new System.Drawing.Size(259, 27);
            this.txt_user.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(958, 186);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(259, 27);
            this.txt_password.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(958, 252);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(259, 29);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(32, 70);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 29;
            this.dgv_users.Size = new System.Drawing.Size(893, 359);
            this.dgv_users.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(958, 400);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(259, 29);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 462);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_login;
    }
}

