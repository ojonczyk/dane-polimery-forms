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
            this.components = new System.ComponentModel.Container();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ErrorGrid = new System.Windows.Forms.DataGridView();
            this.formErrorLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formErrorLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Location = new System.Drawing.Point(339, 227);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(85, 26);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ErrorGrid
            // 
            this.ErrorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ErrorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ErrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorGrid.Location = new System.Drawing.Point(12, 12);
            this.ErrorGrid.Name = "ErrorGrid";
            this.ErrorGrid.RowHeadersVisible = false;
            this.ErrorGrid.Size = new System.Drawing.Size(321, 241);
            this.ErrorGrid.TabIndex = 2;
            // 
            // formErrorLogBindingSource
            // 
            this.formErrorLogBindingSource.DataSource = typeof(dane_polimery_forms.FormErrorLog);
            // 
            // FormErrorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 265);
            this.Controls.Add(this.ErrorGrid);
            this.Controls.Add(this.ButtonOK);
            this.Name = "FormErrorLog";
            this.Text = "Error Log";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formErrorLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.DataGridView ErrorGrid;
        private System.Windows.Forms.BindingSource formErrorLogBindingSource;
    }
}