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

            //Function to add all the UC forms to Form1
            AddUCForms();

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

        void AddUCForms()
        {
            //About me UC
            if (!Form1_Panel.Controls.Contains(AboutMe_UserControl.Instance))
            {
                Form1_Panel.Controls.Add(AboutMe_UserControl.Instance);     // Instance() function to get private _instance/object of Aboutme_UserControl class
                AboutMe_UserControl.Instance.Dock = DockStyle.Fill;
                AboutMe_UserControl.Instance.BringToFront();
            }

            //Education UC
            if (!Form1_Panel.Controls.Contains(Education_UserControl.Instance))
            {
                Form1_Panel.Controls.Add(Education_UserControl.Instance);
                Education_UserControl.Instance.Dock = DockStyle.Fill;
                
            }

            //Album me UC
            if (!Form1_Panel.Controls.Contains(AlbumUserControl.Instance))
            {
                Form1_Panel.Controls.Add(AlbumUserControl.Instance);
                AlbumUserControl.Instance.Dock = DockStyle.Fill;
               
            }

            if (!Form1_Panel.Controls.Contains(TravelUserControl.Instance))
            {
                Form1_Panel.Controls.Add(TravelUserControl.Instance);
                TravelUserControl.Instance.Dock = DockStyle.Fill;
                
            }

            if (!Form1_Panel.Controls.Contains(ContactUC.Instance))
            {
                Form1_Panel.Controls.Add(ContactUC.Instance);
                ContactUC.Instance.Dock = DockStyle.Fill;
                //ContactUC.Instance.BringToFront();
            }
        }
        private void Aboutme_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Aboutme_button.Height;
            SidePanel.Top = Aboutme_button.Top;
            AboutMe_UserControl.Instance.BringToFront();

        }

        private void Education_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Education_button.Height;
            SidePanel.Top = Education_button.Top;
            Education_UserControl.Instance.BringToFront();
            //education_UserControl1.BringToFront();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Travel_button_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = Travel_button.Height;
            SidePanel.Top = Travel_button.Top;
            TravelUserControl.Instance.BringToFront();

        }


        private void Contact_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Contact_button.Height;
            SidePanel.Top = Contact_button.Top;
            ContactUC.Instance.BringToFront();
        }
    }
}
