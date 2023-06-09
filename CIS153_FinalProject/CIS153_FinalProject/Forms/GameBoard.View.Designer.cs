﻿namespace CIS153_FinalProject
{
    partial class GameBoard
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
            this.turnLine = new System.Windows.Forms.Label();
            this.playerOneColor = new System.Windows.Forms.Button();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerTwoColor = new System.Windows.Forms.Button();
            this.gameFlowBox = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_row_0 = new System.Windows.Forms.Button();
            this.btn_row_1 = new System.Windows.Forms.Button();
            this.btn_row_2 = new System.Windows.Forms.Button();
            this.btn_row_4 = new System.Windows.Forms.Button();
            this.btn_row_3 = new System.Windows.Forms.Button();
            this.btn_row_5 = new System.Windows.Forms.Button();
            this.btn_row_6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // turnLine
            // 
            this.turnLine.AutoSize = true;
            this.turnLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLine.Location = new System.Drawing.Point(7, 9);
            this.turnLine.Name = "turnLine";
            this.turnLine.Size = new System.Drawing.Size(178, 25);
            this.turnLine.TabIndex = 0;
            this.turnLine.Text = "Ben, it\'s your turn!";
            // 
            // playerOneColor
            // 
            this.playerOneColor.BackColor = System.Drawing.Color.Firebrick;
            this.playerOneColor.FlatAppearance.BorderSize = 0;
            this.playerOneColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerOneColor.ForeColor = System.Drawing.Color.LightGray;
            this.playerOneColor.Location = new System.Drawing.Point(9, 598);
            this.playerOneColor.Name = "playerOneColor";
            this.playerOneColor.Size = new System.Drawing.Size(38, 37);
            this.playerOneColor.TabIndex = 50;
            this.playerOneColor.UseVisualStyleBackColor = false;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(51, 604);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(46, 25);
            this.playerOneLabel.TabIndex = 51;
            this.playerOneLabel.Text = "Ben";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(236, 604);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(54, 25);
            this.playerTwoLabel.TabIndex = 53;
            this.playerTwoLabel.Text = "Matt";
            // 
            // playerTwoColor
            // 
            this.playerTwoColor.BackColor = System.Drawing.Color.Orange;
            this.playerTwoColor.FlatAppearance.BorderSize = 0;
            this.playerTwoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerTwoColor.ForeColor = System.Drawing.Color.LightGray;
            this.playerTwoColor.Location = new System.Drawing.Point(194, 598);
            this.playerTwoColor.Name = "playerTwoColor";
            this.playerTwoColor.Size = new System.Drawing.Size(38, 37);
            this.playerTwoColor.TabIndex = 52;
            this.playerTwoColor.UseVisualStyleBackColor = false;
            // 
            // gameFlowBox
            // 
            this.gameFlowBox.Location = new System.Drawing.Point(9, 77);
            this.gameFlowBox.Name = "gameFlowBox";
            this.gameFlowBox.Size = new System.Drawing.Size(568, 512);
            this.gameFlowBox.TabIndex = 54;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(435, 608);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 21);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<- Done So Soon?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backButton_LinkClicked);
            // 
            // btn_row_0
            // 
            this.btn_row_0.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_0.FlatAppearance.BorderSize = 0;
            this.btn_row_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_0.Location = new System.Drawing.Point(12, 44);
            this.btn_row_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_0.Name = "btn_row_0";
            this.btn_row_0.Size = new System.Drawing.Size(75, 30);
            this.btn_row_0.TabIndex = 63;
            this.btn_row_0.Text = "⬇";
            this.btn_row_0.UseVisualStyleBackColor = false;
            this.btn_row_0.Click += new System.EventHandler(this.btn_row_0_Click);
            this.btn_row_0.MouseEnter += new System.EventHandler(this.btn_row_0_MouseEnter);
            this.btn_row_0.MouseLeave += new System.EventHandler(this.btn_row_0_MouseLeave);
            // 
            // btn_row_1
            // 
            this.btn_row_1.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_1.FlatAppearance.BorderSize = 0;
            this.btn_row_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_1.Location = new System.Drawing.Point(93, 44);
            this.btn_row_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_1.Name = "btn_row_1";
            this.btn_row_1.Size = new System.Drawing.Size(75, 30);
            this.btn_row_1.TabIndex = 64;
            this.btn_row_1.Text = "⬇";
            this.btn_row_1.UseVisualStyleBackColor = false;
            this.btn_row_1.Click += new System.EventHandler(this.btn_row_1_Click);
            this.btn_row_1.MouseEnter += new System.EventHandler(this.btn_row_1_MouseEnter);
            this.btn_row_1.MouseLeave += new System.EventHandler(this.btn_row_1_MouseLeave);
            // 
            // btn_row_2
            // 
            this.btn_row_2.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_2.FlatAppearance.BorderSize = 0;
            this.btn_row_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_2.Location = new System.Drawing.Point(174, 44);
            this.btn_row_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_2.Name = "btn_row_2";
            this.btn_row_2.Size = new System.Drawing.Size(75, 30);
            this.btn_row_2.TabIndex = 65;
            this.btn_row_2.Text = "⬇";
            this.btn_row_2.UseVisualStyleBackColor = false;
            this.btn_row_2.Click += new System.EventHandler(this.btn_row_2_Click);
            this.btn_row_2.MouseEnter += new System.EventHandler(this.btn_row_2_MouseEnter);
            this.btn_row_2.MouseLeave += new System.EventHandler(this.btn_row_2_MouseLeave);
            // 
            // btn_row_4
            // 
            this.btn_row_4.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_4.FlatAppearance.BorderSize = 0;
            this.btn_row_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_4.Location = new System.Drawing.Point(336, 44);
            this.btn_row_4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_4.Name = "btn_row_4";
            this.btn_row_4.Size = new System.Drawing.Size(75, 30);
            this.btn_row_4.TabIndex = 67;
            this.btn_row_4.Text = "⬇";
            this.btn_row_4.UseVisualStyleBackColor = false;
            this.btn_row_4.Click += new System.EventHandler(this.btn_row_4_Click);
            this.btn_row_4.MouseEnter += new System.EventHandler(this.btn_row_4_MouseEnter);
            this.btn_row_4.MouseLeave += new System.EventHandler(this.btn_row_4_MouseLeave);
            // 
            // btn_row_3
            // 
            this.btn_row_3.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_3.FlatAppearance.BorderSize = 0;
            this.btn_row_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_3.Location = new System.Drawing.Point(255, 44);
            this.btn_row_3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_3.Name = "btn_row_3";
            this.btn_row_3.Size = new System.Drawing.Size(75, 30);
            this.btn_row_3.TabIndex = 66;
            this.btn_row_3.Text = "⬇";
            this.btn_row_3.UseVisualStyleBackColor = false;
            this.btn_row_3.Click += new System.EventHandler(this.btn_row_3_Click);
            this.btn_row_3.MouseEnter += new System.EventHandler(this.btn_row_3_MouseEnter);
            this.btn_row_3.MouseLeave += new System.EventHandler(this.btn_row_3_MouseLeave);
            // 
            // btn_row_5
            // 
            this.btn_row_5.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_5.FlatAppearance.BorderSize = 0;
            this.btn_row_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_5.Location = new System.Drawing.Point(417, 44);
            this.btn_row_5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_5.Name = "btn_row_5";
            this.btn_row_5.Size = new System.Drawing.Size(75, 30);
            this.btn_row_5.TabIndex = 68;
            this.btn_row_5.Text = "⬇";
            this.btn_row_5.UseVisualStyleBackColor = false;
            this.btn_row_5.Click += new System.EventHandler(this.btn_row_5_Click);
            this.btn_row_5.MouseEnter += new System.EventHandler(this.btn_row_5_MouseEnter);
            this.btn_row_5.MouseLeave += new System.EventHandler(this.btn_row_5_MouseLeave);
            // 
            // btn_row_6
            // 
            this.btn_row_6.BackColor = System.Drawing.Color.LightGray;
            this.btn_row_6.FlatAppearance.BorderSize = 0;
            this.btn_row_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_row_6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_6.Location = new System.Drawing.Point(498, 44);
            this.btn_row_6.Margin = new System.Windows.Forms.Padding(0);
            this.btn_row_6.Name = "btn_row_6";
            this.btn_row_6.Size = new System.Drawing.Size(75, 30);
            this.btn_row_6.TabIndex = 69;
            this.btn_row_6.Text = "⬇";
            this.btn_row_6.UseVisualStyleBackColor = false;
            this.btn_row_6.Click += new System.EventHandler(this.btn_row_6_Click);
            this.btn_row_6.MouseEnter += new System.EventHandler(this.btn_row_6_MouseEnter);
            this.btn_row_6.MouseLeave += new System.EventHandler(this.btn_row_6_MouseLeave);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 647);
            this.Controls.Add(this.btn_row_6);
            this.Controls.Add(this.btn_row_5);
            this.Controls.Add(this.btn_row_4);
            this.Controls.Add(this.btn_row_3);
            this.Controls.Add(this.btn_row_2);
            this.Controls.Add(this.btn_row_1);
            this.Controls.Add(this.btn_row_0);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gameFlowBox);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerTwoColor);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.playerOneColor);
            this.Controls.Add(this.turnLine);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turnLine;
        private System.Windows.Forms.Button playerOneColor;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Button playerTwoColor;
        private System.Windows.Forms.FlowLayoutPanel gameFlowBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_row_0;
        private System.Windows.Forms.Button btn_row_1;
        private System.Windows.Forms.Button btn_row_2;
        private System.Windows.Forms.Button btn_row_4;
        private System.Windows.Forms.Button btn_row_3;
        private System.Windows.Forms.Button btn_row_5;
        private System.Windows.Forms.Button btn_row_6;
    }
}