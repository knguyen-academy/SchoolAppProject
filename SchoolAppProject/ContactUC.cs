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
    public partial class ContactUC : UserControl
    {
        private static ContactUC _instance;
        public static ContactUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContactUC();
                return _instance;
            }
           
        }
        public ContactUC()
        {
            InitializeComponent();
        }
    }
}


