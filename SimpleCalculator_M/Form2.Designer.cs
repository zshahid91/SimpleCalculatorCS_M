namespace SimpleCalculator_M
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(62, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(669, 81);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(139, 357);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(94, 54);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(239, 357);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(94, 54);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(339, 357);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(94, 54);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(139, 297);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(94, 54);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(239, 297);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(94, 54);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(339, 297);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(94, 54);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(524, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 54);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.Location = new System.Drawing.Point(624, 297);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(94, 54);
            this.SubButton.TabIndex = 10;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualButton.Location = new System.Drawing.Point(580, 357);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(94, 54);
            this.EqualButton.TabIndex = 11;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button EqualButton;
    }
}