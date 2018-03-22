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
        }


        
        private void Back_button_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}
