﻿
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
            this.btn_Generate = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Generate.Location = new System.Drawing.Point(72, 185);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(149, 39);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate Password";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(12, 57);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.ReadOnly = true;
            this.tb_Password.Size = new System.Drawing.Size(254, 38);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.btn_Generate);
            this.Name = "PasswordBank";
            this.Text = "Password Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.TextBox tb_Password;
    }
}

