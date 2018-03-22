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
    public partial class AlbumUserControl : UserControl
    {


        private static AlbumUserControl _instance;

        public static AlbumUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AlbumUserControl();
                return _instance;
            }
        }

        public string AlbumLabel
        {
            get { return Album_label.Text; }
            set { Album_label.Text = value; }
        }

        public AlbumUserControl()
        {
            InitializeComponent();
        }


        
        private void Back_button_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
