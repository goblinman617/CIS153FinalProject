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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_single_player = new System.Windows.Forms.Button();
            this.btn_two_player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_open_stats
            // 
            this.btn_open_stats.Location = new System.Drawing.Point(596, 325);
            this.btn_open_stats.Name = "btn_open_stats";
            this.btn_open_stats.Size = new System.Drawing.Size(149, 84);
            this.btn_open_stats.TabIndex = 1;
            this.btn_open_stats.Text = "Open Stats";
            this.btn_open_stats.UseVisualStyleBackColor = true;
            this.btn_open_stats.Click += new System.EventHandler(this.btn_open_stats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect 4";
            // 
            // btn_single_player
            // 
            this.btn_single_player.Location = new System.Drawing.Point(95, 325);
            this.btn_single_player.Name = "btn_single_player";
            this.btn_single_player.Size = new System.Drawing.Size(149, 84);
            this.btn_single_player.TabIndex = 3;
            this.btn_single_player.Text = "Single Player";
            this.btn_single_player.UseVisualStyleBackColor = true;
            this.btn_single_player.Click += new System.EventHandler(this.btn_single_player_Click);
            // 
            // btn_two_player
            // 
            this.btn_two_player.Location = new System.Drawing.Point(343, 325);
            this.btn_two_player.Name = "btn_two_player";
            this.btn_two_player.Size = new System.Drawing.Size(149, 84);
            this.btn_two_player.TabIndex = 4;
            this.btn_two_player.Text = "Two Player";
            this.btn_two_player.UseVisualStyleBackColor = true;
            this.btn_two_player.Click += new System.EventHandler(this.btn_two_player_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_two_player);
            this.Controls.Add(this.btn_single_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open_stats);
            this.Name = "Main_Menu";
            this.Text = "Connect 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_open_stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_single_player;
        private System.Windows.Forms.Button btn_two_player;
    }
}

