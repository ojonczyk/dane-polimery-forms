namespace dane_polimery_forms
{
    partial class SpectForm
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
            this.IntegrTTextBox = new System.Windows.Forms.TextBox();
            this.AverageTTextBox = new System.Windows.Forms.TextBox();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.BoxcarWidthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.indexComboBox = new System.Windows.Forms.ComboBox();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.SetDefaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IntegrTTextBox
            // 
            this.IntegrTTextBox.Location = new System.Drawing.Point(107, 62);
            this.IntegrTTextBox.Name = "IntegrTTextBox";
            this.IntegrTTextBox.Size = new System.Drawing.Size(126, 20);
            this.IntegrTTextBox.TabIndex = 0;
            this.IntegrTTextBox.TextChanged += new System.EventHandler(this.IntegrTTextBox_TextChanged);
            // 
            // AverageTTextBox
            // 
            this.AverageTTextBox.Location = new System.Drawing.Point(107, 92);
            this.AverageTTextBox.Name = "AverageTTextBox";
            this.AverageTTextBox.Size = new System.Drawing.Size(126, 20);
            this.AverageTTextBox.TabIndex = 1;
            this.AverageTTextBox.TextChanged += new System.EventHandler(this.AverageTTextBox_TextChanged);
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(107, 118);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(126, 20);
            this.SumTextBox.TabIndex = 2;
            this.SumTextBox.TextChanged += new System.EventHandler(this.SumTextBox_TextChanged);
            // 
            // BoxcarWidthTextBox
            // 
            this.BoxcarWidthTextBox.Location = new System.Drawing.Point(107, 144);
            this.BoxcarWidthTextBox.Name = "BoxcarWidthTextBox";
            this.BoxcarWidthTextBox.Size = new System.Drawing.Size(126, 20);
            this.BoxcarWidthTextBox.TabIndex = 3;
            this.BoxcarWidthTextBox.TextChanged += new System.EventHandler(this.BoxcarWidthTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Integration Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Boxcar Width";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(28, 174);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "Ok";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(135, 174);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // indexComboBox
            // 
            this.indexComboBox.FormattingEnabled = true;
            this.indexComboBox.Location = new System.Drawing.Point(107, 35);
            this.indexComboBox.Name = "indexComboBox";
            this.indexComboBox.Size = new System.Drawing.Size(126, 21);
            this.indexComboBox.TabIndex = 10;
            this.indexComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(2, 40);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(99, 13);
            this.IndexLabel.TabIndex = 11;
            this.IndexLabel.Text = "Spectrometer Index";
            // 
            // SetDefaultButton
            // 
            this.SetDefaultButton.Location = new System.Drawing.Point(107, 6);
            this.SetDefaultButton.Name = "SetDefaultButton";
            this.SetDefaultButton.Size = new System.Drawing.Size(126, 23);
            this.SetDefaultButton.TabIndex = 12;
            this.SetDefaultButton.Text = "Set Default";
            this.SetDefaultButton.UseVisualStyleBackColor = true;
            this.SetDefaultButton.Click += new System.EventHandler(this.SetDefaultButton_Click);
            // 
            // SpectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 201);
            this.Controls.Add(this.SetDefaultButton);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.indexComboBox);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxcarWidthTextBox);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.AverageTTextBox);
            this.Controls.Add(this.IntegrTTextBox);
            this.Name = "SpectForm";
            this.Text = "SpectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IntegrTTextBox;
        private System.Windows.Forms.TextBox AverageTTextBox;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.TextBox BoxcarWidthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox indexComboBox;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Button SetDefaultButton;
    }
}