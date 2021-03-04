namespace FlashCards
{
    partial class OpenPack
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
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PreviousCardButton = new System.Windows.Forms.Button();
            this.NextCardButton = new System.Windows.Forms.Button();
            this.ShowHideDescriptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordTextBox
            // 
            this.WordTextBox.AccessibleName = "WordTextBox";
            this.WordTextBox.Location = new System.Drawing.Point(12, 12);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.ReadOnly = true;
            this.WordTextBox.Size = new System.Drawing.Size(554, 22);
            this.WordTextBox.TabIndex = 0;
            this.WordTextBox.Tag = "WordTextBox";
            this.WordTextBox.Text = "Word";
            this.WordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AccessibleName = "DescriptionTextBox";
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 40);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(554, 254);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.Tag = "DescriptionTextBox";
            this.DescriptionTextBox.Text = "Description";
            this.DescriptionTextBox.Visible = false;
            // 
            // PreviousCardButton
            // 
            this.PreviousCardButton.AccessibleName = "PreviousCardButton";
            this.PreviousCardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousCardButton.Location = new System.Drawing.Point(12, 300);
            this.PreviousCardButton.Name = "PreviousCardButton";
            this.PreviousCardButton.Size = new System.Drawing.Size(127, 29);
            this.PreviousCardButton.TabIndex = 2;
            this.PreviousCardButton.Tag = "PreviousCardButton";
            this.PreviousCardButton.Text = "Previous Card";
            this.PreviousCardButton.UseVisualStyleBackColor = true;
            this.PreviousCardButton.Click += new System.EventHandler(this.PreviousCardButton_Click);
            // 
            // NextCardButton
            // 
            this.NextCardButton.AccessibleName = "NextCardButton";
            this.NextCardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextCardButton.Location = new System.Drawing.Point(439, 300);
            this.NextCardButton.Name = "NextCardButton";
            this.NextCardButton.Size = new System.Drawing.Size(127, 29);
            this.NextCardButton.TabIndex = 3;
            this.NextCardButton.Tag = "NextCardButton";
            this.NextCardButton.Text = "Next Card";
            this.NextCardButton.UseVisualStyleBackColor = true;
            this.NextCardButton.Click += new System.EventHandler(this.NextCardButton_Click);
            // 
            // ShowHideDescriptionButton
            // 
            this.ShowHideDescriptionButton.AccessibleName = "ShowHideDescriptionButton";
            this.ShowHideDescriptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowHideDescriptionButton.Location = new System.Drawing.Point(206, 300);
            this.ShowHideDescriptionButton.Name = "ShowHideDescriptionButton";
            this.ShowHideDescriptionButton.Size = new System.Drawing.Size(167, 29);
            this.ShowHideDescriptionButton.TabIndex = 4;
            this.ShowHideDescriptionButton.Tag = "ShowHideDescriptionButton";
            this.ShowHideDescriptionButton.Text = "Show Description";
            this.ShowHideDescriptionButton.UseVisualStyleBackColor = true;
            this.ShowHideDescriptionButton.Click += new System.EventHandler(this.ShowHideDescriptionButton_Click);
            // 
            // OpenPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 341);
            this.Controls.Add(this.ShowHideDescriptionButton);
            this.Controls.Add(this.NextCardButton);
            this.Controls.Add(this.PreviousCardButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.WordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OpenPack";
            this.Text = "Pack Name";
            this.Load += new System.EventHandler(this.OpenPack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button PreviousCardButton;
        private System.Windows.Forms.Button NextCardButton;
        private System.Windows.Forms.Button ShowHideDescriptionButton;
    }
}