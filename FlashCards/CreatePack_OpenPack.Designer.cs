namespace FlashCards
{
    partial class CreatePackOpenPack
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
            this.CardDataTable = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CardDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CardDataTable
            // 
            this.CardDataTable.AccessibleName = "CardDataTable";
            this.CardDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Description});
            this.CardDataTable.Location = new System.Drawing.Point(12, 12);
            this.CardDataTable.Name = "CardDataTable";
            this.CardDataTable.RowTemplate.Height = 24;
            this.CardDataTable.Size = new System.Drawing.Size(553, 300);
            this.CardDataTable.TabIndex = 0;
            this.CardDataTable.Tag = "CardDataTable";
            // 
            // Word
            // 
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 246;
            // 
            // PackNameTextBox
            // 
            this.PackNameTextBox.AccessibleName = "PackNameTextBox";
            this.PackNameTextBox.Location = new System.Drawing.Point(12, 323);
            this.PackNameTextBox.Name = "PackNameTextBox";
            this.PackNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.PackNameTextBox.TabIndex = 1;
            this.PackNameTextBox.Tag = "PackNameTextBox";
            // 
            // CancelButton
            // 
            this.CancelButton.AccessibleName = "CancelButton";
            this.CancelButton.Location = new System.Drawing.Point(390, 321);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(175, 26);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Tag = "CancelButton";
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AccessibleName = "SaveButton";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Location = new System.Drawing.Point(209, 321);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 26);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Tag = "SaveButton";
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreatePackOpenPack
            // 
            this.AccessibleName = "CreatePackOpenPack";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 352);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PackNameTextBox);
            this.Controls.Add(this.CardDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreatePackOpenPack";
            this.Tag = "CreatePackOpenPack";
            this.Text = "CreatePack_OpenPack";
            this.Load += new System.EventHandler(this.CreatePackOpenPack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CardDataTable;
        private System.Windows.Forms.TextBox PackNameTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}