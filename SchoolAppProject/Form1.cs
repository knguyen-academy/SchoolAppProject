using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// ///////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
//Design:
//Form1:
//	-Aboutme
//	-Education
//	-...
//	-Travel
//		-Travel_UC
//			-Destination_UC
//				-Album_UC


//Code:
//Form1:
//	-Add all the UserControl-forms of each button
//	-BringtoFront Aboutme form

//TravelUC:
//	-AddUserControl() :
//		-Init all Destination_UC, and add to its Panel
//Destination_UC:
//	- Public all its properties(labels..) so that Travel_UC can modify 
//	- Button click:
//		- Init all Album_UC so that if click on Photo, it will open Album_UC accordingly
//        ** in order to bringtoFront, the UC has to added to the pannel of the previous UC ***
///
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
            if (!Form1_Panel.Controls.Contains(AboutMe_UC.Instance))
            {
                Form1_Panel.Controls.Add(AboutMe_UC.Instance);     // Instance() function to get private _instance/object of Aboutme_UserControl class
                AboutMe_UC.Instance.Dock = DockStyle.Fill;
                AboutMe_UC.Instance.BringToFront();
            }

            //Education UC
            if (!Form1_Panel.Controls.Contains(Education_UC.Instance))
            {
                Form1_Panel.Controls.Add(Education_UC.Instance);
                Education_UC.Instance.Dock = DockStyle.Fill;
                
            }

            //Album me UC
            if (!Form1_Panel.Controls.Contains(Album_UC.Instance))
            {
                Form1_Panel.Controls.Add(Album_UC.Instance);
                Album_UC.Instance.Dock = DockStyle.Fill;
               
            }

            if (!Form1_Panel.Controls.Contains(Travel_UC.Instance))
            {
                Form1_Panel.Controls.Add(Travel_UC.Instance);
                Travel_UC.Instance.Dock = DockStyle.Fill;
                
            }

            if (!Form1_Panel.Controls.Contains(Contact_UC.Instance))
            {
                Form1_Panel.Controls.Add(Contact_UC.Instance);
                Contact_UC.Instance.Dock = DockStyle.Fill;
                //ContactUC.Instance.BringToFront();
            }
        }
        private void Aboutme_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Aboutme_button.Height;
            SidePanel.Top = Aboutme_button.Top;
            AboutMe_UC.Instance.BringToFront();

        }

        private void Education_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Education_button.Height;
            SidePanel.Top = Education_button.Top;
            Education_UC.Instance.BringToFront();
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
            Travel_UC.Instance.BringToFront();

        }


        private void Contact_button_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Contact_button.Height;
            SidePanel.Top = Contact_button.Top;
            Contact_UC.Instance.BringToFront();
        }
    }
}
