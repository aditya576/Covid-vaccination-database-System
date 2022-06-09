namespace dbs_lab_project
{
    partial class Teacher_update
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
            this.infectedDate = new System.Windows.Forms.DateTimePicker();
            this.secondDate = new System.Windows.Forms.DateTimePicker();
            this.firstDate = new System.Windows.Forms.DateTimePicker();
            this.vaccines = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.vaccination_id = new System.Windows.Forms.TextBox();
            this.reg_no = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.TextBox();
            this.fully_vaccinated = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.partially_vaccinated = new System.Windows.Forms.RadioButton();
            this.not_vaccinated = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // infectedDate
            // 
            this.infectedDate.Location = new System.Drawing.Point(237, 377);
            this.infectedDate.Name = "infectedDate";
            this.infectedDate.Size = new System.Drawing.Size(200, 26);
            this.infectedDate.TabIndex = 112;
            // 
            // secondDate
            // 
            this.secondDate.Location = new System.Drawing.Point(142, 305);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(200, 26);
            this.secondDate.TabIndex = 111;
            // 
            // firstDate
            // 
            this.firstDate.Location = new System.Drawing.Point(116, 223);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(200, 26);
            this.firstDate.TabIndex = 110;
            // 
            // vaccines
            // 
            this.vaccines.FormattingEnabled = true;
            this.vaccines.Location = new System.Drawing.Point(128, 141);
            this.vaccines.Name = "vaccines";
            this.vaccines.Size = new System.Drawing.Size(149, 28);
            this.vaccines.TabIndex = 109;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(471, 445);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 41);
            this.submit.TabIndex = 108;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "if tested positive then last date?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "second_vacc date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 105;
            this.label7.Text = "first_vacc date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "name of vaccine";
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(518, -24);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(58, 24);
            this.yes.TabIndex = 101;
            this.yes.TabStop = true;
            this.yes.Text = "yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "vacc_id";
            // 
            // vaccination_id
            // 
            this.vaccination_id.Location = new System.Drawing.Point(99, 74);
            this.vaccination_id.Multiline = true;
            this.vaccination_id.Name = "vaccination_id";
            this.vaccination_id.Size = new System.Drawing.Size(188, 29);
            this.vaccination_id.TabIndex = 99;
            // 
            // reg_no
            // 
            this.reg_no.AutoSize = true;
            this.reg_no.Location = new System.Drawing.Point(21, 16);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(76, 20);
            this.reg_no.TabIndex = 92;
            this.reg_no.Text = "faculty_id";
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(99, 13);
            this.reg.Multiline = true;
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(188, 32);
            this.reg.TabIndex = 88;
            // 
            // fully_vaccinated
            // 
            this.fully_vaccinated.AutoSize = true;
            this.fully_vaccinated.Location = new System.Drawing.Point(617, 345);
            this.fully_vaccinated.Name = "fully_vaccinated";
            this.fully_vaccinated.Size = new System.Drawing.Size(146, 24);
            this.fully_vaccinated.TabIndex = 116;
            this.fully_vaccinated.TabStop = true;
            this.fully_vaccinated.Text = "fully_vaccinated";
            this.fully_vaccinated.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(621, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "vacc_status";
            // 
            // partially_vaccinated
            // 
            this.partially_vaccinated.AutoSize = true;
            this.partially_vaccinated.Location = new System.Drawing.Point(617, 278);
            this.partially_vaccinated.Name = "partially_vaccinated";
            this.partially_vaccinated.Size = new System.Drawing.Size(172, 24);
            this.partially_vaccinated.TabIndex = 114;
            this.partially_vaccinated.TabStop = true;
            this.partially_vaccinated.Text = "partially_vaccinated";
            this.partially_vaccinated.UseVisualStyleBackColor = true;
            // 
            // not_vaccinated
            // 
            this.not_vaccinated.AutoSize = true;
            this.not_vaccinated.Location = new System.Drawing.Point(617, 220);
            this.not_vaccinated.Name = "not_vaccinated";
            this.not_vaccinated.Size = new System.Drawing.Size(142, 24);
            this.not_vaccinated.TabIndex = 113;
            this.not_vaccinated.TabStop = true;
            this.not_vaccinated.Text = "not_vaccinated";
            this.not_vaccinated.UseVisualStyleBackColor = true;
            // 
            // Teacher_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 519);
            this.Controls.Add(this.fully_vaccinated);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partially_vaccinated);
            this.Controls.Add(this.not_vaccinated);
            this.Controls.Add(this.infectedDate);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.vaccines);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vaccination_id);
            this.Controls.Add(this.reg_no);
            this.Controls.Add(this.reg);
            this.Name = "Teacher_update";
            this.Text = "Teacher_update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker infectedDate;
        private System.Windows.Forms.DateTimePicker secondDate;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.ComboBox vaccines;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vaccination_id;
        private System.Windows.Forms.Label reg_no;
        private System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.RadioButton fully_vaccinated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton partially_vaccinated;
        private System.Windows.Forms.RadioButton not_vaccinated;
    }
}