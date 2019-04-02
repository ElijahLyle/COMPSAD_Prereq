namespace COMPSAD_CPE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.add_btn = new System.Windows.Forms.Button();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.cur_view = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wterm_dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wterm_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Transparent;
            this.add_btn.Location = new System.Drawing.Point(12, 65);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(155, 23);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "+ Add New Curriculum";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Location = new System.Drawing.Point(13, 13);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(128, 20);
            this.admin_lbl.TabIndex = 1;
            this.admin_lbl.Text = "Admin <name>";
            // 
            // cur_view
            // 
            this.cur_view.FormattingEnabled = true;
            this.cur_view.Location = new System.Drawing.Point(12, 104);
            this.cur_view.Name = "cur_view";
            this.cur_view.Size = new System.Drawing.Size(155, 21);
            this.cur_view.TabIndex = 2;
            this.cur_view.SelectedIndexChanged += new System.EventHandler(this.cur_view_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wterm_dgv);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 301);
            this.panel1.TabIndex = 4;
            // 
            // wterm_dgv
            // 
            this.wterm_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wterm_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wterm_dgv.Location = new System.Drawing.Point(0, 0);
            this.wterm_dgv.Name = "wterm_dgv";
            this.wterm_dgv.Size = new System.Drawing.Size(906, 301);
            this.wterm_dgv.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cur_view);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.add_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Prerequisite Checker: CPE";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wterm_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label admin_lbl;
        private System.Windows.Forms.ComboBox cur_view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView wterm_dgv;
    }
}