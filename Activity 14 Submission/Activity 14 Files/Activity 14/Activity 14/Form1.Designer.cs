namespace Activity_14
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
            this.fontListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.Label();
            this.radioBoldGroup = new System.Windows.Forms.GroupBox();
            this.noBoldButton = new System.Windows.Forms.RadioButton();
            this.yesBoldButton = new System.Windows.Forms.RadioButton();
            this.checkBoxGroup = new System.Windows.Forms.GroupBox();
            this.specialMessageBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBoldGroup.SuspendLayout();
            this.checkBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontListBox
            // 
            this.fontListBox.FormattingEnabled = true;
            this.fontListBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Purple"});
            this.fontListBox.Location = new System.Drawing.Point(38, 70);
            this.fontListBox.Name = "fontListBox";
            this.fontListBox.Size = new System.Drawing.Size(120, 69);
            this.fontListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Font";
            // 
            // writeButton
            // 
            this.writeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeButton.Location = new System.Drawing.Point(250, 316);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(115, 50);
            this.writeButton.TabIndex = 6;
            this.writeButton.Text = "Write Signature";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(380, 316);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 50);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultsBox.Location = new System.Drawing.Point(247, 126);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(252, 164);
            this.resultsBox.TabIndex = 8;
            this.resultsBox.Text = " ";
            this.resultsBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioBoldGroup
            // 
            this.radioBoldGroup.Controls.Add(this.noBoldButton);
            this.radioBoldGroup.Controls.Add(this.yesBoldButton);
            this.radioBoldGroup.Location = new System.Drawing.Point(38, 167);
            this.radioBoldGroup.Name = "radioBoldGroup";
            this.radioBoldGroup.Size = new System.Drawing.Size(162, 82);
            this.radioBoldGroup.TabIndex = 9;
            this.radioBoldGroup.TabStop = false;
            this.radioBoldGroup.Text = "Select for Bold";
            // 
            // noBoldButton
            // 
            this.noBoldButton.AutoSize = true;
            this.noBoldButton.Location = new System.Drawing.Point(6, 59);
            this.noBoldButton.Name = "noBoldButton";
            this.noBoldButton.Size = new System.Drawing.Size(110, 17);
            this.noBoldButton.TabIndex = 1;
            this.noBoldButton.Text = "Do not make Bold";
            this.noBoldButton.UseVisualStyleBackColor = true;
            // 
            // yesBoldButton
            // 
            this.yesBoldButton.AutoSize = true;
            this.yesBoldButton.Checked = true;
            this.yesBoldButton.Location = new System.Drawing.Point(6, 33);
            this.yesBoldButton.Name = "yesBoldButton";
            this.yesBoldButton.Size = new System.Drawing.Size(46, 17);
            this.yesBoldButton.TabIndex = 0;
            this.yesBoldButton.TabStop = true;
            this.yesBoldButton.Text = "Bold";
            this.yesBoldButton.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.Controls.Add(this.specialMessageBox);
            this.checkBoxGroup.Controls.Add(this.dateCheckBox);
            this.checkBoxGroup.Controls.Add(this.nameCheckBox);
            this.checkBoxGroup.Location = new System.Drawing.Point(38, 277);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(162, 110);
            this.checkBoxGroup.TabIndex = 10;
            this.checkBoxGroup.TabStop = false;
            this.checkBoxGroup.Text = "Select what to include";
            // 
            // specialMessageBox
            // 
            this.specialMessageBox.AutoSize = true;
            this.specialMessageBox.Location = new System.Drawing.Point(6, 58);
            this.specialMessageBox.Name = "specialMessageBox";
            this.specialMessageBox.Size = new System.Drawing.Size(107, 17);
            this.specialMessageBox.TabIndex = 2;
            this.specialMessageBox.Text = "Special Message";
            this.specialMessageBox.UseVisualStyleBackColor = true;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(6, 87);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dateCheckBox.TabIndex = 1;
            this.dateCheckBox.Text = "Date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Location = new System.Drawing.Point(6, 28);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 17);
            this.nameCheckBox.TabIndex = 0;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resulting Sample Signature";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxGroup);
            this.Controls.Add(this.radioBoldGroup);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontListBox);
            this.Name = "Form1";
            this.Text = "Signature Maker";
            this.radioBoldGroup.ResumeLayout(false);
            this.radioBoldGroup.PerformLayout();
            this.checkBoxGroup.ResumeLayout(false);
            this.checkBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fontListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultsBox;
        private System.Windows.Forms.GroupBox radioBoldGroup;
        private System.Windows.Forms.RadioButton noBoldButton;
        private System.Windows.Forms.RadioButton yesBoldButton;
        private System.Windows.Forms.GroupBox checkBoxGroup;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox specialMessageBox;
    }
}

