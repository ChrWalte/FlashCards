namespace FlashCards
{
    partial class PackSelectForm
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
            this.PackList = new System.Windows.Forms.ListBox();
            this.OpenPackButton = new System.Windows.Forms.Button();
            this.CreatePackButton = new System.Windows.Forms.Button();
            this.EditPackButton = new System.Windows.Forms.Button();
            this.DeletePack = new System.Windows.Forms.Button();
            this.BackUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PackList
            // 
            this.PackList.AccessibleName = "PackList";
            this.PackList.FormattingEnabled = true;
            this.PackList.ItemHeight = 16;
            this.PackList.Location = new System.Drawing.Point(12, 12);
            this.PackList.Name = "PackList";
            this.PackList.Size = new System.Drawing.Size(234, 356);
            this.PackList.Sorted = true;
            this.PackList.TabIndex = 0;
            this.PackList.Tag = "PackList";
            // 
            // OpenPackButton
            // 
            this.OpenPackButton.AccessibleName = "OpenPackButton";
            this.OpenPackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenPackButton.Location = new System.Drawing.Point(252, 74);
            this.OpenPackButton.Name = "OpenPackButton";
            this.OpenPackButton.Size = new System.Drawing.Size(119, 28);
            this.OpenPackButton.TabIndex = 1;
            this.OpenPackButton.Tag = "OpenPackButton";
            this.OpenPackButton.Text = "Open Pack";
            this.OpenPackButton.UseVisualStyleBackColor = true;
            this.OpenPackButton.Click += new System.EventHandler(this.OpenPackButton_Click);
            // 
            // CreatePackButton
            // 
            this.CreatePackButton.AccessibleName = "CreatePackButton";
            this.CreatePackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatePackButton.Location = new System.Drawing.Point(252, 108);
            this.CreatePackButton.Name = "CreatePackButton";
            this.CreatePackButton.Size = new System.Drawing.Size(119, 28);
            this.CreatePackButton.TabIndex = 2;
            this.CreatePackButton.Tag = "CreatePackButton";
            this.CreatePackButton.Text = "Create Pack";
            this.CreatePackButton.UseVisualStyleBackColor = true;
            this.CreatePackButton.Click += new System.EventHandler(this.CreatePackButton_Click);
            // 
            // EditPackButton
            // 
            this.EditPackButton.AccessibleName = "EditPackButton";
            this.EditPackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditPackButton.Location = new System.Drawing.Point(252, 142);
            this.EditPackButton.Name = "EditPackButton";
            this.EditPackButton.Size = new System.Drawing.Size(119, 28);
            this.EditPackButton.TabIndex = 3;
            this.EditPackButton.Tag = "EditPackButton";
            this.EditPackButton.Text = "Edit Pack";
            this.EditPackButton.UseVisualStyleBackColor = true;
            // 
            // DeletePack
            // 
            this.DeletePack.AccessibleName = "DeletePack";
            this.DeletePack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePack.Location = new System.Drawing.Point(252, 176);
            this.DeletePack.Name = "DeletePack";
            this.DeletePack.Size = new System.Drawing.Size(119, 28);
            this.DeletePack.TabIndex = 4;
            this.DeletePack.Tag = "DeletePack";
            this.DeletePack.Text = "Delete Pack";
            this.DeletePack.UseVisualStyleBackColor = true;
            this.DeletePack.Click += new System.EventHandler(this.DeletePack_Click);
            // 
            // BackUpButton
            // 
            this.BackUpButton.AccessibleName = "BackUpButton";
            this.BackUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackUpButton.Location = new System.Drawing.Point(252, 210);
            this.BackUpButton.Name = "BackUpButton";
            this.BackUpButton.Size = new System.Drawing.Size(119, 28);
            this.BackUpButton.TabIndex = 5;
            this.BackUpButton.Tag = "BackUpButton";
            this.BackUpButton.Text = "Backup Packs";
            this.BackUpButton.UseVisualStyleBackColor = true;
            // 
            // PackSelectForm
            // 
            this.AccessibleName = "PackSelectForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 378);
            this.Controls.Add(this.BackUpButton);
            this.Controls.Add(this.DeletePack);
            this.Controls.Add(this.EditPackButton);
            this.Controls.Add(this.CreatePackButton);
            this.Controls.Add(this.OpenPackButton);
            this.Controls.Add(this.PackList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PackSelectForm";
            this.Tag = "PackSelectForm";
            this.Text = "Pack Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PackList;
        private System.Windows.Forms.Button OpenPackButton;
        private System.Windows.Forms.Button CreatePackButton;
        private System.Windows.Forms.Button EditPackButton;
        private System.Windows.Forms.Button DeletePack;
        private System.Windows.Forms.Button BackUpButton;
    }
}

