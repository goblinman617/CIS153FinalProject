﻿namespace CIS153_FinalProject.Forms {
    partial class EndScreen {
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
            this.txt_display_winner = new System.Windows.Forms.Label();
            this.btn_main_menu = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.playAgain = new System.Windows.Forms.Button();
            this.btn_review_game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_display_winner
            // 
            this.txt_display_winner.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_winner.Location = new System.Drawing.Point(12, 9);
            this.txt_display_winner.Name = "txt_display_winner";
            this.txt_display_winner.Size = new System.Drawing.Size(776, 45);
            this.txt_display_winner.TabIndex = 0;
            this.txt_display_winner.Text = "Somebody has won the game!";
            this.txt_display_winner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_main_menu
            // 
            this.btn_main_menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_main_menu.FlatAppearance.BorderSize = 0;
            this.btn_main_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_menu.ForeColor = System.Drawing.Color.White;
            this.btn_main_menu.Location = new System.Drawing.Point(197, 259);
            this.btn_main_menu.Name = "btn_main_menu";
            this.btn_main_menu.Size = new System.Drawing.Size(399, 47);
            this.btn_main_menu.TabIndex = 1;
            this.btn_main_menu.Text = "Main Menu";
            this.btn_main_menu.UseVisualStyleBackColor = false;
            this.btn_main_menu.Click += new System.EventHandler(this.btn_main_menu_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_stats.FlatAppearance.BorderSize = 0;
            this.btn_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.ForeColor = System.Drawing.Color.White;
            this.btn_stats.Location = new System.Drawing.Point(197, 203);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(399, 47);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Stats Page";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.Color.DodgerBlue;
            this.playAgain.FlatAppearance.BorderSize = 0;
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.ForeColor = System.Drawing.Color.White;
            this.playAgain.Location = new System.Drawing.Point(197, 91);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(399, 47);
            this.playAgain.TabIndex = 3;
            this.playAgain.Text = "Play Again!";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_review_game
            // 
            this.btn_review_game.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_review_game.FlatAppearance.BorderSize = 0;
            this.btn_review_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_review_game.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review_game.ForeColor = System.Drawing.Color.White;
            this.btn_review_game.Location = new System.Drawing.Point(197, 147);
            this.btn_review_game.Name = "btn_review_game";
            this.btn_review_game.Size = new System.Drawing.Size(399, 47);
            this.btn_review_game.TabIndex = 4;
            this.btn_review_game.Text = "Review Game";
            this.btn_review_game.UseVisualStyleBackColor = false;
            this.btn_review_game.Click += new System.EventHandler(this.btn_review_game_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btn_review_game);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_main_menu);
            this.Controls.Add(this.txt_display_winner);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_display_winner;
        private System.Windows.Forms.Button btn_main_menu;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button btn_review_game;
    }
}