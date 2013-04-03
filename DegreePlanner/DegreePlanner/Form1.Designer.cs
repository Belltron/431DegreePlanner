namespace DegreePlanner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BaseSchedule = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moreInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.compSciLabel = new System.Windows.Forms.Label();
            this.requiredCoursesBox = new System.Windows.Forms.ListBox();
            this.reqButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spring";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Freshman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sophomore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Junior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Senior";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Performing Arts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sciences";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Social Sciences";
            // 
            // BaseSchedule
            // 
            this.BaseSchedule.Location = new System.Drawing.Point(344, 41);
            this.BaseSchedule.Name = "BaseSchedule";
            this.BaseSchedule.Size = new System.Drawing.Size(76, 48);
            this.BaseSchedule.TabIndex = 27;
            this.BaseSchedule.Text = "Generate Base Schedule";
            this.BaseSchedule.UseVisualStyleBackColor = true;
            this.BaseSchedule.Click += new System.EventHandler(this.BaseSchedule_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreInformationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 26);
            // 
            // moreInformationToolStripMenuItem
            // 
            this.moreInformationToolStripMenuItem.Name = "moreInformationToolStripMenuItem";
            this.moreInformationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.moreInformationToolStripMenuItem.Text = "More Information...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Reset Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.scheduleReset);
            // 
            // compSciLabel
            // 
            this.compSciLabel.AutoSize = true;
            this.compSciLabel.Location = new System.Drawing.Point(442, 59);
            this.compSciLabel.Name = "compSciLabel";
            this.compSciLabel.Size = new System.Drawing.Size(135, 13);
            this.compSciLabel.TabIndex = 30;
            this.compSciLabel.Text = "Computer Science Courses";
            // 
            // requiredCoursesBox
            // 
            this.requiredCoursesBox.FormattingEnabled = true;
            this.requiredCoursesBox.Location = new System.Drawing.Point(445, 94);
            this.requiredCoursesBox.Name = "requiredCoursesBox";
            this.requiredCoursesBox.Size = new System.Drawing.Size(156, 212);
            this.requiredCoursesBox.TabIndex = 31;
            // 
            // reqButton
            // 
            this.reqButton.Location = new System.Drawing.Point(618, 94);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(115, 23);
            this.reqButton.TabIndex = 32;
            this.reqButton.Text = "Required Courses";
            this.reqButton.UseVisualStyleBackColor = true;
            this.reqButton.Click += new System.EventHandler(this.requiredCoursesClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Computer Science ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.computerScienceClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Social Sciences";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.socialSciencesClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Sciences";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.sciencesClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(618, 273);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Performing Arts";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.performingArtsClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reqButton);
            this.Controls.Add(this.requiredCoursesBox);
            this.Controls.Add(this.compSciLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BaseSchedule);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BaseSchedule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreInformationToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label compSciLabel;
        private System.Windows.Forms.ListBox requiredCoursesBox;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

