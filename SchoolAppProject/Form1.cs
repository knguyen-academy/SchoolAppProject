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

            //event handler for quote 
            Quote_label.MouseEnter += OnMouseEnter; 
            Quote_label.MouseLeave += OnMouseLeave;
        }

        //Resize quote
        private void OnMouseEnter(object sender, EventArgs e)
        {
            Quote_label.Font = new Font(Quote_label.Font.Name, 18, FontStyle.Bold);
        }

        //Resize quote
        private void OnMouseLeave(object sender, EventArgs e)
        {
            Quote_label.Font = new Font(Quote_label.Font.Name, 15, FontStyle.Regular);
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

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Travel_button_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = Travel_button.Height;
            SidePanel.Top = Travel_button.Top;
            Travel_Usercontrol.BringToFront();
        }
    }
}
