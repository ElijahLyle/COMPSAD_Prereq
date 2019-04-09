namespace COMPSAD_CPE
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.id_lbl = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.left_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.terms_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.view_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.id_lbl.Location = new System.Drawing.Point(13, 13);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(165, 20);
            this.id_lbl.TabIndex = 0;
            this.id_lbl.Text = "Curriculum for <ID>";
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 151);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(454, 295);
            this.dgv.TabIndex = 1;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // left_btn
            // 
            this.left_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_btn.BackgroundImage")));
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.ForeColor = System.Drawing.Color.Transparent;
            this.left_btn.Location = new System.Drawing.Point(127, 69);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(36, 27);
            this.left_btn.TabIndex = 2;
            this.left_btn.Text = "<";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_btn.BackgroundImage")));
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.ForeColor = System.Drawing.Color.Transparent;
            this.right_btn.Location = new System.Drawing.Point(298, 69);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(36, 27);
            this.right_btn.TabIndex = 3;
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
            this.terms_lbl.Location = new System.Drawing.Point(188, 71);
            this.terms_lbl.Name = "terms_lbl";
            this.terms_lbl.Size = new System.Drawing.Size(84, 20);
            this.terms_lbl.TabIndex = 4;
            this.terms_lbl.Text = "Term <n>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note: For prerequisites and loads, follow the format sample OSYSLEC/COMPSAD and H" +
    "/S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note: Write NULL if there are no prerequisistes to a course.";
            // 
            // done_btn
            // 
            this.done_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("done_btn.BackgroundImage")));
            this.done_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_btn.ForeColor = System.Drawing.Color.Transparent;
            this.done_btn.Location = new System.Drawing.Point(78, 452);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(52, 27);
            this.done_btn.TabIndex = 7;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Note: Complete the list per term first before proceeding to the next.";
            // 
            // view_btn
            // 
            this.view_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_btn.BackgroundImage")));
            this.view_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_btn.ForeColor = System.Drawing.Color.Transparent;
            this.view_btn.Location = new System.Drawing.Point(17, 452);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(52, 27);
            this.view_btn.TabIndex = 9;
            this.view_btn.Text = "View";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 486);
            this.Controls.Add(this.view_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.terms_lbl);
            this.Controls.Add(this.right_btn);
            this.Controls.Add(this.left_btn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.id_lbl);
            this.Name = "Form5";
            this.Text = "Prerequisite Checker: CPE";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Label terms_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button view_btn;
    }
}