using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Placement_Management_Systems
{
    public partial class StudentCorner : Form
    {
        public StudentCorner()
        {
            InitializeComponent();
        }

        private void StudentCorner_Load(object sender, EventArgs e)
        {

            //making this form maximized
            this.WindowState = FormWindowState.Maximized;


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

            //adding Student Corner Title

            Label studentLabel = new Label();
            studentLabel.Text = "Student Corner";
            studentLabel.Font = new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic);
            studentLabel.ForeColor = Color.Azure;
            studentLabel.AutoSize = false;
            studentLabel.Width = 500;
            studentLabel.Height = 70;
            studentLabel.BackColor = Color.Transparent;
            studentLabel.Anchor = AnchorStyles.Top;
            studentLabel.Location = new Point(400, 150);
            studentLabel.TextAlign = ContentAlignment.TopCenter;
            studentLabel.Dock = DockStyle.None;


            //--------------------------------------------------------------------

            Button loginButton = new Button();
            loginButton.Text = "Login";
            loginButton.Font = new Font("Arial", 18, FontStyle.Italic);
            loginButton.ForeColor = Color.Tomato;
            loginButton.AutoSize = false;
            loginButton.BackColor = Color.AliceBlue;
            loginButton.Dock = DockStyle.None;
            loginButton.Location = new Point(250, 380);
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Width = 200;
            loginButton.Height = 45;


            //---------------------------------------------------------------------


            Button newAccount = new Button();
            newAccount.Text = "New Account";
            newAccount.Font = new Font("Arial", 18, FontStyle.Italic);
            newAccount.ForeColor = Color.Tomato;
            newAccount.AutoSize = false;
            newAccount.BackColor = Color.AliceBlue;
            newAccount.Dock = DockStyle.None;
            newAccount.Location = new Point(950, 380);
            newAccount.Anchor = AnchorStyles.Top;
            newAccount.Width = 200;
            newAccount.Height = 45;

            //--------------------------------------------------------------------


            //back button
            Button backButton = new Button();
            backButton.Text = "Back";
            backButton.Font = new Font("Arial", 18, FontStyle.Italic);
            backButton.ForeColor = Color.Tomato;
            backButton.AutoSize = false;
            backButton.BackColor = Color.AliceBlue;
            backButton.Dock = DockStyle.None;
            backButton.Location = new Point(560, 550);
            backButton.Anchor = AnchorStyles.Top;
            backButton.Width = 200;
            backButton.Height = 45;


            //--------------------------------------------------------------


            //adding all the labels, buttons to the form
            this.Controls.Add(Title);
            this.Controls.Add(loginButton);
            this.Controls.Add(newAccount);
            this.Controls.Add(studentLabel);
            this.Controls.Add(backButton);

            //triggering the click events

            backButton.Click += new EventHandler(backButton_Click);
            newAccount.Click += new EventHandler(newAccountButton_Click);
            loginButton.Click += new EventHandler(loginButton_Click);
        }



        protected void backButton_Click(object sender, EventArgs e)
        {
            //opening Start form on click
            Start newStart = new Start();


            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newStart.Size = new Size(formWidth, formHeight);
            this.Hide();
            newStart.Show();
        }


        protected void newAccountButton_Click(object sender, EventArgs e)
        {
            //opening Start form on click
            StudentNewAccount newAccount = new StudentNewAccount();


            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newAccount.Size = new Size(formWidth, formHeight);
            this.Hide();
            newAccount.Show();

        }
        protected void loginButton_Click(object sender, EventArgs e)
        {
            //opening Start form on click
            StudentLogin newLogin = new StudentLogin();


            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newLogin.Size = new Size(formWidth, formHeight);
            this.Hide();
            newLogin.Show();
        }
    }
}
