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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
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

            Label informationLabel = new Label();
            informationLabel.Text = "Created and maintained by ChaMow.\n Contact me for " +
                "further queries. \n\t E-Mail : chamow97@hotmail.com. \n\t Thank you for using this Application !! :)";
            informationLabel.Font = new Font("Monotype Corsiva", 28, FontStyle.Bold | FontStyle.Italic);
            informationLabel.ForeColor = Color.CornflowerBlue;
            informationLabel.AutoSize = false;
            informationLabel.BackColor = Color.Transparent;
            informationLabel.Anchor = AnchorStyles.Top;
            informationLabel.Width = 800;
            informationLabel.Height = 400;
            informationLabel.Location = new Point(300, 150);
            informationLabel.TextAlign = ContentAlignment.TopCenter;
            informationLabel.Dock = DockStyle.None;

            //--------------------------------------------------------------------

            //back button
            Button backButton = new Button();
            backButton.Text = "Back";
            backButton.Font = new Font("Arial", 18, FontStyle.Italic);
            backButton.ForeColor = Color.Tomato;
            backButton.AutoSize = false;
            backButton.BackColor = Color.AliceBlue;
            backButton.Dock = DockStyle.None;
            backButton.Location = new Point(550, 550);
            backButton.Anchor = AnchorStyles.Top;
            backButton.Width = 200;
            backButton.Height = 45;

            //--------------------------------------------------------------------


            this.Controls.Add(Title);
            this.Controls.Add(informationLabel);
            this.Controls.Add(backButton);

            backButton.Click += new EventHandler(backButton_Click);

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
