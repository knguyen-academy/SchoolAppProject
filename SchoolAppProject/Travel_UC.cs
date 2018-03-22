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
    public partial class Travel_UC : UserControl
    {
        //Private instance/object so that we don't have to declare everytime
        private static Travel_UC _instance;

        //public function to get an object
        public static Travel_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Travel_UC();
                return _instance;
            }
        }

        public Travel_UC()
        {
            
            InitializeComponent();
            AddUsercontrol();
        }

        public void AddUsercontrol()
        {
            Destination_UC uc1 = new Destination_UC();
            uc1.DestinationLabel = "JAPAN";
            uc1.DateLabel = "2017-08";
            uc1.NumberLabel = "0";
            uc1.PostImage = Properties.Resources.Japan;
            Photo_Panel.Controls.Add(uc1);

            Destination_UC uc2 = new Destination_UC();
            uc2.DestinationLabel = "CANADA";
            uc2.DateLabel = "2018-02";
            uc2.NumberLabel = "0";
            uc2.PostImage = Properties.Resources.Canada;
            Photo_Panel.Controls.Add(uc2);
            

            Destination_UC uc3 = new Destination_UC();
            uc3.DestinationLabel = "VIETNAM";
            uc3.DateLabel = "2016-06";
            uc3.NumberLabel = "0";
            uc3.PostImage = Properties.Resources.Vietnam;
            Photo_Panel.Controls.Add(uc3);

            Destination_UC uc4 = new Destination_UC();
            uc4.DestinationLabel = "NEWYORK";
            uc4.DateLabel = "2018-02";
            uc4.NumberLabel = "0";
            uc4.PostImage = Properties.Resources.Us;
            Photo_Panel.Controls.Add(uc4);

            Destination_UC uc5 = new Destination_UC();
            uc5.DestinationLabel = "LA";
            uc5.DateLabel = "2018-02";
            uc5.NumberLabel = "0";
            uc5.PostImage = Properties.Resources.LA;
            Photo_Panel.Controls.Add(uc5);


            

        }

 
    }
}
