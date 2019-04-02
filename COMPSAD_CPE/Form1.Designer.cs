namespace COMPSAD_CPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.log_btn = new System.Windows.Forms.Button();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pword_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.Gray;
            this.log_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log_btn.BackgroundImage")));
            this.log_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.log_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.log_btn.FlatAppearance.BorderSize = 10;
            this.log_btn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(72, 197);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(182, 59);
            this.log_btn.TabIndex = 0;
            this.log_btn.Text = "LOGIN";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // user_txt
            // 
            this.user_txt.BackColor = System.Drawing.Color.White;
            this.user_txt.Location = new System.Drawing.Point(72, 75);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(182, 20);
            this.user_txt.TabIndex = 1;
            // 
            // pword_txt
            // 
            this.pword_txt.BackColor = System.Drawing.Color.White;
            this.pword_txt.Location = new System.Drawing.Point(72, 129);
            this.pword_txt.Name = "pword_txt";
            this.pword_txt.Size = new System.Drawing.Size(182, 20);
            this.pword_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(321, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pword_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.log_btn);
            this.Name = "Form1";
            this.Text = "Prerequisite Checker: CPE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pword_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

