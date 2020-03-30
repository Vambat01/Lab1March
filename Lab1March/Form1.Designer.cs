namespace Lab1March
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
            this.label1 = new System.Windows.Forms.Label();
            this.ageEnter = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter age of 6 student";
            // 
            // ageEnter
            // 
            this.ageEnter.Location = new System.Drawing.Point(16, 48);
            this.ageEnter.Name = "ageEnter";
            this.ageEnter.Size = new System.Drawing.Size(146, 22);
            this.ageEnter.TabIndex = 2;
            this.ageEnter.TextChanged += new System.EventHandler(this.ageEnter_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(173, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 92);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(12, 127);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(75, 23);
            this.CountButton.TabIndex = 4;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(170, 127);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 319);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ageEnter);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageEnter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

