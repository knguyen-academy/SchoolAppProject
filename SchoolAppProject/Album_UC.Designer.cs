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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Album_UC));
            this.Mid_panel = new System.Windows.Forms.Panel();
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.Bottom_panel = new System.Windows.Forms.Panel();
            this.Slider_pictureBox = new System.Windows.Forms.PictureBox();
            this.SlideShow_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Album_label = new System.Windows.Forms.Label();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.Left_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Photoleft_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_pictureBox)).BeginInit();
            this.Top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_panel
            // 
            this.Mid_panel.Controls.Add(this.Photoleft_panel);
            this.Mid_panel.Controls.Add(this.next_button);
            this.Mid_panel.Controls.Add(this.previous_button);
            this.Mid_panel.Controls.Add(this.Bottom_panel);
            this.Mid_panel.Controls.Add(this.Slider_pictureBox);
            this.Mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_panel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mid_panel.Location = new System.Drawing.Point(70, 57);
            this.Mid_panel.Name = "Mid_panel";
            this.Mid_panel.Size = new System.Drawing.Size(1044, 467);
            this.Mid_panel.TabIndex = 13;
            // 
            // next_button
            // 
            this.next_button.FlatAppearance.BorderSize = 0;
            this.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.Color.White;
            this.next_button.Image = ((System.Drawing.Image)(resources.GetObject("next_button.Image")));
            this.next_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next_button.Location = new System.Drawing.Point(963, 194);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(38, 45);
            this.next_button.TabIndex = 5;
            this.next_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.FlatAppearance.BorderSize = 0;
            this.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_button.ForeColor = System.Drawing.Color.White;
            this.previous_button.Image = ((System.Drawing.Image)(resources.GetObject("previous_button.Image")));
            this.previous_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.previous_button.Location = new System.Drawing.Point(963, 143);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(38, 45);
            this.previous_button.TabIndex = 5;
            this.previous_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // Bottom_panel
            // 
            this.Bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_panel.Location = new System.Drawing.Point(0, 393);
            this.Bottom_panel.Name = "Bottom_panel";
            this.Bottom_panel.Size = new System.Drawing.Size(1044, 74);
            this.Bottom_panel.TabIndex = 2;
            // 
            // Slider_pictureBox
            // 
            this.Slider_pictureBox.Image = global::SchoolAppProject.Properties.Resources.Japan;
            this.Slider_pictureBox.Location = new System.Drawing.Point(133, 6);
            this.Slider_pictureBox.Name = "Slider_pictureBox";
            this.Slider_pictureBox.Size = new System.Drawing.Size(824, 381);
            this.Slider_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Slider_pictureBox.TabIndex = 1;
            this.Slider_pictureBox.TabStop = false;
            this.Slider_pictureBox.Click += new System.EventHandler(this.Slider_pictureBox_Click);
            // 
            // SlideShow_button
            // 
            this.SlideShow_button.FlatAppearance.BorderSize = 0;
            this.SlideShow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideShow_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideShow_button.ForeColor = System.Drawing.Color.White;
            this.SlideShow_button.Image = ((System.Drawing.Image)(resources.GetObject("SlideShow_button.Image")));
            this.SlideShow_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlideShow_button.Location = new System.Drawing.Point(341, 6);
            this.SlideShow_button.Name = "SlideShow_button";
            this.SlideShow_button.Size = new System.Drawing.Size(35, 45);
            this.SlideShow_button.TabIndex = 5;
            this.SlideShow_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SlideShow_button.UseVisualStyleBackColor = true;
            this.SlideShow_button.Click += new System.EventHandler(this.SlideShow_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.FlatAppearance.BorderSize = 0;
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.White;
            this.Back_button.Image = ((System.Drawing.Image)(resources.GetObject("Back_button.Image")));
            this.Back_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Back_button.Location = new System.Drawing.Point(991, 5);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(38, 45);
            this.Back_button.TabIndex = 4;
            this.Back_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Album_label
            // 
            this.Album_label.AutoSize = true;
            this.Album_label.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Album_label.Location = new System.Drawing.Point(382, 10);
            this.Album_label.Name = "Album_label";
            this.Album_label.Size = new System.Drawing.Size(269, 36);
            this.Album_label.TabIndex = 0;
            this.Album_label.Text = "AlbumUserControl";
            this.Album_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Top_panel
            // 
            this.Top_panel.Controls.Add(this.SlideShow_button);
            this.Top_panel.Controls.Add(this.Back_button);
            this.Top_panel.Controls.Add(this.Album_label);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_panel.Location = new System.Drawing.Point(70, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1044, 57);
            this.Top_panel.TabIndex = 12;
            // 
            // Left_Panel
            // 
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
            // Photoleft_panel
            // 
            this.Photoleft_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Photoleft_panel.Location = new System.Drawing.Point(7, 7);
            this.Photoleft_panel.Name = "Photoleft_panel";
            this.Photoleft_panel.Size = new System.Drawing.Size(120, 380);
            this.Photoleft_panel.TabIndex = 6;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_panel;
        private System.Windows.Forms.PictureBox Slider_pictureBox;
        private System.Windows.Forms.Label Album_label;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel Bottom_panel;
        private System.Windows.Forms.FlowLayoutPanel Left_Panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button SlideShow_button;
        private System.Windows.Forms.FlowLayoutPanel Photoleft_panel;
    }
}
