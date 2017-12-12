namespace HW6
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
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.BTN1 = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(27, 41);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(128, 20);
            this.Weight.TabIndex = 0;
            this.Weight.Text = "Enter Body Weight (lbs)";
            this.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weight.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(27, 90);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(123, 20);
            this.Height.TabIndex = 1;
            this.Height.Text = "Height (inches)";
            this.Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(58, 155);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(66, 51);
            this.BTN1.TabIndex = 2;
            this.BTN1.Text = "Calculate";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(221, 90);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(317, 20);
            this.Results.TabIndex = 3;
            this.Results.Text = "BMI results";
            this.Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.TextBox Results;
    }
}

