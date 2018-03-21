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
    public partial class AboutMe_UserControl : UserControl
    {
        private static AboutMe_UserControl _instance;

        public static AboutMe_UserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AboutMe_UserControl();
                return _instance;
            }
        }

        public AboutMe_UserControl()
        {
            InitializeComponent();
        }

    }
}
