namespace Hello_World
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
            this.messageButton = new System.Windows.Forms.Button();
            this.hiddenMessageBox = new System.Windows.Forms.Label();
            this.endProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(89, 113);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(98, 38);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "Display Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // hiddenMessageBox
            // 
            this.hiddenMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hiddenMessageBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenMessageBox.Location = new System.Drawing.Point(89, 27);
            this.hiddenMessageBox.Name = "hiddenMessageBox";
            this.hiddenMessageBox.Size = new System.Drawing.Size(283, 27);
            this.hiddenMessageBox.TabIndex = 1;
            // 
            // endProgram
            // 
            this.endProgram.Location = new System.Drawing.Point(275, 113);
            this.endProgram.Name = "endProgram";
            this.endProgram.Size = new System.Drawing.Size(97, 38);
            this.endProgram.TabIndex = 2;
            this.endProgram.Text = "End Program";
            this.endProgram.UseVisualStyleBackColor = true;
            this.endProgram.Click += new System.EventHandler(this.endProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 199);
            this.Controls.Add(this.endProgram);
            this.Controls.Add(this.hiddenMessageBox);
            this.Controls.Add(this.messageButton);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Label hiddenMessageBox;
        private System.Windows.Forms.Button endProgram;
    }
}

