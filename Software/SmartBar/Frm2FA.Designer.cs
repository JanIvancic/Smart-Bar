﻿namespace SmartBar
{
    partial class Frm2FA
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMFA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite kod poslan e-mailom:";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(53, 100);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(96, 28);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Provjeri";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMFA
            // 
            this.txtMFA.Location = new System.Drawing.Point(12, 52);
            this.txtMFA.Name = "txtMFA";
            this.txtMFA.Size = new System.Drawing.Size(251, 22);
            this.txtMFA.TabIndex = 3;
            // 
            // Frm2FA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 176);
            this.Controls.Add(this.txtMFA);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Name = "Frm2FA";
            this.Text = "Dvofaktorska autentifikacija";
            this.Load += new System.EventHandler(this.Frm2FA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMFA;
    }
}