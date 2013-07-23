namespace FileWatcher_Git
{
    partial class Home
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
            this.FileTable = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FileTable)).BeginInit();
            this.SuspendLayout();
            // 
            // FileTable
            // 
            this.FileTable.AllowUserToAddRows = false;
            this.FileTable.AllowUserToDeleteRows = false;
            this.FileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileTable.Location = new System.Drawing.Point(12, 12);
            this.FileTable.Name = "FileTable";
            this.FileTable.ReadOnly = true;
            this.FileTable.Size = new System.Drawing.Size(240, 150);
            this.FileTable.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(294, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(416, 68);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 199);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FileTable);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.FileTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FileTable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SettingsButton;
    }
}