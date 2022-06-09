namespace dbs_lab_project
{
    partial class access
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
            this.tables = new System.Windows.Forms.ComboBox();
            this.enter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(33, 12);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(121, 28);
            this.tables.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(233, 34);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 34);
            this.enter.TabIndex = 1;
            this.enter.Text = "enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(873, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // filter
            // 
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(33, 69);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(121, 28);
            this.filter.TabIndex = 3;
            // 
            // access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 491);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.tables);
            this.Name = "access";
            this.Text = "access";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filter;
    }
}