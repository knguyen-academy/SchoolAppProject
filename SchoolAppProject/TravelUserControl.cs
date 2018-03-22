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
    public partial class TravelUserControl : UserControl
    {
        //Private instance/object so that we don't have to declare everytime
        private static TravelUserControl _instance;

        //public function to get an object
        public static TravelUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TravelUserControl();
                return _instance;
            }
        }

        public TravelUserControl()
        {
            
            InitializeComponent();
            AddUsercontrol();
        }

        public void AddUsercontrol()
        {
            TravelPhotoUserControl uc1 = new TravelPhotoUserControl();
            uc1.DestinationLabel = "JAPAN";
            uc1.DateLabel = "2017-08";
            uc1.NumberLabel = "0";
            uc1.PostImage = Properties.Resources.Japan;
            Photo_Panel.Controls.Add(uc1);

            TravelPhotoUserControl uc2 = new TravelPhotoUserControl();
            uc2.DestinationLabel = "CANADA";
            uc2.DateLabel = "2018-02";
            uc2.NumberLabel = "0";
            uc2.PostImage = Properties.Resources.Canada;
            Photo_Panel.Controls.Add(uc2);
            

            TravelPhotoUserControl uc3 = new TravelPhotoUserControl();
            uc3.DestinationLabel = "VIETNAM";
            uc3.DateLabel = "2016-06";
            uc3.NumberLabel = "0";
            uc3.PostImage = Properties.Resources.Vietnam;
            Photo_Panel.Controls.Add(uc3);

            TravelPhotoUserControl uc4 = new TravelPhotoUserControl();
            uc4.DestinationLabel = "NEWYORK";
            uc4.DateLabel = "2018-02";
            uc4.NumberLabel = "0";
            uc4.PostImage = Properties.Resources.Us;
            Photo_Panel.Controls.Add(uc4);

            TravelPhotoUserControl uc5 = new TravelPhotoUserControl();
            uc5.DestinationLabel = "LA";
            uc5.DateLabel = "2018-02";
            uc5.NumberLabel = "0";
            uc5.PostImage = Properties.Resources.LA;
            Photo_Panel.Controls.Add(uc5);


            

        }

 
    }
}
