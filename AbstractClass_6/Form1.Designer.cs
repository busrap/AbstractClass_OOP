namespace AbstractClass_6
{
    partial class Form1
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
            this.btnKemanCal = new System.Windows.Forms.Button();
            this.btnBateriCal = new System.Windows.Forms.Button();
            this.btnGitarCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKemanCal
            // 
            this.btnKemanCal.Location = new System.Drawing.Point(27, 33);
            this.btnKemanCal.Name = "btnKemanCal";
            this.btnKemanCal.Size = new System.Drawing.Size(165, 38);
            this.btnKemanCal.TabIndex = 0;
            this.btnKemanCal.Text = "Keman çal";
            this.btnKemanCal.UseVisualStyleBackColor = true;
            this.btnKemanCal.Click += new System.EventHandler(this.btnKemanCal_Click);
            // 
            // btnBateriCal
            // 
            this.btnBateriCal.Location = new System.Drawing.Point(27, 105);
            this.btnBateriCal.Name = "btnBateriCal";
            this.btnBateriCal.Size = new System.Drawing.Size(165, 38);
            this.btnBateriCal.TabIndex = 1;
            this.btnBateriCal.Text = "Bateri çal";
            this.btnBateriCal.UseVisualStyleBackColor = true;
            this.btnBateriCal.Click += new System.EventHandler(this.btnBateriCal_Click);
            // 
            // btnGitarCal
            // 
            this.btnGitarCal.Location = new System.Drawing.Point(27, 182);
            this.btnGitarCal.Name = "btnGitarCal";
            this.btnGitarCal.Size = new System.Drawing.Size(165, 38);
            this.btnGitarCal.TabIndex = 2;
            this.btnGitarCal.Text = "Gitar çal";
            this.btnGitarCal.UseVisualStyleBackColor = true;
            this.btnGitarCal.Click += new System.EventHandler(this.btnGitarCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 337);
            this.Controls.Add(this.btnGitarCal);
            this.Controls.Add(this.btnBateriCal);
            this.Controls.Add(this.btnKemanCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKemanCal;
        private System.Windows.Forms.Button btnBateriCal;
        private System.Windows.Forms.Button btnGitarCal;
    }
}

