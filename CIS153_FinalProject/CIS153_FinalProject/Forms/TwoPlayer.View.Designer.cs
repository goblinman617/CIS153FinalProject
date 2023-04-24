namespace CIS153_FinalProject.Forms
{
    partial class TwoPlayer
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
            this.label2 = new System.Windows.Forms.Label();
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerTwoName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btn_color_p1 = new System.Windows.Forms.Button();
            this.btn_color_p2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Enter your names below.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player #1\'s Name";
            // 
            // playerOneName
            // 
            this.playerOneName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerOneName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneName.Location = new System.Drawing.Point(19, 108);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(250, 22);
            this.playerOneName.TabIndex = 2;
            // 
            // playerTwoName
            // 
            this.playerTwoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerTwoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoName.Location = new System.Drawing.Point(19, 181);
            this.playerTwoName.Name = "playerTwoName";
            this.playerTwoName.Size = new System.Drawing.Size(250, 22);
            this.playerTwoName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player #2\'s Name";
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.readyButton.FlatAppearance.BorderSize = 0;
            this.readyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readyButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(19, 267);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(493, 52);
            this.readyButton.TabIndex = 5;
            this.readyButton.Text = "Read to Begin?";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(19, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(493, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "<- Go Back?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(16, 234);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(147, 17);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Error Label Placeholder";
            this.errorLabel.Visible = false;
            // 
            // btn_color_p1
            // 
            this.btn_color_p1.BackColor = System.Drawing.Color.Firebrick;
            this.btn_color_p1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color_p1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color_p1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_color_p1.Location = new System.Drawing.Point(275, 108);
            this.btn_color_p1.Name = "btn_color_p1";
            this.btn_color_p1.Size = new System.Drawing.Size(237, 22);
            this.btn_color_p1.TabIndex = 8;
            this.btn_color_p1.UseVisualStyleBackColor = false;
            this.btn_color_p1.Click += new System.EventHandler(this.btn_color_p1_Click);
            // 
            // btn_color_p2
            // 
            this.btn_color_p2.BackColor = System.Drawing.Color.Orange;
            this.btn_color_p2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color_p2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color_p2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_color_p2.Location = new System.Drawing.Point(275, 181);
            this.btn_color_p2.Name = "btn_color_p2";
            this.btn_color_p2.Size = new System.Drawing.Size(237, 22);
            this.btn_color_p2.TabIndex = 9;
            this.btn_color_p2.UseVisualStyleBackColor = false;
            this.btn_color_p2.Click += new System.EventHandler(this.btn_color_p2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Player #1\'s Color";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Player #2\'s Color";
            // 
            // TwoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_color_p2);
            this.Controls.Add(this.btn_color_p1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.playerTwoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerOneName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TwoPlayer";
            this.Text = "TwoPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.TextBox playerTwoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button btn_color_p1;
        private System.Windows.Forms.Button btn_color_p2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}