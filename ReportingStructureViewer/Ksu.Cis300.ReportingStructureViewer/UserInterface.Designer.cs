namespace Ksu.Cis300.ReportingStructureViewer
{
    partial class UserInterface
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
            this.uxDepthLabel = new System.Windows.Forms.Label();
            this.uxPrefix = new System.Windows.Forms.TextBox();
            this.uxReport = new System.Windows.Forms.WebBrowser();
            this.uxDepth = new System.Windows.Forms.NumericUpDown();
            this.uxLookup = new System.Windows.Forms.Button();
            this.uxGenerateReport = new System.Windows.Forms.Button();
            this.uxNames = new System.Windows.Forms.ListBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.uxDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDepthLabel
            // 
            this.uxDepthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxDepthLabel.AutoSize = true;
            this.uxDepthLabel.Location = new System.Drawing.Point(9, 323);
            this.uxDepthLabel.Name = "uxDepthLabel";
            this.uxDepthLabel.Size = new System.Drawing.Size(39, 13);
            this.uxDepthLabel.TabIndex = 0;
            this.uxDepthLabel.Text = "Depth:";
            // 
            // uxPrefix
            // 
            this.uxPrefix.Location = new System.Drawing.Point(12, 12);
            this.uxPrefix.Name = "uxPrefix";
            this.uxPrefix.Size = new System.Drawing.Size(141, 20);
            this.uxPrefix.TabIndex = 1;
            this.uxPrefix.TextChanged += new System.EventHandler(this.uxPrefix_TextChanged);
            // 
            // uxReport
            // 
            this.uxReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxReport.Location = new System.Drawing.Point(250, 12);
            this.uxReport.Name = "uxReport";
            this.uxReport.Size = new System.Drawing.Size(442, 329);
            this.uxReport.TabIndex = 2;
            // 
            // uxDepth
            // 
            this.uxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxDepth.Location = new System.Drawing.Point(54, 321);
            this.uxDepth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.uxDepth.Name = "uxDepth";
            this.uxDepth.Size = new System.Drawing.Size(55, 20);
            this.uxDepth.TabIndex = 3;
            this.uxDepth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // uxLookup
            // 
            this.uxLookup.Enabled = false;
            this.uxLookup.Location = new System.Drawing.Point(159, 12);
            this.uxLookup.Name = "uxLookup";
            this.uxLookup.Size = new System.Drawing.Size(85, 23);
            this.uxLookup.TabIndex = 4;
            this.uxLookup.Text = "Lookup";
            this.uxLookup.UseVisualStyleBackColor = true;
            this.uxLookup.Click += new System.EventHandler(this.uxLookup_Click);
            // 
            // uxGenerateReport
            // 
            this.uxGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxGenerateReport.Location = new System.Drawing.Point(115, 318);
            this.uxGenerateReport.Name = "uxGenerateReport";
            this.uxGenerateReport.Size = new System.Drawing.Size(129, 24);
            this.uxGenerateReport.TabIndex = 5;
            this.uxGenerateReport.Text = "Generate Report";
            this.uxGenerateReport.UseVisualStyleBackColor = true;
            this.uxGenerateReport.Click += new System.EventHandler(this.uxGenerateReport_Click);
            // 
            // uxNames
            // 
            this.uxNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uxNames.FormattingEnabled = true;
            this.uxNames.Location = new System.Drawing.Point(12, 38);
            this.uxNames.Name = "uxNames";
            this.uxNames.Size = new System.Drawing.Size(232, 277);
            this.uxNames.TabIndex = 6;
            this.uxNames.SelectedIndexChanged += new System.EventHandler(this.uxNames_SelectedIndexChanged);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "CSV files|*.csv|All files|*.*";
            this.uxOpenDialog.Title = "Open Organization File";
            // 
            // uxSaveDialog
            // 
            this.uxSaveDialog.Filter = "HTML files |*.html | All Files | *.* ";
            // 
            // UserInterface
            // 
            this.AcceptButton = this.uxLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.uxNames);
            this.Controls.Add(this.uxGenerateReport);
            this.Controls.Add(this.uxLookup);
            this.Controls.Add(this.uxDepth);
            this.Controls.Add(this.uxDepthLabel);
            this.Controls.Add(this.uxPrefix);
            this.Controls.Add(this.uxReport);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDepthLabel;
        private System.Windows.Forms.TextBox uxPrefix;
        private System.Windows.Forms.WebBrowser uxReport;
        private System.Windows.Forms.NumericUpDown uxDepth;
        private System.Windows.Forms.Button uxLookup;
        private System.Windows.Forms.Button uxGenerateReport;
        private System.Windows.Forms.ListBox uxNames;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
    }
}