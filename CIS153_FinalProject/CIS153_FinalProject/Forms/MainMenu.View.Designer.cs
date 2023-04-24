namespace CIS153_FinalProject {
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
            this.btn_open_stats = new System.Windows.Forms.Button();
            this.btn_single_player = new System.Windows.Forms.Button();
            this.btn_two_player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open_stats
            // 
            this.btn_open_stats.BackColor = System.Drawing.Color.LightGray;
            this.btn_open_stats.FlatAppearance.BorderSize = 4;
            this.btn_open_stats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_open_stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_stats.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_open_stats.Location = new System.Drawing.Point(609, 555);
            this.btn_open_stats.Name = "btn_open_stats";
            this.btn_open_stats.Size = new System.Drawing.Size(150, 100);
            this.btn_open_stats.TabIndex = 1;
            this.btn_open_stats.Text = "Open Stats";
            this.btn_open_stats.UseVisualStyleBackColor = false;
            this.btn_open_stats.Click += new System.EventHandler(this.btn_open_stats_Click);
            // 
            // btn_single_player
            // 
            this.btn_single_player.BackColor = System.Drawing.Color.LightGray;
            this.btn_single_player.FlatAppearance.BorderSize = 4;
            this.btn_single_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_single_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_single_player.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_single_player.Location = new System.Drawing.Point(37, 555);
            this.btn_single_player.Name = "btn_single_player";
            this.btn_single_player.Size = new System.Drawing.Size(150, 100);
            this.btn_single_player.TabIndex = 3;
            this.btn_single_player.Text = "Single Player";
            this.btn_single_player.UseVisualStyleBackColor = false;
            this.btn_single_player.Click += new System.EventHandler(this.btn_single_player_Click);
            // 
            // btn_two_player
            // 
            this.btn_two_player.BackColor = System.Drawing.Color.LightGray;
            this.btn_two_player.FlatAppearance.BorderSize = 4;
            this.btn_two_player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_two_player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two_player.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_two_player.Location = new System.Drawing.Point(241, 555);
            this.btn_two_player.Name = "btn_two_player";
            this.btn_two_player.Size = new System.Drawing.Size(150, 100);
            this.btn_two_player.TabIndex = 4;
            this.btn_two_player.Text = "Two Player";
            this.btn_two_player.UseVisualStyleBackColor = false;
            this.btn_two_player.Click += new System.EventHandler(this.btn_two_player_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CIS153_FinalProject.Properties.Resources.c4_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 708);
            this.Controls.Add(this.btn_two_player);
            this.Controls.Add(this.btn_single_player);
            this.Controls.Add(this.btn_open_stats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main_Menu";
            this.Text = "Connect 4";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_open_stats;
        private System.Windows.Forms.Button btn_single_player;
        private System.Windows.Forms.Button btn_two_player;
    }
}

