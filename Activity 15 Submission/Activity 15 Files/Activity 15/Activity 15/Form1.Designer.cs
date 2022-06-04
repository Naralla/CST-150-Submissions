namespace Activity_15
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
            this.birthYearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.birthDayComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getLuckyNumbersButton = new System.Windows.Forms.Button();
            this.secretMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your birth year";
            // 
            // birthYearComboBox
            // 
            this.birthYearComboBox.FormattingEnabled = true;
            this.birthYearComboBox.Location = new System.Drawing.Point(165, 70);
            this.birthYearComboBox.Name = "birthYearComboBox";
            this.birthYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthYearComboBox.TabIndex = 1;
            this.birthYearComboBox.SelectedIndexChanged += new System.EventHandler(this.birthYearComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your birth month";
            // 
            // birthDayComboBox
            // 
            this.birthDayComboBox.FormattingEnabled = true;
            this.birthDayComboBox.Location = new System.Drawing.Point(165, 178);
            this.birthDayComboBox.Name = "birthDayComboBox";
            this.birthDayComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthDayComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your birth day";
            // 
            // getLuckyNumbersButton
            // 
            this.getLuckyNumbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLuckyNumbersButton.Location = new System.Drawing.Point(15, 251);
            this.getLuckyNumbersButton.Name = "getLuckyNumbersButton";
            this.getLuckyNumbersButton.Size = new System.Drawing.Size(271, 52);
            this.getLuckyNumbersButton.TabIndex = 6;
            this.getLuckyNumbersButton.Text = "Get Your Lucky Number";
            this.getLuckyNumbersButton.UseVisualStyleBackColor = true;
            this.getLuckyNumbersButton.Click += new System.EventHandler(this.getLuckyNumbersButton_Click);
            // 
            // secretMessageButton
            // 
            this.secretMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secretMessageButton.Location = new System.Drawing.Point(12, 331);
            this.secretMessageButton.Name = "secretMessageButton";
            this.secretMessageButton.Size = new System.Drawing.Size(143, 50);
            this.secretMessageButton.TabIndex = 7;
            this.secretMessageButton.Text = "Secret Message?";
            this.secretMessageButton.UseVisualStyleBackColor = true;
            this.secretMessageButton.Click += new System.EventHandler(this.secretMessageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(313, 393);
            this.Controls.Add(this.secretMessageButton);
            this.Controls.Add(this.getLuckyNumbersButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthDayComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthYearComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox birthYearComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox birthDayComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getLuckyNumbersButton;
        private System.Windows.Forms.Button secretMessageButton;
    }
}

