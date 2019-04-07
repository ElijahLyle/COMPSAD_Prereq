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
            this.newid_lbl = new System.Windows.Forms.Label();
            this.terms_lbl = new System.Windows.Forms.Label();
            this.terms_tb = new System.Windows.Forms.TextBox();
            this.exist_lbl = new System.Windows.Forms.Label();
            this.y_cbox = new System.Windows.Forms.CheckBox();
            this.n_cbox = new System.Windows.Forms.CheckBox();
            this.basisid_lbl = new System.Windows.Forms.Label();
            this.proceed_btn = new System.Windows.Forms.Button();
            this.basis_cb = new System.Windows.Forms.ComboBox();
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
            // newid_lbl
            // 
            this.newid_lbl.AutoSize = true;
            this.newid_lbl.BackColor = System.Drawing.Color.Transparent;
            this.newid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newid_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.newid_lbl.Location = new System.Drawing.Point(182, 68);
            this.newid_lbl.Name = "newid_lbl";
            this.newid_lbl.Size = new System.Drawing.Size(79, 17);
            this.newid_lbl.TabIndex = 5;
            this.newid_lbl.Text = "ID <Add>:";
            this.newid_lbl.Visible = false;
            // 
            // terms_lbl
            // 
            this.terms_lbl.AutoSize = true;
            this.terms_lbl.BackColor = System.Drawing.Color.Transparent;
            this.terms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.terms_lbl.Location = new System.Drawing.Point(267, 68);
            this.terms_lbl.Name = "terms_lbl";
            this.terms_lbl.Size = new System.Drawing.Size(172, 17);
            this.terms_lbl.TabIndex = 6;
            this.terms_lbl.Text = "Set Number of Terms: ";
            this.terms_lbl.Visible = false;
            // 
            // terms_tb
            // 
            this.terms_tb.Location = new System.Drawing.Point(445, 67);
            this.terms_tb.Name = "terms_tb";
            this.terms_tb.Size = new System.Drawing.Size(100, 20);
            this.terms_tb.TabIndex = 7;
            this.terms_tb.Visible = false;
            // 
            // exist_lbl
            // 
            this.exist_lbl.AutoSize = true;
            this.exist_lbl.BackColor = System.Drawing.Color.Transparent;
            this.exist_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exist_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.exist_lbl.Location = new System.Drawing.Point(182, 105);
            this.exist_lbl.Name = "exist_lbl";
            this.exist_lbl.Size = new System.Drawing.Size(188, 17);
            this.exist_lbl.TabIndex = 8;
            this.exist_lbl.Text = "Use Existing Curriculum?";
            this.exist_lbl.Visible = false;
            // 
            // y_cbox
            // 
            this.y_cbox.AutoSize = true;
            this.y_cbox.BackColor = System.Drawing.Color.Transparent;
            this.y_cbox.ForeColor = System.Drawing.Color.Transparent;
            this.y_cbox.Location = new System.Drawing.Point(390, 107);
            this.y_cbox.Name = "y_cbox";
            this.y_cbox.Size = new System.Drawing.Size(47, 17);
            this.y_cbox.TabIndex = 9;
            this.y_cbox.Text = "Yes";
            this.y_cbox.UseVisualStyleBackColor = false;
            this.y_cbox.Visible = false;
            this.y_cbox.CheckedChanged += new System.EventHandler(this.ybox_CheckedChanged);
            // 
            // n_cbox
            // 
            this.n_cbox.AutoSize = true;
            this.n_cbox.BackColor = System.Drawing.Color.Transparent;
            this.n_cbox.ForeColor = System.Drawing.Color.Transparent;
            this.n_cbox.Location = new System.Drawing.Point(445, 108);
            this.n_cbox.Name = "n_cbox";
            this.n_cbox.Size = new System.Drawing.Size(42, 17);
            this.n_cbox.TabIndex = 10;
            this.n_cbox.Text = "No";
            this.n_cbox.UseVisualStyleBackColor = false;
            this.n_cbox.Visible = false;
            this.n_cbox.CheckedChanged += new System.EventHandler(this.nbox_CheckedChanged);
            // 
            // basisid_lbl
            // 
            this.basisid_lbl.AutoSize = true;
            this.basisid_lbl.BackColor = System.Drawing.Color.Transparent;
            this.basisid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basisid_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.basisid_lbl.Location = new System.Drawing.Point(283, 68);
            this.basisid_lbl.Name = "basisid_lbl";
            this.basisid_lbl.Size = new System.Drawing.Size(138, 17);
            this.basisid_lbl.TabIndex = 11;
            this.basisid_lbl.Text = "Basis ID Number: ";
            this.basisid_lbl.Visible = false;
            // 
            // proceed_btn
            // 
            this.proceed_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proceed_btn.BackgroundImage")));
            this.proceed_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_btn.ForeColor = System.Drawing.Color.Transparent;
            this.proceed_btn.Location = new System.Drawing.Point(577, 65);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(155, 23);
            this.proceed_btn.TabIndex = 13;
            this.proceed_btn.Text = "Proceed with Settings: ";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Visible = false;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // basis_cb
            // 
            this.basis_cb.FormattingEnabled = true;
            this.basis_cb.Location = new System.Drawing.Point(416, 67);
            this.basis_cb.Name = "basis_cb";
            this.basis_cb.Size = new System.Drawing.Size(155, 21);
            this.basis_cb.TabIndex = 14;
            this.basis_cb.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.basis_cb);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.basisid_lbl);
            this.Controls.Add(this.n_cbox);
            this.Controls.Add(this.y_cbox);
            this.Controls.Add(this.exist_lbl);
            this.Controls.Add(this.terms_tb);
            this.Controls.Add(this.terms_lbl);
            this.Controls.Add(this.newid_lbl);
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
        private System.Windows.Forms.Label newid_lbl;
        private System.Windows.Forms.Label terms_lbl;
        private System.Windows.Forms.TextBox terms_tb;
        private System.Windows.Forms.Label exist_lbl;
        private System.Windows.Forms.CheckBox y_cbox;
        private System.Windows.Forms.CheckBox n_cbox;
        private System.Windows.Forms.Label basisid_lbl;
        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.ComboBox basis_cb;
    }
}