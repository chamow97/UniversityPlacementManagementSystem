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
    public partial class StudentArena : Form
    {
        public StudentArena()
        {
            InitializeComponent();
        }
        Label studentLabel = new Label();
        Label Title = new Label();

        Button editButton = new Button();
        Button deleteButton = new Button();
        Button backButton = new Button();


        private void StudentArena_Load(object sender, EventArgs e)
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

            studentLabel.Text = "Student Arena";
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
            // edit button

            editButton.Text = "Edit Data";
            editButton.Font = new Font("Arial", 18, FontStyle.Italic);
            editButton.ForeColor = Color.Tomato;
            editButton.AutoSize = false;
            editButton.BackColor = Color.AliceBlue;
            editButton.Dock = DockStyle.None;
            editButton.Location = new Point(260, 400);
            editButton.Anchor = AnchorStyles.Top;
            editButton.Width = 200;
            editButton.Height = 45;


            //--------------------------------------------------------------------


            //delete button button
            deleteButton.Text = "Delete Data";
            deleteButton.Font = new Font("Arial", 18, FontStyle.Italic);
            deleteButton.ForeColor = Color.Tomato;
            deleteButton.AutoSize = false;
            deleteButton.BackColor = Color.AliceBlue;
            deleteButton.Dock = DockStyle.None;
            deleteButton.Location = new Point(860, 400);
            deleteButton.Anchor = AnchorStyles.Top;
            deleteButton.Width = 200;
            deleteButton.Height = 45;

            //--------------------------------------------------------------------

            //back button
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



            //--------------------------------------------------------------------

            this.Controls.Add(Title);
            this.Controls.Add(studentLabel);
            this.Controls.Add(editButton);
            this.Controls.Add(deleteButton);
            this.Controls.Add(backButton);

        }
    }
}
