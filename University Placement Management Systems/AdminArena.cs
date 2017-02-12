using MySql.Data.MySqlClient;
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
    public partial class AdminArena : Form
    {
        public AdminArena()
        {
            InitializeComponent();
        }

        //initializing tools

        Label Title = new Label();
        Label adminLabel = new Label();
        Label studentQualification = new Label();
        Label studentDepartment = new Label();


        ComboBox qualificationBox = new ComboBox();
        ComboBox departmentBox = new ComboBox();

        Button backButton = new Button();
        Button submitButton = new Button();

        
        private void AdminArena_Load(object sender, EventArgs e)
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

            //adding Admin Corner Title

            adminLabel.Text = "Admin Arena";
            adminLabel.Font = new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic);
            adminLabel.ForeColor = Color.Azure;
            adminLabel.AutoSize = false;
            adminLabel.Width = 500;
            adminLabel.Height = 70;
            adminLabel.BackColor = Color.Transparent;
            adminLabel.Anchor = AnchorStyles.Top;
            adminLabel.Location = new Point(400, 150);
            adminLabel.TextAlign = ContentAlignment.TopCenter;
            adminLabel.Dock = DockStyle.None;


            //--------------------------------------------------------------------

            studentQualification.Text = "Sort by Qualification : ";
            studentQualification.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentQualification.BackColor = Color.Transparent;
            studentQualification.ForeColor = Color.Azure;
            studentQualification.AutoSize = false;
            studentQualification.Width = 400;
            studentQualification.Height = 40;
            studentQualification.BackColor = Color.Transparent;
            studentQualification.Anchor = AnchorStyles.Top;
            studentQualification.Location = new Point(300, 400);
            studentQualification.Dock = DockStyle.None;
            studentQualification.TextAlign = ContentAlignment.MiddleLeft;

            //--------------------------------------------------------------------

            studentDepartment.Text = "Sort by Department : ";
            studentDepartment.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
            studentDepartment.BackColor = Color.Transparent;
            studentDepartment.ForeColor = Color.Azure;
            studentDepartment.AutoSize = false;
            studentDepartment.Width = 400;
            studentDepartment.Height = 40;
            studentDepartment.BackColor = Color.Transparent;
            studentDepartment.Anchor = AnchorStyles.Top;
            studentDepartment.Location = new Point(300, 300);
            studentDepartment.Dock = DockStyle.None;
            studentDepartment.TextAlign = ContentAlignment.MiddleLeft;



            //--------------------------------------------------------------------

            departmentBox.Location = new Point(700, 300);
            departmentBox.Font = new Font("Arial", 18, FontStyle.Italic);
            departmentBox.Width = 300;
            departmentBox.Height = 35;
            departmentBox.Text = "Select the Department";
            departmentBox.Items.Add("Aeronautical");
            departmentBox.Items.Add("B.M.E");
            departmentBox.Items.Add("Chemical");
            departmentBox.Items.Add("Civil");
            departmentBox.Items.Add("C.S.E");
            departmentBox.Items.Add("EEE");
            departmentBox.Items.Add("ECE");
            departmentBox.Items.Add("I.T");
            departmentBox.Items.Add("Mechanical");
            departmentBox.Items.Add("Any Department");
            departmentBox.Anchor = AnchorStyles.Top;

            //--------------------------------------------------------------------


            qualificationBox.Location = new Point(700, 400);
            qualificationBox.Font = new Font("Arial", 18, FontStyle.Italic);
            qualificationBox.Width = 300;
            qualificationBox.Height = 35;
            qualificationBox.Text = "Select the Qualification";
            qualificationBox.Items.Add("U.G");
            qualificationBox.Items.Add("P.G");
            qualificationBox.Items.Add("Any Qualification");
            qualificationBox.Anchor = AnchorStyles.Top;


            //--------------------------------------------------------------------


            // submit button

            submitButton.Text = "Submit";
            submitButton.Font = new Font("Arial", 18, FontStyle.Italic);
            submitButton.ForeColor = Color.Tomato;
            submitButton.AutoSize = false;
            submitButton.BackColor = Color.AliceBlue;
            submitButton.Dock = DockStyle.None;
            submitButton.Location = new Point(760, 550);
            submitButton.Anchor = AnchorStyles.Top;
            submitButton.Width = 200;
            submitButton.Height = 45;


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

            this.Controls.Add(Title);
            this.Controls.Add(adminLabel);
            this.Controls.Add(studentDepartment);
            this.Controls.Add(studentQualification);
            this.Controls.Add(qualificationBox);
            this.Controls.Add(departmentBox);
            this.Controls.Add(backButton);
            this.Controls.Add(submitButton);

            //adding click events

            submitButton.Click += new EventHandler(submitButton_Click);
            backButton.Click += new EventHandler(backButton_Click);
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if(qualificationBox.Text == "Select the Qualification"
            || departmentBox.Text == "Select the Department"           )
            {
                MessageBox.Show("All the fields are compulsory.", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                //show the number of filtered records
                databaseConnection newDB = new databaseConnection();

                //search for the given data from database
                int counter = 0;
                string query = "SELECT * FROM Student WHERE studentDepartment = @dept AND studentQualification = @qualification;";
                MySqlCommand cmd = new MySqlCommand(query, newDB.newConnection);
                cmd.Parameters.AddWithValue("@dept", departmentBox.Text);
                cmd.Parameters.AddWithValue("@qualification", qualificationBox.Text);
                 if (newDB.openConnection() == true)
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            ++counter;
                        }
                        


                    }
                }
                if(counter == 0)
                {
                    MessageBox.Show("There is no record in "
                    + departmentBox.Text + " Department studying " + qualificationBox.Text + " .");
                }
                else if(counter == 1)
                {
                    MessageBox.Show("There is a record in "
                   + departmentBox.Text + " Department studying " + qualificationBox.Text + " .");

                }
                else
                {
                    MessageBox.Show("There are " + Convert.ToString(counter) + " records in "
                    + departmentBox.Text + " Department studying " + qualificationBox.Text + " .");

                }

                return;
                }
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
    }
}
