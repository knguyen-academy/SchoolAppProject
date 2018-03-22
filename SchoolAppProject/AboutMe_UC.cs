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
    public partial class AboutMe_UC : UserControl
    {
        private static AboutMe_UC _instance;

        public static AboutMe_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AboutMe_UC();
                return _instance;
            }
        }

        public AboutMe_UC()
        {
            InitializeComponent();
        }

    }
}
