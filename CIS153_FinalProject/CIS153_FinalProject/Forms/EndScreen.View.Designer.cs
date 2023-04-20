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
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.txt_display_winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Location = new System.Drawing.Point(103, 326);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(198, 85);
            this.btn_MainMenu.TabIndex = 0;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            // 
            // txt_display_winner
            // 
            this.txt_display_winner.AutoSize = true;
            this.txt_display_winner.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_winner.Location = new System.Drawing.Point(345, 61);
            this.txt_display_winner.Name = "txt_display_winner";
            this.txt_display_winner.Size = new System.Drawing.Size(80, 45);
            this.txt_display_winner.TabIndex = 1;
            this.txt_display_winner.Text = "dog";
            this.txt_display_winner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_display_winner);
            this.Controls.Add(this.btn_MainMenu);
            this.Name = "EndScreen";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MainMenu;
        private System.Windows.Forms.Label txt_display_winner;
    }
}