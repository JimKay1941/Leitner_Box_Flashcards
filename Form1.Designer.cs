namespace Leitner_Box_Flashcards
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
            this.OutputFileName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Choose Output File:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // OutputFileName
            // 
            this.OutputFileName.Location = new System.Drawing.Point(128, 18);
            this.OutputFileName.Name = "OutputFileName";
            this.OutputFileName.Size = new System.Drawing.Size(595, 20);
            this.OutputFileName.TabIndex = 1;
            this.OutputFileName.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(855, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Current Card Number:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 30);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Question [ Do Not Use \" Character]";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 30);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.Text = "Answer [Do Not Use \" Character]";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 96);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(890, 270);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 413);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(890, 270);
            this.textBox3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "Write Flashcard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(793, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 30);
            this.button6.TabIndex = 9;
            this.button6.TabStop = false;
            this.button6.Text = "Close and Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 383);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 692);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OutputFileName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Create Flashcards for the Original Leitner Box Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox OutputFileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

