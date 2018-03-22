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
    public partial class Destination_UC : UserControl
    {
       
        private static Destination_UC _instance;
        public static Destination_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Destination_UC();
                return _instance;
            }
        }
        public Destination_UC()
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
          
            if (DestinationLabel == "JAPAN")
            {
                Album_UC uc1 = new Album_UC();
                uc1.AlbumLabel = "JAPAN ALBUM";
                Travel_UC.Instance.Controls.Add(uc1);
                uc1.BringToFront();
            }

            if (DestinationLabel == "CANADA")
            {
                Album_UC uc2 = new Album_UC();
                uc2.AlbumLabel = "CANADA ALBUM";
                Travel_UC.Instance.Controls.Add(uc2);
                uc2.BringToFront();
            }

            if (DestinationLabel == "VIETNAM")
            {
                Album_UC uc3 = new Album_UC();
                uc3.AlbumLabel = "VIETNAM ALBUM";
                Travel_UC.Instance.Controls.Add(uc3);
                uc3.BringToFront();
            }

            if (DestinationLabel == "NEWYORK")
            {
                Album_UC uc4 = new Album_UC();
                uc4.AlbumLabel = "NEWYORK ALBUM";
                Travel_UC.Instance.Controls.Add(uc4);
                uc4.BringToFront();
            }

            if (DestinationLabel == "LA")
            {
                Album_UC uc5 = new Album_UC();
                uc5.AlbumLabel = "LA ALBUM";
                Travel_UC.Instance.Controls.Add(uc5);
                uc5.BringToFront();
            }

        }
    }
}
