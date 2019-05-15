namespace Streammoped
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_player1_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.tbx_player1_score = new System.Windows.Forms.TextBox();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.tbx_player2_name = new System.Windows.Forms.TextBox();
            this.tbx_player2_score = new System.Windows.Forms.TextBox();
            this.btn_refresh_txt = new System.Windows.Forms.Button();
            this.btn_clear_score = new System.Windows.Forms.Button();
            this.score2_plus = new System.Windows.Forms.Button();
            this.score2_minus = new System.Windows.Forms.Button();
            this.score1_plus = new System.Windows.Forms.Button();
            this.score1_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // tbx_player1_name
            // 
            this.tbx_player1_name.Location = new System.Drawing.Point(88, 71);
            this.tbx_player1_name.Name = "tbx_player1_name";
            this.tbx_player1_name.Size = new System.Drawing.Size(137, 20);
            this.tbx_player1_name.TabIndex = 1;
            this.tbx_player1_name.TextChanged += new System.EventHandler(this.tbx_player1_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(5, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 21);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "NAME";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_points.Location = new System.Drawing.Point(5, 138);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(53, 21);
            this.lbl_points.TabIndex = 3;
            this.lbl_points.Text = "Score";
            // 
            // tbx_player1_score
            // 
            this.tbx_player1_score.Location = new System.Drawing.Point(88, 142);
            this.tbx_player1_score.Name = "tbx_player1_score";
            this.tbx_player1_score.Size = new System.Drawing.Size(78, 20);
            this.tbx_player1_score.TabIndex = 4;
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2.Location = new System.Drawing.Point(406, 23);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(82, 22);
            this.lbl_player2.TabIndex = 5;
            this.lbl_player2.Text = "Player 2";
            // 
            // tbx_player2_name
            // 
            this.tbx_player2_name.Location = new System.Drawing.Point(377, 71);
            this.tbx_player2_name.Name = "tbx_player2_name";
            this.tbx_player2_name.Size = new System.Drawing.Size(137, 20);
            this.tbx_player2_name.TabIndex = 6;
            // 
            // tbx_player2_score
            // 
            this.tbx_player2_score.Location = new System.Drawing.Point(377, 142);
            this.tbx_player2_score.Name = "tbx_player2_score";
            this.tbx_player2_score.Size = new System.Drawing.Size(83, 20);
            this.tbx_player2_score.TabIndex = 7;
            // 
            // btn_refresh_txt
            // 
            this.btn_refresh_txt.Location = new System.Drawing.Point(71, 192);
            this.btn_refresh_txt.Name = "btn_refresh_txt";
            this.btn_refresh_txt.Size = new System.Drawing.Size(171, 40);
            this.btn_refresh_txt.TabIndex = 8;
            this.btn_refresh_txt.Text = "Refresh textfiles";
            this.btn_refresh_txt.UseVisualStyleBackColor = true;
            this.btn_refresh_txt.Click += new System.EventHandler(this.btn_refresh_txt_Click);
            // 
            // btn_clear_score
            // 
            this.btn_clear_score.Location = new System.Drawing.Point(395, 203);
            this.btn_clear_score.Name = "btn_clear_score";
            this.btn_clear_score.Size = new System.Drawing.Size(103, 28);
            this.btn_clear_score.TabIndex = 9;
            this.btn_clear_score.Text = "Clear Score";
            this.btn_clear_score.UseVisualStyleBackColor = true;
            this.btn_clear_score.Click += new System.EventHandler(this.btn_clear_score_Click);
            // 
            // score2_plus
            // 
            this.score2_plus.Location = new System.Drawing.Point(466, 139);
            this.score2_plus.Name = "score2_plus";
            this.score2_plus.Size = new System.Drawing.Size(21, 23);
            this.score2_plus.TabIndex = 10;
            this.score2_plus.Text = "+";
            this.score2_plus.UseVisualStyleBackColor = true;
            this.score2_plus.Click += new System.EventHandler(this.score2_plus_Click);
            // 
            // score2_minus
            // 
            this.score2_minus.Location = new System.Drawing.Point(493, 139);
            this.score2_minus.Name = "score2_minus";
            this.score2_minus.Size = new System.Drawing.Size(21, 23);
            this.score2_minus.TabIndex = 11;
            this.score2_minus.Text = "-";
            this.score2_minus.UseVisualStyleBackColor = true;
            this.score2_minus.Click += new System.EventHandler(this.score2_minus_Click);
            // 
            // score1_plus
            // 
            this.score1_plus.Location = new System.Drawing.Point(174, 140);
            this.score1_plus.Name = "score1_plus";
            this.score1_plus.Size = new System.Drawing.Size(21, 23);
            this.score1_plus.TabIndex = 12;
            this.score1_plus.Text = "+";
            this.score1_plus.UseVisualStyleBackColor = true;
            this.score1_plus.Click += new System.EventHandler(this.score1_plus_Click);
            // 
            // score1_minus
            // 
            this.score1_minus.Location = new System.Drawing.Point(201, 140);
            this.score1_minus.Name = "score1_minus";
            this.score1_minus.Size = new System.Drawing.Size(21, 23);
            this.score1_minus.TabIndex = 13;
            this.score1_minus.Text = "-";
            this.score1_minus.UseVisualStyleBackColor = true;
            this.score1_minus.Click += new System.EventHandler(this.score1_minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 253);
            this.Controls.Add(this.score1_minus);
            this.Controls.Add(this.score1_plus);
            this.Controls.Add(this.score2_minus);
            this.Controls.Add(this.score2_plus);
            this.Controls.Add(this.btn_clear_score);
            this.Controls.Add(this.btn_refresh_txt);
            this.Controls.Add(this.tbx_player2_score);
            this.Controls.Add(this.tbx_player2_name);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.tbx_player1_score);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tbx_player1_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StreamAssist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_player1_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.TextBox tbx_player1_score;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.TextBox tbx_player2_name;
        private System.Windows.Forms.TextBox tbx_player2_score;
        private System.Windows.Forms.Button btn_refresh_txt;
        private System.Windows.Forms.Button btn_clear_score;
        private System.Windows.Forms.Button score2_plus;
        private System.Windows.Forms.Button score2_minus;
        private System.Windows.Forms.Button score1_plus;
        private System.Windows.Forms.Button score1_minus;
    }
}

