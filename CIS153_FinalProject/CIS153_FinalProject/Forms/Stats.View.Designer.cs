namespace CIS153_FinalProject {
    partial class Stats {
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
            this.txt_total_games = new System.Windows.Forms.Label();
            this.txt_player_win_p = new System.Windows.Forms.Label();
            this.txt_ai_win_p = new System.Windows.Forms.Label();
            this.txt_draw_p = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_total_games
            // 
            this.txt_total_games.AutoSize = true;
            this.txt_total_games.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_games.Location = new System.Drawing.Point(15, 64);
            this.txt_total_games.Name = "txt_total_games";
            this.txt_total_games.Size = new System.Drawing.Size(413, 21);
            this.txt_total_games.TabIndex = 5;
            this.txt_total_games.Text = "You have played a total of 12 games, gota keep playing!";
            // 
            // txt_player_win_p
            // 
            this.txt_player_win_p.AutoSize = true;
            this.txt_player_win_p.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_player_win_p.Location = new System.Drawing.Point(15, 88);
            this.txt_player_win_p.Name = "txt_player_win_p";
            this.txt_player_win_p.Size = new System.Drawing.Size(67, 21);
            this.txt_player_win_p.TabIndex = 8;
            this.txt_player_win_p.Text = "XX.XX%";
            // 
            // txt_ai_win_p
            // 
            this.txt_ai_win_p.AutoSize = true;
            this.txt_ai_win_p.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ai_win_p.Location = new System.Drawing.Point(15, 112);
            this.txt_ai_win_p.Name = "txt_ai_win_p";
            this.txt_ai_win_p.Size = new System.Drawing.Size(67, 21);
            this.txt_ai_win_p.TabIndex = 9;
            this.txt_ai_win_p.Text = "XX.XX%";
            // 
            // txt_draw_p
            // 
            this.txt_draw_p.AutoSize = true;
            this.txt_draw_p.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_draw_p.Location = new System.Drawing.Point(15, 136);
            this.txt_draw_p.Name = "txt_draw_p";
            this.txt_draw_p.Size = new System.Drawing.Size(67, 21);
            this.txt_draw_p.TabIndex = 10;
            this.txt_draw_p.Text = "XX.XX%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Connect 4 Stats";
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.readyButton.FlatAppearance.BorderSize = 0;
            this.readyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(19, 196);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(446, 52);
            this.readyButton.TabIndex = 13;
            this.readyButton.Text = "Back to Main Menu";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.btn_to_menu_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 279);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_draw_p);
            this.Controls.Add(this.txt_ai_win_p);
            this.Controls.Add(this.txt_player_win_p);
            this.Controls.Add(this.txt_total_games);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_total_games;
        private System.Windows.Forms.Label txt_player_win_p;
        private System.Windows.Forms.Label txt_ai_win_p;
        private System.Windows.Forms.Label txt_draw_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button readyButton;
    }
}