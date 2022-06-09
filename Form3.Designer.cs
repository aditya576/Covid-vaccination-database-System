namespace dbs_lab_project
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
            this.vaccination_details = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.access = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vaccination_details
            // 
            this.vaccination_details.Location = new System.Drawing.Point(244, 188);
            this.vaccination_details.Name = "vaccination_details";
            this.vaccination_details.Size = new System.Drawing.Size(264, 60);
            this.vaccination_details.TabIndex = 5;
            this.vaccination_details.Text = "ENTER VACCINATION DETAILS";
            this.vaccination_details.UseVisualStyleBackColor = true;
            this.vaccination_details.Click += new System.EventHandler(this.vaccination_details_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(172, 330);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(404, 49);
            this.update.TabIndex = 4;
            this.update.Text = "UPDATE YOUR EXISTING VACCINATION DETAILS";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // access
            // 
            this.access.Location = new System.Drawing.Point(260, 80);
            this.access.Name = "access";
            this.access.Size = new System.Drawing.Size(225, 60);
            this.access.TabIndex = 6;
            this.access.Text = "ARE YOU ADMIN?";
            this.access.UseVisualStyleBackColor = true;
            this.access.Click += new System.EventHandler(this.access_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.access);
            this.Controls.Add(this.vaccination_details);
            this.Controls.Add(this.update);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vaccination_details;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button access;
    }
}