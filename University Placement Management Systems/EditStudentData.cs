﻿using MySql.Data.MySqlClient;
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
    public partial class EditStudentData : Form
    {
        public EditStudentData()
        {
            InitializeComponent();
        }
        //initializing tools

        Label Title = new Label();
        Label studentID = new Label();
        Label studentName = new Label();
        Label studentQualification = new Label();
        Label studentDepartment = new Label();
        Label studentPassword = new Label();

        TextBox idBox = new TextBox();
        TextBox nameBox = new TextBox();
        TextBox passwordBox = new TextBox();
        ComboBox qualificationBox = new ComboBox();
        ComboBox departmentBox = new ComboBox();

        Button backButton = new Button();
        Button submitButton = new Button();
        Button browseButton = new Button();

        PictureBox profilePicture = new PictureBox();

        OpenFileDialog browseImage = new OpenFileDialog();


        private void EditStudentData_Load(object sender, EventArgs e)
        {
            //databaseConnection;
            //open database to get the credentials
            databaseConnection newDB = new databaseConnection();

            //search for the given data from database
            string query = "SELECT studentName FROM Student WHERE studentID = @username;";
            TextBox tempBox = new TextBox();
            StudentLogin newStudent = new StudentLogin();
            tempBox.Text = newStudent.usernameBox.Text;
            MessageBox.Show(tempBox.Text);
            MySqlCommand cmd = new MySqlCommand(query, newDB.newConnection);
            cmd.Parameters.AddWithValue("@username", tempBox.Text);

            if (newDB.openConnection() == true)
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // try
                    //{
                    while (reader.Read())
                    {
                        MessageBox.Show(reader[0].ToString());
                            nameBox.Text = reader[0].ToString();
                            idBox.Text = reader[1].ToString();
                            passwordBox.Text = "";
                            departmentBox.Text = reader[3].ToString();
                            qualificationBox.Text = reader[4].ToString();
                    }                     

                    //}
                    //catch (Exception sqlException)
                    //{
                    //    MessageBox.Show(sqlException.Message);
                    //}

                }
                   
                 
                
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

                    studentQualification.Text = "Qualification : ";
                    studentQualification.Font = new Font("Arial", 18, FontStyle.Italic | FontStyle.Bold);
                    studentQualification.BackColor = Color.Transparent;
                    studentQualification.ForeColor = Color.Azure;
                    studentQualification.AutoSize = false;
                    studentQualification.Width = 400;
                    studentQualification.Height = 40;
                    studentQualification.BackColor = Color.Transparent;
                    studentQualification.Anchor = AnchorStyles.Top;
                    studentQualification.Location = new Point(200, 475);
                    studentQualification.Dock = DockStyle.None;
                    studentQualification.TextAlign = ContentAlignment.MiddleLeft;



                    //--------------------------------------------------------------------

                    departmentBox.Location = new Point(600, 400);
                    departmentBox.Font = new Font("Arial", 18, FontStyle.Italic);
                    departmentBox.Width = 300;
                    departmentBox.Height = 35;
                    departmentBox.Items.Add("Aeronautical");
                    departmentBox.Items.Add("B.M.E");
                    departmentBox.Items.Add("Chemical");
                    departmentBox.Items.Add("Civil");
                    departmentBox.Items.Add("C.S.E");
                    departmentBox.Items.Add("EEE");
                    departmentBox.Items.Add("ECE");
                    departmentBox.Items.Add("I.T");
                    departmentBox.Items.Add("Mechanical");
                    departmentBox.Anchor = AnchorStyles.Top;


                    //--------------------------------------------------------------------

                    nameBox.Font = new Font("Arial", 18, FontStyle.Italic);
                    nameBox.BackColor = Color.White;
                    nameBox.ForeColor = Color.Black;
                    nameBox.AutoSize = false;
                    nameBox.Width = 300;
                    nameBox.Height = 35;
                    nameBox.Anchor = AnchorStyles.Top;
                    nameBox.Location = new Point(600, 175);
                    nameBox.Dock = DockStyle.None;

                    //--------------------------------------------------------------------

                    idBox.Font = new Font("Arial", 18, FontStyle.Italic);
                    idBox.BackColor = Color.White;
                    idBox.ForeColor = Color.Black;
                    idBox.AutoSize = false;
                    idBox.Width = 300;
                    idBox.Height = 35;
                    idBox.Anchor = AnchorStyles.Top;
                    idBox.Location = new Point(600, 250);
                    idBox.Dock = DockStyle.None;

                    //--------------------------------------------------------------------

                    passwordBox.Font = new Font("Arial", 18, FontStyle.Italic);
                    passwordBox.BackColor = Color.White;
                    passwordBox.ForeColor = Color.Black;
                    passwordBox.AutoSize = false;
                    passwordBox.Width = 300;
                    passwordBox.Height = 35;
                    passwordBox.Anchor = AnchorStyles.Top;
                    passwordBox.Location = new Point(600, 325);
                    passwordBox.Dock = DockStyle.None;
                    passwordBox.PasswordChar = '*';

                    //--------------------------------------------------------------------


                    qualificationBox.Location = new Point(600, 475);
                    qualificationBox.Font = new Font("Arial", 18, FontStyle.Italic);
                    qualificationBox.Width = 300;
                    qualificationBox.Height = 35;
                    qualificationBox.Items.Add("U.G");
                    qualificationBox.Items.Add("P.G");
                    qualificationBox.Anchor = AnchorStyles.Top;




                    //--------------------------------------------------------------------

                    //back button
                    backButton.Text = "Back";
                    backButton.Font = new Font("Arial", 18, FontStyle.Italic);
                    backButton.ForeColor = Color.Tomato;
                    backButton.AutoSize = false;
                    backButton.BackColor = Color.AliceBlue;
                    backButton.Dock = DockStyle.None;
                    backButton.Location = new Point(310, 625);
                    backButton.Anchor = AnchorStyles.Top;
                    backButton.Width = 200;
                    backButton.Height = 45;

                    //--------------------------------------------------------------------
                    //submit button
                    submitButton.Text = "Submit";
                    submitButton.Font = new Font("Arial", 18, FontStyle.Italic);
                    submitButton.ForeColor = Color.Tomato;
                    submitButton.AutoSize = false;
                    submitButton.BackColor = Color.AliceBlue;
                    submitButton.Dock = DockStyle.None;
                    submitButton.Location = new Point(810, 625);
                    submitButton.Anchor = AnchorStyles.Top;
                    submitButton.Width = 200;
                    submitButton.Height = 45;


                    //--------------------------------------------------------------------

                    profilePicture.Width = 150;
                    profilePicture.Height = 150;
                    profilePicture.Location = new Point(1100, 125);
                    profilePicture.BackColor = Color.White;

                    //--------------------------------------------------------------------
                    browseButton.Text = "Browse for profile picture";
                    browseButton.Font = new Font("Arial", 12, FontStyle.Italic);
                    browseButton.ForeColor = Color.Tomato;
                    browseButton.AutoSize = false;
                    browseButton.BackColor = Color.AliceBlue;
                    browseButton.Dock = DockStyle.None;
                    browseButton.Location = new Point(1075, 300);
                    browseButton.Anchor = AnchorStyles.Top;
                    browseButton.Width = 200;
                    browseButton.Height = 30;



                    //--------------------------------------------------------------------



                    //adding labels, buttons etc to form

                    this.Controls.Add(Title);
                    this.Controls.Add(studentName);
                    this.Controls.Add(studentID);
                    this.Controls.Add(studentPassword);
                    this.Controls.Add(studentDepartment);
                    this.Controls.Add(studentQualification);


                    this.Controls.Add(nameBox);
                    this.Controls.Add(idBox);
                    this.Controls.Add(passwordBox);
                    this.Controls.Add(departmentBox);
                    this.Controls.Add(qualificationBox);
                    this.Controls.Add(backButton);
                    this.Controls.Add(submitButton);
                    this.Controls.Add(browseButton);

                    this.Controls.Add(profilePicture);


                    //adding Button controls
                    //backButton.Click += new EventHandler(backButton_Click);
                    //submitButton.Click += new EventHandler(submitButton_Click);
                    //browseButton.Click += new EventHandler(browseButton_Click);


                }
            }
        }
    }
