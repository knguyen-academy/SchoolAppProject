namespace SchoolAppProject
{
    partial class Album_UC
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
            this.components = new System.ComponentModel.Container();
            this.Mid_panel = new System.Windows.Forms.Panel();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Next_button = new System.Windows.Forms.Button();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Slider_pictureBox = new System.Windows.Forms.PictureBox();
            this.Album_label = new System.Windows.Forms.Label();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Back_button = new System.Windows.Forms.Button();
            this.Left_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_pictureBox)).BeginInit();
            this.Top_panel.SuspendLayout();
            this.Left_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_panel
            // 
            this.Mid_panel.Controls.Add(this.Bottom_panel);
            this.Mid_panel.Controls.Add(this.Next_button);
            this.Mid_panel.Controls.Add(this.Previous_button);
            this.Mid_panel.Controls.Add(this.Slider_pictureBox);
            this.Mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_panel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid_panel.Location = new System.Drawing.Point(70, 57);
            this.Mid_panel.Name = "Mid_panel";
            this.Mid_panel.Size = new System.Drawing.Size(1044, 467);
            this.Mid_panel.TabIndex = 13;
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 393);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(1044, 74);
            this.Bottom_panel.TabIndex = 2;
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(978, 154);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(41, 30);
            this.Next_button.TabIndex = 0;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Previous_button
            // 
            this.Previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Previous_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_button.Location = new System.Drawing.Point(6, 154);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(25, 30);
            this.Previous_button.TabIndex = 0;
            this.Previous_button.Text = "Previous";
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Slider_pictureBox
            // 
            this.Slider_pictureBox.Image = global::SchoolAppProject.Properties.Resources.Japan;
            this.Slider_pictureBox.Location = new System.Drawing.Point(225, 6);
            this.Slider_pictureBox.Name = "Slider_pictureBox";
            this.Slider_pictureBox.Size = new System.Drawing.Size(646, 381);
            this.Slider_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Slider_pictureBox.TabIndex = 1;
            this.Slider_pictureBox.TabStop = false;
            // 
            // Album_label
            // 
            this.Album_label.AutoSize = true;
            this.Album_label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album_label.Location = new System.Drawing.Point(-4, 3);
            this.Album_label.Name = "Album_label";
            this.Album_label.Size = new System.Drawing.Size(269, 36);
            this.Album_label.TabIndex = 0;
            this.Album_label.Text = "AlbumUserControl";
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.Album_label);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_panel.Location = new System.Drawing.Point(70, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1044, 57);
            this.Top_panel.TabIndex = 12;
            // 
            // Back_button
            // 
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(3, 3);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(53, 30);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.Back_button);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(70, 524);
            this.Left_Panel.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Album_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Mid_panel);
            this.Controls.Add(this.Top_panel);
            this.Controls.Add(this.Left_Panel);
            this.Name = "Album_UC";
            this.Size = new System.Drawing.Size(1114, 524);
            this.Mid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Slider_pictureBox)).EndInit();
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.Left_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_panel;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.PictureBox Slider_pictureBox;
        private System.Windows.Forms.Label Album_label;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.FlowLayoutPanel Left_Panel;
        private System.Windows.Forms.Timer timer1;

    }
}
