﻿namespace CIS153_FinalProject {
    partial class Main_Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.btn_open_stats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_open_stats
            // 
            this.btn_open_stats.Location = new System.Drawing.Point(68, 338);
            this.btn_open_stats.Name = "btn_open_stats";
            this.btn_open_stats.Size = new System.Drawing.Size(107, 49);
            this.btn_open_stats.TabIndex = 1;
            this.btn_open_stats.Text = "Open Stats";
            this.btn_open_stats.UseVisualStyleBackColor = true;
            this.btn_open_stats.Click += new System.EventHandler(this.btn_open_stats_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_open_stats);
            this.Controls.Add(this.button1);
            this.Name = "Main_Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_open_stats;
    }
}

