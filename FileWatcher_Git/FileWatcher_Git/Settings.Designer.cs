namespace FileWatcher_Git
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameAddButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DirectoryAddButton = new System.Windows.Forms.Button();
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DirectoryComboBox = new System.Windows.Forms.ComboBox();
            this.DirectoryTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name Format";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(138, 151);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(457, 20);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // FileNameAddButton
            // 
            this.FileNameAddButton.Location = new System.Drawing.Point(622, 149);
            this.FileNameAddButton.Name = "FileNameAddButton";
            this.FileNameAddButton.Size = new System.Drawing.Size(75, 23);
            this.FileNameAddButton.TabIndex = 3;
            this.FileNameAddButton.Text = "Add";
            this.FileNameAddButton.UseVisualStyleBackColor = true;
            this.FileNameAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(622, 420);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(622, 462);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(622, 367);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 25);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // DirectoryAddButton
            // 
            this.DirectoryAddButton.Location = new System.Drawing.Point(622, 46);
            this.DirectoryAddButton.Name = "DirectoryAddButton";
            this.DirectoryAddButton.Size = new System.Drawing.Size(75, 23);
            this.DirectoryAddButton.TabIndex = 12;
            this.DirectoryAddButton.Text = "Add";
            this.DirectoryAddButton.UseVisualStyleBackColor = true;
            this.DirectoryAddButton.Click += new System.EventHandler(this.DirectoryAddButton_Click);
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Location = new System.Drawing.Point(138, 49);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(457, 20);
            this.DirectoryTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Directory";
            // 
            // DirectoryComboBox
            // 
            this.DirectoryComboBox.FormattingEnabled = true;
            this.DirectoryComboBox.Location = new System.Drawing.Point(138, 102);
            this.DirectoryComboBox.Name = "DirectoryComboBox";
            this.DirectoryComboBox.Size = new System.Drawing.Size(457, 21);
            this.DirectoryComboBox.TabIndex = 16;
            // 
            // DirectoryTreeView
            // 
            this.DirectoryTreeView.Location = new System.Drawing.Point(34, 192);
            this.DirectoryTreeView.Name = "DirectoryTreeView";
            this.DirectoryTreeView.Size = new System.Drawing.Size(561, 293);
            this.DirectoryTreeView.TabIndex = 17;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.DirectoryTreeView);
            this.Controls.Add(this.DirectoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoryAddButton);
            this.Controls.Add(this.DirectoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FileNameAddButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button FileNameAddButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button DirectoryAddButton;
        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DirectoryComboBox;
        private System.Windows.Forms.TreeView DirectoryTreeView;
    }
}

