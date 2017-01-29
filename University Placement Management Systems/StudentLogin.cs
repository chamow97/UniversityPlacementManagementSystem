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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        //initializing tools

        Label Title = new Label();
        Label studentLabel = new Label();
        Label loginLabel = new Label();
        TextBox usernameBox = new TextBox();
        Label passwordLabel = new Label();
        Button loginButton = new Button();
        Button backButton = new Button();
        TextBox passwordBox = new TextBox();


        private void StudentLogin_Load(object sender, EventArgs e)
        {
            //making this form maximized
            this.WindowState = FormWindowState.Maximized;

            //adding the label and buttons to the form
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


            //adding Login form

            loginLabel.Text = "Username : ";
            loginLabel.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            loginLabel.BackColor = Color.Transparent;
            loginLabel.ForeColor = Color.Azure;
            loginLabel.AutoSize = false;
            loginLabel.Width = 400;
            loginLabel.Height = 70;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Anchor = AnchorStyles.Top;
            loginLabel.Location = new Point(200, 325);
            loginLabel.TextAlign = ContentAlignment.TopCenter;
            loginLabel.Dock = DockStyle.None;


            //--------------------------------------------------------------------

            //adding textbox for username


            usernameBox.Font = new Font("Arial", 18);
            usernameBox.Location = new Point(650, 325);
            usernameBox.Width = 300;
            usernameBox.Height = 70;
            usernameBox.ForeColor = Color.Black;
            usernameBox.BackColor = Color.White;


            //--------------------------------------------------------------------


            //adding password form

            passwordLabel.Text = "Password : ";
            passwordLabel.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            passwordLabel.BackColor = Color.White;
            passwordLabel.ForeColor = Color.Azure;
            passwordLabel.AutoSize = false;
            passwordLabel.Width = 400;
            passwordLabel.Height = 70;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Anchor = AnchorStyles.Top;
            passwordLabel.Location = new Point(200, 400);
            passwordLabel.TextAlign = ContentAlignment.TopCenter;
            passwordLabel.Dock = DockStyle.None;


            //--------------------------------------------------------------------

            //adding textbox for password


            passwordBox.Font = new Font("Arial", 18);
            passwordBox.Location = new Point(650, 400);
            passwordBox.Width = 300;
            passwordBox.Height = 70;
            passwordBox.ForeColor = Color.Black;
            passwordBox.BackColor = Color.White;
            passwordBox.PasswordChar = '*';


            //--------------------------------------------------------------------

            // login button

            loginButton.Text = "Login";
            loginButton.Font = new Font("Arial", 18, FontStyle.Italic);
            loginButton.ForeColor = Color.Tomato;
            loginButton.AutoSize = false;
            loginButton.BackColor = Color.AliceBlue;
            loginButton.Dock = DockStyle.None;
            loginButton.Location = new Point(760, 550);
            loginButton.Anchor = AnchorStyles.Top;
            loginButton.Width = 200;
            loginButton.Height = 45;


            //--------------------------------------------------------------------


            //back button
            backButton.Text = "Back";
            backButton.Font = new Font("Arial", 18, FontStyle.Italic);
            backButton.ForeColor = Color.Tomato;
            backButton.AutoSize = false;
            backButton.BackColor = Color.AliceBlue;
            backButton.Dock = DockStyle.None;
            backButton.Location = new Point(360, 550);
            backButton.Anchor = AnchorStyles.Top;
            backButton.Width = 200;
            backButton.Height = 45;


            //--------------------------------------------------------------------


            //adding labels, buttons etc to form

            this.Controls.Add(Title);
            this.Controls.Add(loginLabel);
            this.Controls.Add(studentLabel);
            this.Controls.Add(usernameBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(passwordBox);
            this.Controls.Add(loginButton);
            this.Controls.Add(backButton);


            //--------------------------------------------------------------------

            //triggering the click event

            backButton.Click += new EventHandler(backButton_Click);
            loginButton.Click += new EventHandler(loginButton_Click);

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Username or Password field should not be empty.", "Error", MessageBoxButtons.OK);
                return;
            }

            else
            {
                //databaseConnection;
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            //opening Start form on click
            StudentCorner newStudent = new StudentCorner();

            //adjusting the size of new window to be the exact same size as that of previous

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            newStudent.Size = new Size(formWidth, formHeight);
            this.Hide();
            newStudent.Show();
        }

      
    }
}
