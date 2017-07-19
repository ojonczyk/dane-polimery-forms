namespace dane_polimery_forms
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.widmo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.commandsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.outfileLabel = new System.Windows.Forms.Label();
            this.outfileTextBox = new System.Windows.Forms.TextBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.CommandLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExpNumberLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ButtonOutFile = new System.Windows.Forms.Button();
            this.ButtonSpect = new System.Windows.Forms.Button();
            this.LabelSpect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widmo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // widmo
            // 
            this.widmo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.widmo.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.widmo.Legends.Add(legend1);
            this.widmo.Location = new System.Drawing.Point(12, 137);
            this.widmo.Name = "widmo";
            this.widmo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "widmo";
            this.widmo.Series.Add(series1);
            this.widmo.Size = new System.Drawing.Size(793, 350);
            this.widmo.TabIndex = 0;
            this.widmo.Text = "chart1";
            // 
            // commandsTextBox
            // 
            this.commandsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commandsTextBox.Location = new System.Drawing.Point(527, 23);
            this.commandsTextBox.Name = "commandsTextBox";
            this.commandsTextBox.Size = new System.Drawing.Size(172, 20);
            this.commandsTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(705, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonCommands_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(365, 86);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(156, 13);
            this.frequencyLabel.TabIndex = 5;
            this.frequencyLabel.Text = "Odstęp odczytu spektrometru(s)";
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyTextBox.Location = new System.Drawing.Point(527, 83);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(172, 20);
            this.frequencyTextBox.TabIndex = 6;
            this.frequencyTextBox.TextChanged += new System.EventHandler(this.FrequencyTextBox_TextChanged);
            // 
            // outfileLabel
            // 
            this.outfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outfileLabel.AutoSize = true;
            this.outfileLabel.Location = new System.Drawing.Point(430, 56);
            this.outfileLabel.Name = "outfileLabel";
            this.outfileLabel.Size = new System.Drawing.Size(91, 13);
            this.outfileLabel.TabIndex = 7;
            this.outfileLabel.Text = "Nazwa pliku OUT";
            // 
            // outfileTextBox
            // 
            this.outfileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outfileTextBox.Enabled = false;
            this.outfileTextBox.Location = new System.Drawing.Point(527, 53);
            this.outfileTextBox.Name = "outfileTextBox";
            this.outfileTextBox.Size = new System.Drawing.Size(172, 20);
            this.outfileTextBox.TabIndex = 8;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStop.Location = new System.Drawing.Point(705, 83);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(100, 24);
            this.ButtonStop.TabIndex = 9;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(705, 112);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 23);
            this.ButtonStart.TabIndex = 10;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // CommandLabel
            // 
            this.CommandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(470, 26);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(51, 13);
            this.CommandLabel.TabIndex = 11;
            this.CommandLabel.Text = "Komendy";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Location = new System.Drawing.Point(12, 26);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(339, 105);
            this.commentTextBox.TabIndex = 12;
            this.commentTextBox.Text = "";
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Location = new System.Drawing.Point(12, 7);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(57, 13);
            this.CommentLabel.TabIndex = 13;
            this.CommentLabel.Text = "Komentarz";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel,
            this.ExpNumberLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(71, 17);
            this.ProgressLabel.Text = "Postęp... 0%";
            this.ProgressLabel.Visible = false;
            // 
            // ExpNumberLabel
            // 
            this.ExpNumberLabel.Name = "ExpNumberLabel";
            this.ExpNumberLabel.Size = new System.Drawing.Size(35, 17);
            this.ExpNumberLabel.Text = "Linia ";
            this.ExpNumberLabel.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ButtonOutFile
            // 
            this.ButtonOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOutFile.Location = new System.Drawing.Point(705, 53);
            this.ButtonOutFile.Name = "ButtonOutFile";
            this.ButtonOutFile.Size = new System.Drawing.Size(100, 23);
            this.ButtonOutFile.TabIndex = 16;
            this.ButtonOutFile.Text = "Choose file";
            this.ButtonOutFile.UseVisualStyleBackColor = true;
            this.ButtonOutFile.Click += new System.EventHandler(this.ButtonOutFile_Click);
            // 
            // ButtonSpect
            // 
            this.ButtonSpect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSpect.Location = new System.Drawing.Point(527, 112);
            this.ButtonSpect.Name = "ButtonSpect";
            this.ButtonSpect.Size = new System.Drawing.Size(172, 23);
            this.ButtonSpect.TabIndex = 17;
            this.ButtonSpect.Text = "Spektrometr";
            this.ButtonSpect.UseVisualStyleBackColor = true;
            this.ButtonSpect.Click += new System.EventHandler(this.ButtonSpect_Click);
            // 
            // LabelSpect
            // 
            this.LabelSpect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSpect.AutoSize = true;
            this.LabelSpect.Location = new System.Drawing.Point(430, 112);
            this.LabelSpect.Name = "LabelSpect";
            this.LabelSpect.Size = new System.Drawing.Size(66, 13);
            this.LabelSpect.TabIndex = 18;
            this.LabelSpect.Text = "Konfiguracja";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 512);
            this.Controls.Add(this.LabelSpect);
            this.Controls.Add(this.ButtonSpect);
            this.Controls.Add(this.ButtonOutFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.CommandLabel);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.outfileTextBox);
            this.Controls.Add(this.outfileLabel);
            this.Controls.Add(this.frequencyTextBox);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.commandsTextBox);
            this.Controls.Add(this.widmo);
            this.Name = "MainWindow";
            this.Text = "DataGrabber";
            ((System.ComponentModel.ISupportInitialize)(this.widmo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart widmo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox commandsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Label outfileLabel;
        private System.Windows.Forms.TextBox outfileTextBox;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label CommandLabel;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ButtonOutFile;
        private System.Windows.Forms.ToolStripStatusLabel ExpNumberLabel;
        private System.Windows.Forms.Button ButtonSpect;
        private System.Windows.Forms.Label LabelSpect;
    }
}

