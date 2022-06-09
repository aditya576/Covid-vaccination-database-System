namespace dbs_lab_project
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
            this.update = new System.Windows.Forms.Button();
            this.vaccination_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(205, 249);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(392, 68);
            this.update.TabIndex = 2;
            this.update.Text = "UPDATE YOUR EXISTING VACCINATION DETAILS";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // vaccination_details
            // 
            this.vaccination_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccination_details.Location = new System.Drawing.Point(205, 128);
            this.vaccination_details.Name = "vaccination_details";
            this.vaccination_details.Size = new System.Drawing.Size(392, 60);
            this.vaccination_details.TabIndex = 3;
            this.vaccination_details.Text = "ENTER VACCINATION DETAILS";
            this.vaccination_details.UseVisualStyleBackColor = true;
            this.vaccination_details.Click += new System.EventHandler(this.vaccination_details_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vaccination_details);
            this.Controls.Add(this.update);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button vaccination_details;
    }
}