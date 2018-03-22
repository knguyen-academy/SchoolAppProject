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
    public partial class Education_UC : UserControl
    {
        private static Education_UC _instance;
        public static Education_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Education_UC();
                return _instance;
            }
        }
        public Education_UC()
        {
            InitializeComponent();
        }
    }
}


