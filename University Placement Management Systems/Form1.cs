using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.OleDb; 

namespace University_Placement_Management_Systems
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

            //making this form maximized
            this.WindowState = FormWindowState.Maximized;
            //databaseManager();
           

            //adding the label and buttons to the form
            Label Title = new Label();
            Title.Text = "Placement Management Systems";
            Title.Font = new Font("Monotype Corsiva", 36, FontStyle.Bold | FontStyle.Italic);
            Title.ForeColor = Color.MediumSpringGreen;
            Title.AutoSize = false;
            Title.Width = 800;
            Title.Height = 70;
            Title.BackColor = Color.Transparent;
            Title.Anchor = AnchorStyles.Top;
            Title.Location = new Point(300, 10);
            Title.TextAlign = ContentAlignment.TopCenter;
            Title.Dock = DockStyle.None;

            //--------------------------------------------------------------------


            Button studentCorner = new Button();
            studentCorner.Text = "Student Corner";
            studentCorner.Font = new Font("Arial", 18, FontStyle.Italic);
            studentCorner.ForeColor = Color.Tomato;
            studentCorner.AutoSize = false;
            studentCorner.BackColor = Color.AliceBlue;
            studentCorner.Dock = DockStyle.None;
            studentCorner.Location = new Point(250, 280);
            studentCorner.Anchor = AnchorStyles.Top;
            studentCorner.Width = 200;
            studentCorner.Height = 45;


            //----------------------------------------------------------


            Button adminCorner = new Button();
            adminCorner.Text = "Admin Corner";
            adminCorner.Font = new Font("Arial", 18, FontStyle.Italic);
            adminCorner.ForeColor = Color.Tomato;
            adminCorner.AutoSize = false;
            adminCorner.BackColor = Color.AliceBlue;
            adminCorner.Dock = DockStyle.None;
            adminCorner.Location = new Point(430, 380);
            adminCorner.Anchor = AnchorStyles.Top;
            adminCorner.Width = 200;
            adminCorner.Height = 45;


            //--------------------------------------------------------------


            Button aboutTheProject = new Button();
            aboutTheProject.Text = "About";
            aboutTheProject.Font = new Font("Arial", 18, FontStyle.Italic);
            aboutTheProject.ForeColor = Color.Tomato;
            aboutTheProject.AutoSize = false;
            aboutTheProject.BackColor = Color.AliceBlue;
            aboutTheProject.Dock = DockStyle.None;
            aboutTheProject.Location = new Point(610, 480);
            aboutTheProject.Anchor = AnchorStyles.Top;
            aboutTheProject.Width = 200;
            aboutTheProject.Height = 45;


            //------------------------------------------------------------------------


            Button closeWindow = new Button();
            closeWindow.Text = "Exit";
            closeWindow.Font = new Font("Arial", 18, FontStyle.Italic);
            closeWindow.ForeColor = Color.Tomato;
            closeWindow.AutoSize = false;
            closeWindow.BackColor = Color.AliceBlue;
            closeWindow.Dock = DockStyle.None;
            closeWindow.Location = new Point(790, 580);
            closeWindow.Anchor = AnchorStyles.Top;
            closeWindow.Width = 200;
            closeWindow.Height = 45;
        


            //adding the buttons, labels, textbox to forms
            this.Controls.Add(Title);
            this.Controls.Add(studentCorner);
            this.Controls.Add(adminCorner);
            this.Controls.Add(aboutTheProject);
            this.Controls.Add(closeWindow);



            //triggering the click event
            studentCorner.Click += new EventHandler(studentCorner_Click);
            adminCorner.Click += new EventHandler(adminCorner_Click);
            aboutTheProject.Click += new EventHandler(aboutTheProject_Click);
            closeWindow.Click += new EventHandler(closeWindow_Click);

        }

        //Database method
        
        protected void databaseManager(object sender, EventArgs e)
        {
           
        }     

        protected void studentCorner_Click(object sender, EventArgs e)
        {
            //opening Student Corner form on click
            StudentCorner newStudentCorner = new StudentCorner();

            
            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newStudentCorner.Size = new Size(formWidth, formHeight);
            this.Hide();
            newStudentCorner.Show();
                                 
        }


        protected void adminCorner_Click(object sender, EventArgs e)
        {
            //opening Admin Corner Form on click
            AdminCorner newAdminCorner = new AdminCorner();

            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newAdminCorner.Size = new Size(formWidth, formHeight);
            this.Hide();
            newAdminCorner.Show();

        }


        protected void aboutTheProject_Click(object sender, EventArgs e)
        {
            //opening About Page
            About newAboutTheProject = new About();

            
            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newAboutTheProject.Size = new Size(formWidth, formHeight);
            this.Hide();
            newAboutTheProject.Show();
                       
        }


        protected void closeWindow_Click(object sender, EventArgs e)
        {
            //prompting user before closing the application
            if(MessageBox.Show("   This will close this Application. Want to continue?",
                "Close Application",
                MessageBoxButtons.YesNo) == DialogResult.Yes
                )
            {
                this.Close();
            }
            else
            {
                return;
            }
        }


    }
}
