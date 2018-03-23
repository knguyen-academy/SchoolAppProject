using System;
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
            //PicturesLoad();
            //timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 700;             // Timer will tick evert 10 seconds
            //timer1.Enabled = true;                       // Enable the timer
            timer1.Start();                              // Start the timer
        }
        private int i=1;
        public void PicturesLoad()
        {
            //Slider_pictureBox.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", 1);
            //MessageBox.Show(i.ToString());

            if (i == 4)
              i = 1;

            Slider_pictureBox.ImageLocation = string.Format(@"JapanPhotos\{0}.jpg", i);
            i++;


        }
        
      
        private void Back_button_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PicturesLoad();
        }
    }
}
