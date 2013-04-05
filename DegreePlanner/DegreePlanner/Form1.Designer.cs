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
            this.BaseSchedule = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moreInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.requiredCoursesBox = new System.Windows.Forms.ListBox();
            this.reqButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            // BaseSchedule
            // 
            this.BaseSchedule.Location = new System.Drawing.Point(444, 12);
            this.BaseSchedule.Name = "BaseSchedule";
            this.BaseSchedule.Size = new System.Drawing.Size(66, 50);
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
            this.button1.Location = new System.Drawing.Point(357, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 47);
            this.button1.TabIndex = 28;
            this.button1.Text = "Reset Schedule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.scheduleReset);
            // 
            // requiredCoursesBox
            // 
            this.requiredCoursesBox.FormattingEnabled = true;
            this.requiredCoursesBox.Location = new System.Drawing.Point(397, 110);
            this.requiredCoursesBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requiredCoursesBox.Name = "requiredCoursesBox";
            this.requiredCoursesBox.Size = new System.Drawing.Size(169, 199);
            this.requiredCoursesBox.TabIndex = 31;
            // 
            // reqButton
            // 
            this.reqButton.Location = new System.Drawing.Point(570, 110);
            this.reqButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(127, 19);
            this.reqButton.TabIndex = 32;
            this.reqButton.Text = "Required Courses";
            this.reqButton.UseVisualStyleBackColor = true;
            this.reqButton.Click += new System.EventHandler(this.requiredCoursesClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 147);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 19);
            this.button2.TabIndex = 33;
            this.button2.Text = "Computer Science ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.computerScienceClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 183);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 19);
            this.button3.TabIndex = 34;
            this.button3.Text = "Social Sciences";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.socialSciencesClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 219);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 19);
            this.button4.TabIndex = 35;
            this.button4.Text = "Sciences";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.sciencesClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(570, 253);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 19);
            this.button5.TabIndex = 36;
            this.button5.Text = "Performing Arts";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.performingArtsClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(529, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 50);
            this.button6.TabIndex = 37;
            this.button6.Text = "Check My Schedule";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.checkSchedule);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reqButton);
            this.Controls.Add(this.requiredCoursesBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BaseSchedule);
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
        private System.Windows.Forms.Button BaseSchedule;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreInformationToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox requiredCoursesBox;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

