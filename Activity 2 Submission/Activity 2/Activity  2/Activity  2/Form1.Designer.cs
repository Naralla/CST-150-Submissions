namespace Activity__2
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
            this.earthWeightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.marsWeightBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your weight on Earth";
            // 
            // earthWeightBox
            // 
            this.earthWeightBox.Location = new System.Drawing.Point(248, 40);
            this.earthWeightBox.Name = "earthWeightBox";
            this.earthWeightBox.Size = new System.Drawing.Size(100, 20);
            this.earthWeightBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Weight on Mars";
            // 
            // marsWeightBox
            // 
            this.marsWeightBox.Location = new System.Drawing.Point(248, 94);
            this.marsWeightBox.Name = "marsWeightBox";
            this.marsWeightBox.Size = new System.Drawing.Size(100, 20);
            this.marsWeightBox.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(248, 166);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(98, 43);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 241);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.earthWeightBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Your Weight on Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox earthWeightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox marsWeightBox;
        private System.Windows.Forms.Button convertButton;
    }
}

