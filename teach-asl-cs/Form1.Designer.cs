namespace TeachAslCsharp
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
            this.previousButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nextSymbol = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.learnPage = new System.Windows.Forms.TabPage();
            this.practicePage = new System.Windows.Forms.TabPage();
            this.symbolSearch = new System.Windows.Forms.TextBox();
            this.symbolList = new System.Windows.Forms.ListBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.learnPage.SuspendLayout();
            this.practicePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(4, 466);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(290, 79);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous Symbol";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(4, 5);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1067, 456);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // nextSymbol
            // 
            this.nextSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextSymbol.Location = new System.Drawing.Point(810, 466);
            this.nextSymbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextSymbol.Name = "nextSymbol";
            this.nextSymbol.Size = new System.Drawing.Size(264, 79);
            this.nextSymbol.TabIndex = 4;
            this.nextSymbol.Text = "Next Symbol";
            this.nextSymbol.UseVisualStyleBackColor = true;
            this.nextSymbol.Click += new System.EventHandler(this.nextSymbol_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.learnPage);
            this.tabControl.Controls.Add(this.practicePage);
            this.tabControl.Location = new System.Drawing.Point(9, 10);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1091, 597);
            this.tabControl.TabIndex = 5;
            // 
            // learnPage
            // 
            this.learnPage.Controls.Add(this.pictureBox);
            this.learnPage.Controls.Add(this.nextSymbol);
            this.learnPage.Controls.Add(this.previousButton);
            this.learnPage.Location = new System.Drawing.Point(8, 39);
            this.learnPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.learnPage.Name = "learnPage";
            this.learnPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.learnPage.Size = new System.Drawing.Size(1075, 550);
            this.learnPage.TabIndex = 0;
            this.learnPage.Text = "Learn";
            this.learnPage.UseVisualStyleBackColor = true;
            // 
            // practicePage
            // 
            this.practicePage.Controls.Add(this.symbolSearch);
            this.practicePage.Controls.Add(this.symbolList);
            this.practicePage.Controls.Add(this.randomButton);
            this.practicePage.Controls.Add(this.statusLabel);
            this.practicePage.Controls.Add(this.promptLabel);
            this.practicePage.Location = new System.Drawing.Point(8, 39);
            this.practicePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.practicePage.Name = "practicePage";
            this.practicePage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.practicePage.Size = new System.Drawing.Size(1075, 550);
            this.practicePage.TabIndex = 1;
            this.practicePage.Text = "Practice";
            this.practicePage.UseVisualStyleBackColor = true;
            // 
            // symbolSearch
            // 
            this.symbolSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolSearch.Location = new System.Drawing.Point(9, 62);
            this.symbolSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symbolSearch.Name = "symbolSearch";
            this.symbolSearch.Size = new System.Drawing.Size(283, 47);
            this.symbolSearch.TabIndex = 5;
            this.symbolSearch.TextChanged += new System.EventHandler(this.symbolSearch_TextChanged);
            // 
            // symbolList
            // 
            this.symbolList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbolList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolList.FormattingEnabled = true;
            this.symbolList.ItemHeight = 31;
            this.symbolList.Location = new System.Drawing.Point(9, 117);
            this.symbolList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symbolList.Name = "symbolList";
            this.symbolList.Size = new System.Drawing.Size(283, 376);
            this.symbolList.TabIndex = 4;
            this.symbolList.SelectedIndexChanged += new System.EventHandler(this.symbolList_SelectedIndexChanged);
            // 
            // randomButton
            // 
            this.randomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.randomButton.Location = new System.Drawing.Point(471, 337);
            this.randomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(155, 92);
            this.randomButton.TabIndex = 2;
            this.randomButton.Text = "Random Symbol";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(430, 218);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(268, 39);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Select a Symbol";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(2, 10);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(306, 39);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Try the symbol for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 616);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Teach ASL";
            this.ResizeEnd += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.learnPage.ResumeLayout(false);
            this.practicePage.ResumeLayout(false);
            this.practicePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button nextSymbol;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage learnPage;
        private System.Windows.Forms.TabPage practicePage;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox symbolSearch;
        private System.Windows.Forms.ListBox symbolList;
    }
}

