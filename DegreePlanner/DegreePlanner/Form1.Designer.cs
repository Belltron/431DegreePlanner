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
            this.button1 = new System.Windows.Forms.Button();
            this.courseBox = new System.Windows.Forms.ListBox();
            this.freshmanFall = new System.Windows.Forms.ListBox();
            this.freshmanSpring = new System.Windows.Forms.ListBox();
            this.sophomoreFall = new System.Windows.Forms.ListBox();
            this.sophomoreSpring = new System.Windows.Forms.ListBox();
            this.juniorFall = new System.Windows.Forms.ListBox();
            this.juniorSpring = new System.Windows.Forms.ListBox();
            this.seniorFall = new System.Windows.Forms.ListBox();
            this.seniorSpring = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_click);
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(432, 137);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(158, 95);
            this.courseBox.Sorted = true;
            this.courseBox.TabIndex = 2;
            // 
            // freshmanFall
            // 
            this.freshmanFall.AllowDrop = true;
            this.freshmanFall.FormattingEnabled = true;
            this.freshmanFall.Location = new System.Drawing.Point(77, 53);
            this.freshmanFall.Name = "freshmanFall";
            this.freshmanFall.Size = new System.Drawing.Size(120, 95);
            this.freshmanFall.TabIndex = 3;
            // 
            // freshmanSpring
            // 
            this.freshmanSpring.AllowDrop = true;
            this.freshmanSpring.FormattingEnabled = true;
            this.freshmanSpring.Location = new System.Drawing.Point(237, 53);
            this.freshmanSpring.Name = "freshmanSpring";
            this.freshmanSpring.Size = new System.Drawing.Size(120, 95);
            this.freshmanSpring.TabIndex = 4;
            // 
            // sophomoreFall
            // 
            this.sophomoreFall.AllowDrop = true;
            this.sophomoreFall.FormattingEnabled = true;
            this.sophomoreFall.Location = new System.Drawing.Point(77, 165);
            this.sophomoreFall.Name = "sophomoreFall";
            this.sophomoreFall.Size = new System.Drawing.Size(120, 95);
            this.sophomoreFall.TabIndex = 5;
            // 
            // sophomoreSpring
            // 
            this.sophomoreSpring.AllowDrop = true;
            this.sophomoreSpring.FormattingEnabled = true;
            this.sophomoreSpring.Location = new System.Drawing.Point(237, 165);
            this.sophomoreSpring.Name = "sophomoreSpring";
            this.sophomoreSpring.Size = new System.Drawing.Size(120, 95);
            this.sophomoreSpring.TabIndex = 6;
            // 
            // juniorFall
            // 
            this.juniorFall.AllowDrop = true;
            this.juniorFall.FormattingEnabled = true;
            this.juniorFall.Location = new System.Drawing.Point(77, 279);
            this.juniorFall.Name = "juniorFall";
            this.juniorFall.Size = new System.Drawing.Size(120, 95);
            this.juniorFall.TabIndex = 7;
            // 
            // juniorSpring
            // 
            this.juniorSpring.AllowDrop = true;
            this.juniorSpring.FormattingEnabled = true;
            this.juniorSpring.Location = new System.Drawing.Point(237, 279);
            this.juniorSpring.Name = "juniorSpring";
            this.juniorSpring.Size = new System.Drawing.Size(120, 95);
            this.juniorSpring.TabIndex = 8;
            // 
            // seniorFall
            // 
            this.seniorFall.AllowDrop = true;
            this.seniorFall.FormattingEnabled = true;
            this.seniorFall.Location = new System.Drawing.Point(77, 389);
            this.seniorFall.Name = "seniorFall";
            this.seniorFall.Size = new System.Drawing.Size(120, 95);
            this.seniorFall.TabIndex = 9;
            // 
            // seniorSpring
            // 
            this.seniorSpring.AllowDrop = true;
            this.seniorSpring.FormattingEnabled = true;
            this.seniorSpring.Location = new System.Drawing.Point(237, 389);
            this.seniorSpring.Name = "seniorSpring";
            this.seniorSpring.Size = new System.Drawing.Size(120, 95);
            this.seniorSpring.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 34);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seniorSpring);
            this.Controls.Add(this.seniorFall);
            this.Controls.Add(this.juniorSpring);
            this.Controls.Add(this.juniorFall);
            this.Controls.Add(this.sophomoreSpring);
            this.Controls.Add(this.sophomoreFall);
            this.Controls.Add(this.freshmanSpring);
            this.Controls.Add(this.freshmanFall);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox courseBox;
        private System.Windows.Forms.ListBox freshmanFall;
        private System.Windows.Forms.ListBox freshmanSpring;
        private System.Windows.Forms.ListBox sophomoreFall;
        private System.Windows.Forms.ListBox sophomoreSpring;
        private System.Windows.Forms.ListBox juniorFall;
        private System.Windows.Forms.ListBox juniorSpring;
        private System.Windows.Forms.ListBox seniorFall;
        private System.Windows.Forms.ListBox seniorSpring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

