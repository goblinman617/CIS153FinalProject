﻿namespace CIS153_FinalProject
{
    partial class TEST_FORM
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
            this.bnt_goback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEST_FORM";
            // 
            // bnt_goback
            // 
            this.bnt_goback.Location = new System.Drawing.Point(309, 246);
            this.bnt_goback.Name = "bnt_goback";
            this.bnt_goback.Size = new System.Drawing.Size(150, 84);
            this.bnt_goback.TabIndex = 1;
            this.bnt_goback.Text = "Go back test";
            this.bnt_goback.UseVisualStyleBackColor = true;
            this.bnt_goback.Click += new System.EventHandler(this.bnt_goback_Click);
            // 
            // TEST_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_goback);
            this.Controls.Add(this.label1);
            this.Name = "TEST_FORM";
            this.Text = "TEST_FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_goback;
    }
}