namespace teach_asl_cs
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(12, 606);
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
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1455, 588);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // nextSymbol
            // 
            this.nextSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextSymbol.Location = new System.Drawing.Point(1115, 606);
            this.nextSymbol.Name = "nextSymbol";
            this.nextSymbol.Size = new System.Drawing.Size(352, 146);
            this.nextSymbol.TabIndex = 4;
            this.nextSymbol.Text = "Next Symbol";
            this.nextSymbol.UseVisualStyleBackColor = true;
            this.nextSymbol.Click += new System.EventHandler(this.nextSymbol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 764);
            this.Controls.Add(this.nextSymbol);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.previousButton);
            this.Name = "Form1";
            this.Text = "Teach ASL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button nextSymbol;
    }
}

