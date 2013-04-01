namespace DegreePlanner
{
    partial class additionalInfo
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
            this.courseName = new System.Windows.Forms.Label();
            this.courseHours = new System.Windows.Forms.Label();
            this.courseDescription = new System.Windows.Forms.Label();
            this.coursePreReqs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(13, 13);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(35, 13);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "label1";
            // 
            // courseHours
            // 
            this.courseHours.AutoSize = true;
            this.courseHours.Location = new System.Drawing.Point(13, 46);
            this.courseHours.Name = "courseHours";
            this.courseHours.Size = new System.Drawing.Size(35, 13);
            this.courseHours.TabIndex = 1;
            this.courseHours.Text = "label2";
            // 
            // courseDescription
            // 
            this.courseDescription.AutoSize = true;
            this.courseDescription.Location = new System.Drawing.Point(13, 84);
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.Size = new System.Drawing.Size(35, 13);
            this.courseDescription.TabIndex = 2;
            this.courseDescription.Text = "label3";
            // 
            // coursePreReqs
            // 
            this.coursePreReqs.AutoSize = true;
            this.coursePreReqs.Location = new System.Drawing.Point(12, 118);
            this.coursePreReqs.Name = "coursePreReqs";
            this.coursePreReqs.Size = new System.Drawing.Size(35, 13);
            this.coursePreReqs.TabIndex = 3;
            this.coursePreReqs.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.closeWindow);
            // 
            // additionalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.coursePreReqs);
            this.Controls.Add(this.courseDescription);
            this.Controls.Add(this.courseHours);
            this.Controls.Add(this.courseName);
            this.Name = "additionalInfo";
            this.Text = "additionalInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseHours;
        private System.Windows.Forms.Label courseDescription;
        private System.Windows.Forms.Label coursePreReqs;
        private System.Windows.Forms.Button button1;
    }
}