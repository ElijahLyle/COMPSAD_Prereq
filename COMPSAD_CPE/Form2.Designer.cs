namespace COMPSAD_CPE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.welcome_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.no_lbl = new System.Windows.Forms.Label();
            this.term_lbl = new System.Windows.Forms.Label();
            this.right_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.status_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.units_lbl = new System.Windows.Forms.Label();
            this.course_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_lbl
            // 
            this.welcome_lbl.AutoSize = true;
            this.welcome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.welcome_lbl.Location = new System.Drawing.Point(13, 13);
            this.welcome_lbl.Name = "welcome_lbl";
            this.welcome_lbl.Size = new System.Drawing.Size(107, 20);
            this.welcome_lbl.TabIndex = 0;
            this.welcome_lbl.Text = "Welcome, ...";
            this.welcome_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_btn
            // 
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.Transparent;
            this.back_btn.Location = new System.Drawing.Point(568, 10);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(101, 23);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back to Login";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(29, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 284);
            this.panel1.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.Location = new System.Drawing.Point(0, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(244, 278);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.no_lbl);
            this.panel2.Controls.Add(this.term_lbl);
            this.panel2.Controls.Add(this.right_btn);
            this.panel2.Controls.Add(this.left_btn);
            this.panel2.Location = new System.Drawing.Point(17, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 30);
            this.panel2.TabIndex = 3;
            // 
            // no_lbl
            // 
            this.no_lbl.AutoSize = true;
            this.no_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.no_lbl.Location = new System.Drawing.Point(161, 2);
            this.no_lbl.Name = "no_lbl";
            this.no_lbl.Size = new System.Drawing.Size(22, 24);
            this.no_lbl.TabIndex = 3;
            this.no_lbl.Text = "n";
            // 
            // term_lbl
            // 
            this.term_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.term_lbl.AutoSize = true;
            this.term_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.term_lbl.Location = new System.Drawing.Point(96, 2);
            this.term_lbl.Name = "term_lbl";
            this.term_lbl.Size = new System.Drawing.Size(59, 24);
            this.term_lbl.TabIndex = 2;
            this.term_lbl.Text = "Term";
            // 
            // right_btn
            // 
            this.right_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right_btn.BackgroundImage")));
            this.right_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right_btn.ForeColor = System.Drawing.Color.White;
            this.right_btn.Location = new System.Drawing.Point(189, 0);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(42, 30);
            this.right_btn.TabIndex = 1;
            this.right_btn.Text = ">";
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left_btn.BackgroundImage")));
            this.left_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left_btn.ForeColor = System.Drawing.Color.White;
            this.left_btn.Location = new System.Drawing.Point(48, 0);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(42, 30);
            this.left_btn.TabIndex = 0;
            this.left_btn.Text = "<";
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.name_lbl);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.status_lbl);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dgv2);
            this.panel3.Controls.Add(this.units_lbl);
            this.panel3.Controls.Add(this.course_lbl);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(303, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 274);
            this.panel3.TabIndex = 4;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.status_lbl.Location = new System.Drawing.Point(80, 90);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(81, 18);
            this.status_lbl.TabIndex = 8;
            this.status_lbl.Text = "status_txt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(0, 151);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(345, 123);
            this.dgv2.TabIndex = 6;
            // 
            // units_lbl
            // 
            this.units_lbl.AutoSize = true;
            this.units_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.units_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.units_lbl.Location = new System.Drawing.Point(80, 62);
            this.units_lbl.Name = "units_lbl";
            this.units_lbl.Size = new System.Drawing.Size(71, 18);
            this.units_lbl.TabIndex = 5;
            this.units_lbl.Text = "units_txt";
            // 
            // course_lbl
            // 
            this.course_lbl.AutoSize = true;
            this.course_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.course_lbl.Location = new System.Drawing.Point(79, 8);
            this.course_lbl.Name = "course_lbl";
            this.course_lbl.Size = new System.Drawing.Size(87, 18);
            this.course_lbl.TabIndex = 4;
            this.course_lbl.Text = "course_txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(4, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prerequisites:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Units:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course:";
            // 
            // search_txt
            // 
            this.search_txt.ForeColor = System.Drawing.Color.DimGray;
            this.search_txt.Location = new System.Drawing.Point(385, 70);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(171, 20);
            this.search_txt.TabIndex = 5;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(307, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search Course:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.name_lbl.Location = new System.Drawing.Point(80, 35);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(76, 18);
            this.name_lbl.TabIndex = 10;
            this.name_lbl.Text = "name_txt";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.welcome_lbl);
            this.Name = "Form2";
            this.Text = "Prerequisite Checker: CPE";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label term_lbl;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Label no_lbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label units_lbl;
        private System.Windows.Forms.Label course_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label6;
    }
}