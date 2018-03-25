﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppProject
{
    public partial class Album_UC : UserControl
    {
        private int  holdindex;
        private int  photo_index = 1;
        private static Album_UC _instance;

        public static Album_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Album_UC();
                return _instance;
            }
        }

        public string AlbumLabel
        {
            get { return Album_label.Text; }
            set { Album_label.Text = value; }
        }

        public Album_UC()
        {
            InitializeComponent();
           // ListAlbumPhotos();

        }

<<<<<<< HEAD
        private void SelectAlbumPath()
        {
            if (Album_label.Text == "JAPAN ALBUM")
                albumPath = "../../Images/Japan";

            if (Album_label.Text == "CANADA ALBUM")
                albumPath = "../../Images/Canada";

            if (Album_label.Text == "VIETNAM ALBUM")
                albumPath = "../../Images/Vietnam";

            if (Album_label.Text == "NEWYORK ALBUM")
                albumPath = "../../Images/Newyork";

            if (Album_label.Text == "LA ALBUM")
                albumPath = "../../Images/LA";
        }
        private string temp;
        private void DisplayAllPhotos()
        {
            string[] files = Directory.GetFiles(albumPath);

            //foreach (string filename in files)
            //{

            //    PictureBox p1 = new PictureBox();
            //    p1.Size = new Size(120, 90);
            //    p1.Image = Image.FromFile(filename);
            //    p1.SizeMode = PictureBoxSizeMode.StretchImage;
            //    Photoleft_panel.Controls.Add(p1);
            //    p1.Click += P1_Click;
            //}
            //int i = 0;

            foreach (string filename in files)
            {
                for (int i = 0; i < 5; i++)
                {
                    temp = filename;

                    PictureBox[] p = new PictureBox[5];
                    p[i] = new PictureBox();
                    p[i].Size = new Size(120, 90);
                    p[i].Image = Image.FromFile(filename);

                    p[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    Photoleft_panel.Controls.Add(p[i]);
                    p[i].Click += P1_Click;

                }
            }

        }

        private void P1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(temp);
            //SelectAlbum();
        }
    
        private void ListAlbumPhotos()
=======
        private void ListAlbumPhotos()
        {
            for (int i = 1; i < 5; i++)
            {
                PictureBox p1 = new PictureBox();
                p1.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", i);
                p1.SizeMode = PictureBoxSizeMode.Zoom;
                Photoleft_panel.Controls.Add(p1);
                p1.Click += P1_Click;
                holdindex = i;
                //p1.Margin = new Padding(0);

            }


      
        }

        private void P1_Click(object sender, EventArgs e)
>>>>>>> parent of 7c47611... Travel button
        {

            //MessageBox.Show("hele");
            Slider_pictureBox.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", holdindex);
        }

        private void SelectAlbum()
        {
            if (Album_label.Text == "JAPAN ALBUM")
            {
                Slider_pictureBox.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", photo_index);
            }

            if (Album_label.Text == "CANADA ALBUM")
            {
                Slider_pictureBox.ImageLocation = string.Format(@"CanadaPhotos\{0}.jpg", photo_index);
            }

            if (Album_label.Text == "VIETNAM ALBUM")
            {
                Slider_pictureBox.ImageLocation = string.Format(@"VietnamPhotos\{0}.jpg", photo_index);
            }

            if (Album_label.Text == "NEWYORK ALBUM")
            {
                Slider_pictureBox.ImageLocation = string.Format(@"NewYorkPhotos\{0}.jpg", photo_index);
            }

            if (Album_label.Text == "LA ALBUM")
            {
                Slider_pictureBox.ImageLocation = string.Format(@"LAPhotos\{0}.jpg", photo_index);
            }
        }


        public void PicturesLoad()
        {

            if (photo_index == 4)
                photo_index = 1;
            photo_index++;

            SelectAlbum();

        }

        private void SlideShow_button_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;             // Timer will tick evert 0.5 seconds
            //timer1.Enabled = true;             // Enable the timer
            timer1.Start();                     //Fire up timer1_Tick function()
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicturesLoad();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            
            if (photo_index == 1)
                photo_index = 4;
            photo_index--;
            SelectAlbum();
           
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (photo_index == 4)
                photo_index = 1;
            photo_index++;
            SelectAlbum();
         
        }

        private void Slider_pictureBox_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
