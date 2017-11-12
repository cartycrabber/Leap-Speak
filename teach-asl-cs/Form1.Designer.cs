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
            this.randomButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.symbolList = new System.Windows.Forms.ListBox();
            this.symbolSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.learnPage.SuspendLayout();
            this.practicePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(6, 530);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(386, 146);
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
            this.pictureBox.Location = new System.Drawing.Point(6, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1423, 518);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // nextSymbol
            // 
            this.nextSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextSymbol.Location = new System.Drawing.Point(1080, 530);
            this.nextSymbol.Name = "nextSymbol";
            this.nextSymbol.Size = new System.Drawing.Size(352, 146);
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
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1455, 740);
            this.tabControl.TabIndex = 5;
            // 
            // learnPage
            // 
            this.learnPage.Controls.Add(this.pictureBox);
            this.learnPage.Controls.Add(this.nextSymbol);
            this.learnPage.Controls.Add(this.previousButton);
            this.learnPage.Location = new System.Drawing.Point(10, 48);
            this.learnPage.Name = "learnPage";
            this.learnPage.Padding = new System.Windows.Forms.Padding(3);
            this.learnPage.Size = new System.Drawing.Size(1435, 682);
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
            this.practicePage.Location = new System.Drawing.Point(10, 48);
            this.practicePage.Name = "practicePage";
            this.practicePage.Padding = new System.Windows.Forms.Padding(3);
            this.practicePage.Size = new System.Drawing.Size(1435, 682);
            this.practicePage.TabIndex = 1;
            this.practicePage.Text = "Practice";
            this.practicePage.UseVisualStyleBackColor = true;
            // 
            // randomButton
            // 
            this.randomButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.randomButton.Location = new System.Drawing.Point(601, 431);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(207, 114);
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
            this.statusLabel.Location = new System.Drawing.Point(574, 270);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(338, 52);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Select a Symbol";
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(3, 12);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(385, 52);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Try the symbol for:";
            // 
            // symbolList
            // 
            this.symbolList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.symbolList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolList.FormattingEnabled = true;
            this.symbolList.ItemHeight = 38;
            this.symbolList.Location = new System.Drawing.Point(12, 145);
            this.symbolList.Name = "symbolList";
            this.symbolList.Size = new System.Drawing.Size(376, 498);
            this.symbolList.TabIndex = 4;
            this.symbolList.SelectedIndexChanged += new System.EventHandler(this.symbolList_SelectedIndexChanged);
            // 
            // symbolSearch
            // 
            this.symbolSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolSearch.Location = new System.Drawing.Point(12, 77);
            this.symbolSearch.Name = "symbolSearch";
            this.symbolSearch.Size = new System.Drawing.Size(376, 57);
            this.symbolSearch.TabIndex = 5;
            this.symbolSearch.TextChanged += new System.EventHandler(this.symbolSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 764);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Teach ASL";
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

