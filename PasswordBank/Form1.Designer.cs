
namespace PasswordBank
{
    partial class PasswordBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordBank));
            this.btn_Generate = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_SavePassword = new System.Windows.Forms.Button();
            this.btn_ShowPassword = new System.Windows.Forms.Button();
            this.tb_Website = new System.Windows.Forms.TextBox();
            this.lb_Generate_Password_Field = new System.Windows.Forms.Label();
            this.lb_Website = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Generate.FlatAppearance.BorderSize = 0;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.ForeColor = System.Drawing.Color.White;
            this.btn_Generate.Location = new System.Drawing.Point(167, 271);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(149, 39);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate Password";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Password.Location = new System.Drawing.Point(12, 160);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.ReadOnly = true;
            this.tb_Password.Size = new System.Drawing.Size(254, 38);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SavePassword
            // 
            this.btn_SavePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_SavePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SavePassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SavePassword.FlatAppearance.BorderSize = 0;
            this.btn_SavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SavePassword.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavePassword.ForeColor = System.Drawing.Color.White;
            this.btn_SavePassword.Location = new System.Drawing.Point(12, 271);
            this.btn_SavePassword.Name = "btn_SavePassword";
            this.btn_SavePassword.Size = new System.Drawing.Size(149, 39);
            this.btn_SavePassword.TabIndex = 3;
            this.btn_SavePassword.Text = "Save Password";
            this.btn_SavePassword.UseVisualStyleBackColor = false;
            this.btn_SavePassword.Click += new System.EventHandler(this.btn_SavePassword_Click);
            // 
            // btn_ShowPassword
            // 
            this.btn_ShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(81)))), ((int)(((byte)(103)))));
            this.btn_ShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ShowPassword.FlatAppearance.BorderSize = 0;
            this.btn_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPassword.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowPassword.ForeColor = System.Drawing.Color.White;
            this.btn_ShowPassword.Location = new System.Drawing.Point(322, 271);
            this.btn_ShowPassword.Name = "btn_ShowPassword";
            this.btn_ShowPassword.Size = new System.Drawing.Size(149, 39);
            this.btn_ShowPassword.TabIndex = 4;
            this.btn_ShowPassword.Text = "Show Password";
            this.btn_ShowPassword.UseVisualStyleBackColor = false;
            this.btn_ShowPassword.Click += new System.EventHandler(this.btn_ShowPassword_Click);
            // 
            // tb_Website
            // 
            this.tb_Website.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Website.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Website.Location = new System.Drawing.Point(12, 84);
            this.tb_Website.Name = "tb_Website";
            this.tb_Website.ReadOnly = true;
            this.tb_Website.Size = new System.Drawing.Size(254, 38);
            this.tb_Website.TabIndex = 5;
            this.tb_Website.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Generate_Password_Field
            // 
            this.lb_Generate_Password_Field.AutoSize = true;
            this.lb_Generate_Password_Field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lb_Generate_Password_Field.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Generate_Password_Field.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Generate_Password_Field.Location = new System.Drawing.Point(12, 140);
            this.lb_Generate_Password_Field.Name = "lb_Generate_Password_Field";
            this.lb_Generate_Password_Field.Size = new System.Drawing.Size(145, 17);
            this.lb_Generate_Password_Field.TabIndex = 6;
            this.lb_Generate_Password_Field.Text = "Generated Password";
            // 
            // lb_Website
            // 
            this.lb_Website.AutoSize = true;
            this.lb_Website.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.lb_Website.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.lb_Website.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Website.Location = new System.Drawing.Point(12, 64);
            this.lb_Website.Name = "lb_Website";
            this.lb_Website.Size = new System.Drawing.Size(62, 17);
            this.lb_Website.TabIndex = 7;
            this.lb_Website.Text = "Website";
            // 
            // PasswordBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(486, 322);
            this.Controls.Add(this.lb_Website);
            this.Controls.Add(this.lb_Generate_Password_Field);
            this.Controls.Add(this.tb_Website);
            this.Controls.Add(this.btn_ShowPassword);
            this.Controls.Add(this.btn_SavePassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.btn_Generate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password Bank - Myles Megaffin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_SavePassword;
        private System.Windows.Forms.Button btn_ShowPassword;
        private System.Windows.Forms.TextBox tb_Website;
        private System.Windows.Forms.Label lb_Generate_Password_Field;
        private System.Windows.Forms.Label lb_Website;
    }
}

