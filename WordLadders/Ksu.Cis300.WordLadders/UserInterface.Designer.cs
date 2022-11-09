namespace Ksu.Cis300.WordLadders
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
            this.uxOpenWordList = new System.Windows.Forms.Button();
            this.uxStartingWord = new System.Windows.Forms.TextBox();
            this.uxEndingWord = new System.Windows.Forms.TextBox();
            this.uxFindWordLadder = new System.Windows.Forms.Button();
            this.uxWordLadder = new System.Windows.Forms.ListBox();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxOpenWordList
            // 
            this.uxOpenWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpenWordList.Location = new System.Drawing.Point(12, 12);
            this.uxOpenWordList.Name = "uxOpenWordList";
            this.uxOpenWordList.Size = new System.Drawing.Size(289, 36);
            this.uxOpenWordList.TabIndex = 0;
            this.uxOpenWordList.Text = "Open Word List";
            this.uxOpenWordList.UseVisualStyleBackColor = true;
            this.uxOpenWordList.Click += new System.EventHandler(this.uxOpenWordList_Click);
            // 
            // uxStartingWord
            // 
            this.uxStartingWord.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartingWord.Location = new System.Drawing.Point(12, 78);
            this.uxStartingWord.Name = "uxStartingWord";
            this.uxStartingWord.Size = new System.Drawing.Size(289, 24);
            this.uxStartingWord.TabIndex = 1;
            this.uxStartingWord.TextChanged += new System.EventHandler(this.uxStartingWord_TextChanged);
            // 
            // uxEndingWord
            // 
            this.uxEndingWord.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndingWord.Location = new System.Drawing.Point(12, 132);
            this.uxEndingWord.Name = "uxEndingWord";
            this.uxEndingWord.Size = new System.Drawing.Size(289, 24);
            this.uxEndingWord.TabIndex = 2;
            this.uxEndingWord.TextChanged += new System.EventHandler(this.uxStartingWord_TextChanged);
            // 
            // uxFindWordLadder
            // 
            this.uxFindWordLadder.Enabled = false;
            this.uxFindWordLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindWordLadder.Location = new System.Drawing.Point(12, 162);
            this.uxFindWordLadder.Name = "uxFindWordLadder";
            this.uxFindWordLadder.Size = new System.Drawing.Size(289, 36);
            this.uxFindWordLadder.TabIndex = 3;
            this.uxFindWordLadder.Text = "Find Word Ladder";
            this.uxFindWordLadder.UseVisualStyleBackColor = true;
            this.uxFindWordLadder.Click += new System.EventHandler(this.uxFindWordLadder_Click);
            // 
            // uxWordLadder
            // 
            this.uxWordLadder.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWordLadder.FormattingEnabled = true;
            this.uxWordLadder.ItemHeight = 17;
            this.uxWordLadder.Location = new System.Drawing.Point(12, 204);
            this.uxWordLadder.Name = "uxWordLadder";
            this.uxWordLadder.Size = new System.Drawing.Size(289, 242);
            this.uxWordLadder.TabIndex = 4;
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(12, 51);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(128, 24);
            this.uxStartLabel.TabIndex = 5;
            this.uxStartLabel.Text = "Starting Word:";
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndLabel.Location = new System.Drawing.Point(12, 105);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(127, 24);
            this.uxEndLabel.TabIndex = 6;
            this.uxEndLabel.Text = "Ending Word:";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "Text files|*.txt|All files|*.*";
            this.uxOpenDialog.Title = "Open Word List";
            // 
            // UserInterface
            // 
            this.AcceptButton = this.uxFindWordLadder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 463);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxWordLadder);
            this.Controls.Add(this.uxFindWordLadder);
            this.Controls.Add(this.uxEndingWord);
            this.Controls.Add(this.uxStartingWord);
            this.Controls.Add(this.uxOpenWordList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 502);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 502);
            this.Name = "UserInterface";
            this.Text = "Word Ladders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOpenWordList;
        private System.Windows.Forms.TextBox uxStartingWord;
        private System.Windows.Forms.TextBox uxEndingWord;
        private System.Windows.Forms.Button uxFindWordLadder;
        private System.Windows.Forms.ListBox uxWordLadder;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
    }
}

