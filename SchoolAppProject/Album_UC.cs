using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolAppProject
{
    public partial class Album_UC : UserControl
    {
       
        private int  photo_index = 1;
        private string albumPath;
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

        }


        //Select Album path for list all photos
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

        //Retrive all photos within each folder based on Album path
        private void DisplayAllPhotos()
        {
            string[] files = Directory.GetFiles(albumPath);
            foreach (string filename in files)
            {
                MessageBox.Show(filename);
                PictureBox p1 = new PictureBox();
                p1.Image = Image.FromFile(filename);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                p1.Size = new Size(150, 90);
                Photoleft_panel.Controls.Add(p1);
            }
        }

        //List all photos
        private void showall_button_Click(object sender, EventArgs e)
        {
            if (Photoleft_panel.Controls.Count == 0)
            {
                
                SelectAlbumPath();  // Find the path of the album
                DisplayAllPhotos(); //Show all photos
            }
            


        }

        private void P1_Click(object sender, EventArgs e)
        { 
        }

        //Select Album for slideshow
        private void SelectAlbum()
        {
            if (Album_label.Text == "JAPAN ALBUM")
                Slider_pictureBox.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", photo_index);

            if (Album_label.Text == "CANADA ALBUM")
                Slider_pictureBox.ImageLocation = string.Format(@"CanadaPhotos\{0}.jpg", photo_index);
            
            if (Album_label.Text == "VIETNAM ALBUM")
                Slider_pictureBox.ImageLocation = string.Format(@"VietnamPhotos\{0}.jpg", photo_index);

            if (Album_label.Text == "NEWYORK ALBUM")
                Slider_pictureBox.ImageLocation = string.Format(@"NewYorkPhotos\{0}.jpg", photo_index);
            
            if (Album_label.Text == "LA ALBUM")
                Slider_pictureBox.ImageLocation = string.Format(@"LAPhotos\{0}.jpg", photo_index);
        }

        //Slide Show used for Timer.Tick
        public void PicturesLoad()
        {

            if (photo_index == 4)
                photo_index = 1;
            photo_index++;

            SelectAlbum();

        }

        //Start timer
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
                photo_index = 5;
            photo_index--;
            SelectAlbum();
           
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (photo_index == 4)
                photo_index = 0;
            photo_index++;
            SelectAlbum();
         
        }

        private void Slider_pictureBox_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


    }
}
