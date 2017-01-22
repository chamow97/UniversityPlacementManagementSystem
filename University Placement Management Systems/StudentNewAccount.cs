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

            //adding labels, buttons etc to form


            this.Controls.Add(Title);

        }
    }
}
