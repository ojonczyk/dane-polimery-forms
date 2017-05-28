namespace dane_polimery_forms
{
    partial class CommandForm
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
            this.commandsTextBox = new System.Windows.Forms.RichTextBox();
            this.loadfileButton = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonValidate = new System.Windows.Forms.Button();
            this.ButtonErLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandsTextBox
            // 
            this.commandsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandsTextBox.Location = new System.Drawing.Point(12, 12);
            this.commandsTextBox.Name = "commandsTextBox";
            this.commandsTextBox.Size = new System.Drawing.Size(377, 325);
            this.commandsTextBox.TabIndex = 1;
            this.commandsTextBox.Text = "";
            this.commandsTextBox.TextChanged += new System.EventHandler(this.CommandsTextBox_TextChanged);
            // 
            // loadfileButton
            // 
            this.loadfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadfileButton.Location = new System.Drawing.Point(395, 13);
            this.loadfileButton.Name = "loadfileButton";
            this.loadfileButton.Size = new System.Drawing.Size(91, 23);
            this.loadfileButton.TabIndex = 3;
            this.loadfileButton.Text = "Load Command";
            this.loadfileButton.UseVisualStyleBackColor = true;
            this.loadfileButton.Click += new System.EventHandler(this.ButtonLoadfile_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOk.Location = new System.Drawing.Point(395, 166);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(91, 23);
            this.ButtonOk.TabIndex = 4;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(395, 61);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(91, 23);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonValidate.Location = new System.Drawing.Point(395, 137);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(91, 23);
            this.ButtonValidate.TabIndex = 6;
            this.ButtonValidate.Text = "Check Data";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // ButtonErLog
            // 
            this.ButtonErLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonErLog.Location = new System.Drawing.Point(395, 108);
            this.ButtonErLog.Name = "ButtonErLog";
            this.ButtonErLog.Size = new System.Drawing.Size(91, 23);
            this.ButtonErLog.TabIndex = 7;
            this.ButtonErLog.Text = "Error Log";
            this.ButtonErLog.UseVisualStyleBackColor = true;
            this.ButtonErLog.Click += new System.EventHandler(this.ButtonErLog_Click);
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 349);
            this.Controls.Add(this.ButtonErLog);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.loadfileButton);
            this.Controls.Add(this.commandsTextBox);
            this.Name = "CommandForm";
            this.Text = "Load/Write Command";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox commandsTextBox;
        private System.Windows.Forms.Button loadfileButton;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonValidate;
        private System.Windows.Forms.Button ButtonErLog;
    }
}