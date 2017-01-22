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
    public partial class StudentNewAccount : Form
    {
        public StudentNewAccount()
        {
            InitializeComponent();
        }

        //initializing tools

        Label Title = new Label();
        Label studentID = new Label();
        Label studentName = new Label();
        Label studentYear = new Label();
        Label studentDepartment = new Label();
        Label studentPassword = new Label();

        TextBox idBox = new TextBox();
        TextBox nameBox = new TextBox();
        TextBox passwordBox = new TextBox();
        ListBox yearBox = new ListBox();
        ComboBox departmentBox = new ComboBox();
        


        private void StudentNewAccount_Load(object sender, EventArgs e)
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

            studentName.Text = "Name : ";
            studentName.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentName.BackColor = Color.Transparent;
            studentName.ForeColor = Color.Azure;
            studentName.AutoSize = false;
            studentName.Width = 400;
            studentName.Height = 40;
            studentName.BackColor = Color.Transparent;
            studentName.Anchor = AnchorStyles.Top;
            studentName.Location = new Point(200, 175);
            studentName.Dock = DockStyle.None;
            studentName.TextAlign = ContentAlignment.MiddleLeft;


            //--------------------------------------------------------------------

            studentID.Text = "ID : ";
            studentID.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentID.BackColor = Color.Transparent;
            studentID.ForeColor = Color.Azure;
            studentID.AutoSize = false;
            studentID.Width = 400;
            studentID.Height = 40;
            studentID.BackColor = Color.Transparent;
            studentID.Anchor = AnchorStyles.Top;
            studentID.Location = new Point(200, 250);
            studentID.Dock = DockStyle.None;
            studentID.TextAlign = ContentAlignment.MiddleLeft;


            //--------------------------------------------------------------------

            studentDepartment.Text = "Department : ";
            studentDepartment.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentDepartment.BackColor = Color.Transparent;
            studentDepartment.ForeColor = Color.Azure;
            studentDepartment.AutoSize = false;
            studentDepartment.Width = 400;
            studentDepartment.Height = 40;
            studentDepartment.BackColor = Color.Transparent;
            studentDepartment.Anchor = AnchorStyles.Top;
            studentDepartment.Location = new Point(200, 400);
            studentDepartment.Dock = DockStyle.None;
            studentDepartment.TextAlign = ContentAlignment.MiddleLeft;



            //--------------------------------------------------------------------

            studentPassword.Text = "Password : ";
            studentPassword.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentPassword.BackColor = Color.Transparent;
            studentPassword.ForeColor = Color.Azure;
            studentPassword.AutoSize = false;
            studentPassword.Width = 400;
            studentPassword.Height = 40;
            studentPassword.BackColor = Color.Transparent;
            studentPassword.Anchor = AnchorStyles.Top;
            studentPassword.Location = new Point(200, 325);
            studentPassword.Dock = DockStyle.None;
            studentPassword.TextAlign = ContentAlignment.MiddleLeft;


            //--------------------------------------------------------------------

            studentYear.Text = "Year : ";
            studentYear.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentYear.BackColor = Color.Transparent;
            studentYear.ForeColor = Color.Azure;
            studentYear.AutoSize = false;
            studentYear.Width = 400;
            studentYear.Height = 40;
            studentYear.BackColor = Color.Transparent;
            studentYear.Anchor = AnchorStyles.Top;
            studentYear.Location = new Point(200, 475);
            studentYear.Dock = DockStyle.None;
            studentYear.TextAlign = ContentAlignment.MiddleLeft;



            //--------------------------------------------------------------------

            departmentBox.Text = "Select your Department";
            departmentBox.Items.Add("Aeronautical");
            departmentBox.Items.Add("B.M.E");
            departmentBox.Items.Add("Chemical");
            departmentBox.Items.Add("Civil");
            departmentBox.Items.Add("C.S.E");
            departmentBox.Items.Add("EEE");
            departmentBox.Items.Add("ECE");
            departmentBox.Items.Add("I.T");
            departmentBox.Items.Add("Mechanical");


            //--------------------------------------------------------------------



            //--------------------------------------------------------------------



            //--------------------------------------------------------------------





            //adding labels, buttons etc to form

            this.Controls.Add(Title);
            this.Controls.Add(studentName);
            this.Controls.Add(studentID);
            this.Controls.Add(studentPassword);
            this.Controls.Add(studentDepartment);
            this.Controls.Add(studentYear);

            this.Controls.Add(departmentBox);

        }
    }
}
