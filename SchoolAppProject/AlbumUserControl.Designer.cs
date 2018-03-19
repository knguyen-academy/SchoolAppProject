namespace SchoolAppProject
{
    partial class AlbumUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Album = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Location = new System.Drawing.Point(148, 97);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(36, 13);
            this.Album.TabIndex = 0;
            this.Album.Text = "Album";
            // 
            // AlbumUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Album);
            this.Name = "AlbumUserControl";
            this.Size = new System.Drawing.Size(1114, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Album;
    }
}
