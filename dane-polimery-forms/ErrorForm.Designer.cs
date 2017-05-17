namespace dane_polimery_forms
{
    partial class FormErrorLog
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
            this.ErrorListBox = new System.Windows.Forms.ListBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorListBox
            // 
            this.ErrorListBox.FormattingEnabled = true;
            this.ErrorListBox.Location = new System.Drawing.Point(12, 12);
            this.ErrorListBox.Name = "ErrorListBox";
            this.ErrorListBox.Size = new System.Drawing.Size(293, 238);
            this.ErrorListBox.TabIndex = 0;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(311, 223);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(85, 26);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // FormErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.ErrorListBox);
            this.Name = "FormErrorLog";
            this.Text = "Error Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ErrorListBox;
        private System.Windows.Forms.Button ButtonOK;
    }
}