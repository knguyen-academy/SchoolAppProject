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
    public partial class TravelPhotoUserControl : UserControl
    {

        
        public TravelPhotoUserControl()
        {
            InitializeComponent();
        }
        
        public string DestinationLabel
        {
            get { return Destination_label.Text; }
            set { Destination_label.Text = value; }
        }

        public string DateLabel
        {
            get { return Date_label.Text; }
            set { Date_label.Text = value; }
        }
        public string NumberLabel
        {
            get { return Number_label.Text; }
            set { Number_label.Text = value; }
        }

        public Image PostImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            AlbumUserControl.Instance.BringToFront();
            //MessageBox.Show(DestinationLabel);
            //AlbumUserControl a1 = new AlbumUserControl();
            //a1.BringToFront();
            //TravelUserControl i1 = new TravelUserControl();
            

        }
    }
}
