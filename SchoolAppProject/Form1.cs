using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Aboutme_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Aboutme_button.Height;
            SidePanel.Top = Aboutme_button.Top;
            aboutMe_UserControl1.BringToFront();
        }

        private void Education_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Education_button.Height;
            SidePanel.Top = Education_button.Top;
            education_UserControl1.BringToFront();
        }
    }
}
