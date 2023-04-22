namespace CIS153_FinalProject.Forms {
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
            this.SuspendLayout();
            // 
            // txt_display_winner
            // 
            this.txt_display_winner.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_winner.Location = new System.Drawing.Point(12, 153);
            this.txt_display_winner.Name = "txt_display_winner";
            this.txt_display_winner.Size = new System.Drawing.Size(776, 45);
            this.txt_display_winner.TabIndex = 0;
            this.txt_display_winner.Text = "Somebody has won the game!";
            this.txt_display_winner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_main_menu
            // 
            this.btn_main_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_menu.Location = new System.Drawing.Point(167, 332);
            this.btn_main_menu.Name = "btn_main_menu";
            this.btn_main_menu.Size = new System.Drawing.Size(160, 71);
            this.btn_main_menu.TabIndex = 1;
            this.btn_main_menu.Text = "Main Menu";
            this.btn_main_menu.UseVisualStyleBackColor = true;
            this.btn_main_menu.Click += new System.EventHandler(this.btn_main_menu_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Location = new System.Drawing.Point(466, 332);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(160, 71);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Stats Page";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}