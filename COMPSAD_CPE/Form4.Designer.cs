namespace COMPSAD_CPE
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.id_lbl = new System.Windows.Forms.Label();
            this.basis_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.left_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.term_lbl = new System.Windows.Forms.Label();
            this.cur_dgv = new System.Windows.Forms.DataGridView();
            this.confirm_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cur_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.id_lbl.Location = new System.Drawing.Point(13, 13);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(105, 18);
            this.id_lbl.TabIndex = 0;
            this.id_lbl.Text = "ID <number>";
            // 
            // basis_lbl
            // 
            this.basis_lbl.AutoSize = true;
            this.basis_lbl.BackColor = System.Drawing.Color.Transparent;
            this.basis_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basis_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.basis_lbl.Location = new System.Drawing.Point(195, 41);
            this.basis_lbl.Name = "basis_lbl";
            this.basis_lbl.Size = new System.Drawing.Size(64, 17);
            this.basis_lbl.TabIndex = 1;
            this.basis_lbl.Text = "<basis>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Curriculum based from:";
            // 
            // left_btn
            // 
            this.left_btn.BackColor = System.Drawing.Color.Transparent;
            this.left_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_btn.BackgroundImage")));
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.ForeColor = System.Drawing.Color.White;
            this.left_btn.Location = new System.Drawing.Point(59, 70);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(29, 25);
            this.left_btn.TabIndex = 3;
            this.left_btn.Text = "<";
            this.left_btn.UseVisualStyleBackColor = false;
            this.left_btn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // right_btn
            // 
            this.right_btn.BackColor = System.Drawing.Color.Transparent;
            this.right_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_btn.BackgroundImage")));
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.ForeColor = System.Drawing.Color.White;
            this.right_btn.Location = new System.Drawing.Point(185, 70);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(29, 25);
            this.right_btn.TabIndex = 4;
            this.right_btn.Text = ">";
            this.right_btn.UseVisualStyleBackColor = false;
            this.right_btn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // term_lbl
            // 
            this.term_lbl.AutoSize = true;
            this.term_lbl.BackColor = System.Drawing.Color.Transparent;
            this.term_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.term_lbl.Location = new System.Drawing.Point(102, 74);
            this.term_lbl.Name = "term_lbl";
            this.term_lbl.Size = new System.Drawing.Size(77, 17);
            this.term_lbl.TabIndex = 5;
            this.term_lbl.Text = "Term <n>";
            // 
            // cur_dgv
            // 
            this.cur_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cur_dgv.Location = new System.Drawing.Point(12, 104);
            this.cur_dgv.Name = "cur_dgv";
            this.cur_dgv.Size = new System.Drawing.Size(439, 256);
            this.cur_dgv.TabIndex = 6;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.Transparent;
            this.confirm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_btn.BackgroundImage")));
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.Color.White;
            this.confirm_btn.Location = new System.Drawing.Point(304, 70);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(72, 25);
            this.confirm_btn.TabIndex = 7;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(462, 372);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.cur_dgv);
            this.Controls.Add(this.term_lbl);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basis_lbl);
            this.Controls.Add(this.id_lbl);
            this.Name = "Form4";
            this.Text = "Prerequisite Checker: CPE";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cur_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label basis_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Label term_lbl;
        private System.Windows.Forms.DataGridView cur_dgv;
        private System.Windows.Forms.Button confirm_btn;
    }
}