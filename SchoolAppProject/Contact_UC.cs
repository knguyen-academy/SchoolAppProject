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
    public partial class Contact_UC : UserControl
    {
        private static Contact_UC _instance;
        public static Contact_UC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Contact_UC();
                return _instance;
            }
           
        }
        public Contact_UC()
        {
            InitializeComponent();
        }
    }
}


