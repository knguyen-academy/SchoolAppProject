namespace SchoolAppProject
{
    partial class TravelPhotoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelPhotoUserControl));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Destination_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.Number_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(241, 211);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Destination_label
            // 
            this.Destination_label.AutoSize = true;
            this.Destination_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination_label.Location = new System.Drawing.Point(14, 211);
            this.Destination_label.Name = "Destination_label";
            this.Destination_label.Size = new System.Drawing.Size(93, 19);
            this.Destination_label.TabIndex = 1;
            this.Destination_label.Text = "Destination";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.Location = new System.Drawing.Point(14, 230);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(45, 20);
            this.Date_label.TabIndex = 2;
            this.Date_label.Text = "Date";
            // 
            // Number_label
            // 
            this.Number_label.AutoSize = true;
            this.Number_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_label.Location = new System.Drawing.Point(14, 250);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(73, 20);
            this.Number_label.TabIndex = 3;
            this.Number_label.Text = "Numbers";
            // 
            // TravelPhotoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Number_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Destination_label);
            this.Controls.Add(this.pictureBox);
            this.Name = "TravelPhotoUserControl";
            this.Size = new System.Drawing.Size(241, 275);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Destination_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Number_label;
    }
}
