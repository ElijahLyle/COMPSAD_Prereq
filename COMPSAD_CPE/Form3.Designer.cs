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
            this.admin_lbl = new System.Windows.Forms.Label();
            this.id_cbox = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.terms_lbl = new System.Windows.Forms.Label();
            this.select_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.use_lbl = new System.Windows.Forms.Label();
            this.yes_cbox = new System.Windows.Forms.CheckBox();
            this.no_cbox = new System.Windows.Forms.CheckBox();
            this.status_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Location = new System.Drawing.Point(13, 13);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(79, 20);
            this.admin_lbl.TabIndex = 0;
            this.admin_lbl.Text = "<Admin>";
            // 
            // id_cbox
            // 
            this.id_cbox.FormattingEnabled = true;
            this.id_cbox.Location = new System.Drawing.Point(17, 53);
            this.id_cbox.Name = "id_cbox";
            this.id_cbox.Size = new System.Drawing.Size(141, 21);
            this.id_cbox.TabIndex = 1;
            this.id_cbox.SelectedIndexChanged += new System.EventHandler(this.id_cbox_SekectedINdexChanged);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 144);
            this.dgv.Name = "dgv";
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv.Size = new System.Drawing.Size(623, 294);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            this.add_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_btn.BackgroundImage")));
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Transparent;
            this.add_btn.Location = new System.Drawing.Point(17, 81);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(141, 21);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "+ Add New Curriculum";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_btn.BackgroundImage")));
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.ForeColor = System.Drawing.Color.Transparent;
            this.left_btn.Location = new System.Drawing.Point(17, 109);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(28, 29);
            this.left_btn.TabIndex = 4;
            this.left_btn.Text = "<";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_btn.BackgroundImage")));
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.ForeColor = System.Drawing.Color.Transparent;
            this.right_btn.Location = new System.Drawing.Point(130, 108);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(28, 29);
            this.right_btn.TabIndex = 5;
            this.right_btn.Text = ">";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // terms_lbl
            // 
            this.terms_lbl.AutoSize = true;
            this.terms_lbl.BackColor = System.Drawing.Color.Transparent;
            this.terms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.terms_lbl.Location = new System.Drawing.Point(51, 112);
            this.terms_lbl.Name = "terms_lbl";
            this.terms_lbl.Size = new System.Drawing.Size(64, 20);
            this.terms_lbl.TabIndex = 6;
            this.terms_lbl.Text = "Term n";
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.BackColor = System.Drawing.Color.Transparent;
            this.select_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.select_lbl.Location = new System.Drawing.Point(164, 54);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(44, 18);
            this.select_lbl.TabIndex = 7;
            this.select_lbl.Text = "<ID>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(165, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Note: When changing parameters, please follow the format shown on the cells";
            // 
            // use_lbl
            // 
            this.use_lbl.AutoSize = true;
            this.use_lbl.BackColor = System.Drawing.Color.Transparent;
            this.use_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.use_lbl.Location = new System.Drawing.Point(164, 85);
            this.use_lbl.Name = "use_lbl";
            this.use_lbl.Size = new System.Drawing.Size(147, 13);
            this.use_lbl.TabIndex = 9;
            this.use_lbl.Text = "Use Existing Curriculum?";
            this.use_lbl.Visible = false;
            // 
            // yes_cbox
            // 
            this.yes_cbox.AutoSize = true;
            this.yes_cbox.BackColor = System.Drawing.Color.Transparent;
            this.yes_cbox.ForeColor = System.Drawing.Color.Transparent;
            this.yes_cbox.Location = new System.Drawing.Point(317, 84);
            this.yes_cbox.Name = "yes_cbox";
            this.yes_cbox.Size = new System.Drawing.Size(44, 17);
            this.yes_cbox.TabIndex = 10;
            this.yes_cbox.Text = "Yes";
            this.yes_cbox.UseVisualStyleBackColor = false;
            this.yes_cbox.Visible = false;
            this.yes_cbox.CheckedChanged += new System.EventHandler(this.ybox_CheckChanged);
            // 
            // no_cbox
            // 
            this.no_cbox.AutoSize = true;
            this.no_cbox.BackColor = System.Drawing.Color.Transparent;
            this.no_cbox.ForeColor = System.Drawing.Color.Transparent;
            this.no_cbox.Location = new System.Drawing.Point(367, 84);
            this.no_cbox.Name = "no_cbox";
            this.no_cbox.Size = new System.Drawing.Size(40, 17);
            this.no_cbox.TabIndex = 11;
            this.no_cbox.Text = "No";
            this.no_cbox.UseVisualStyleBackColor = false;
            this.no_cbox.Visible = false;
            this.no_cbox.CheckedChanged += new System.EventHandler(this.nbox_CheckChanged);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.status_lbl.Location = new System.Drawing.Point(413, 85);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(83, 13);
            this.status_lbl.TabIndex = 12;
            this.status_lbl.Text = "<Add Status>";
            this.status_lbl.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.no_cbox);
            this.Controls.Add(this.yes_cbox);
            this.Controls.Add(this.use_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_lbl);
            this.Controls.Add(this.terms_lbl);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.id_cbox);
            this.Controls.Add(this.admin_lbl);
            this.Name = "Form3";
            this.Text = "Prerequisite Checker: CPE";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_lbl;
        private System.Windows.Forms.ComboBox id_cbox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Label terms_lbl;
        private System.Windows.Forms.Label select_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label use_lbl;
        private System.Windows.Forms.CheckBox yes_cbox;
        private System.Windows.Forms.CheckBox no_cbox;
        private System.Windows.Forms.Label status_lbl;
    }
}