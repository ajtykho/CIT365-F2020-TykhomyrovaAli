using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk_Tykhomyrova
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("dd, MMMM yyyy");

        }

        //calculate the quote
        private void formSubmission_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            var quote = new DeskQuote();

            desk.deskWidth = 1;
            desk.deskDepth = 1;
            desk.materialType = materialInput.Text;
            desk.numDrawers = 1;

            var displayQuote = new DisplayQuote(desk);

            displayQuote.Show();

            Hide();
        }



        //let user go back to the main menu
        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        //make sure width input is valid
        private void widthInput_Validating(object sender, EventArgs e)
        {
            //test if input is an int
            int i;
            if (int.TryParse(widthInput.Text, out i))
            {
                int width = int.Parse(widthInput.Text);
                // if user input is >= 24 and <=96
                if (width >= 24 && width <= 96)
                {
                    // accept the user input?
                    int officialWidthInput = int.Parse(widthInput.Text);

                }
                else
                {
                    // Tell user what the problem is
                    widthInput.Text = String.Empty;
                    widthInput.BackColor = Color.Red;
                    MessageBox.Show("Enter a width between 24 and 96");
                }
            }
            else
            {
                // Tell user what the problem is
                widthInput.Text = String.Empty;
                widthInput.BackColor = Color.Red;
                MessageBox.Show("Please enter a number value between 24 and 96");
            }

        }

        //make sure depth input is valid
        private void depthInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            int i = 0;
            if (!Char.IsControl(depthInput.Text, i))
            {
                if (!Char.IsDigit(depthInput.Text, i))
                {
                    //test if input is an int
                    int x;
                    if (int.TryParse(depthInput.Text, out x))
                    {
                        int depth = int.Parse(widthInput.Text);
                        // if user input is >= 24 and <=96
                        if (depth >= 12 && depth <= 48)
                        {
                            int officialDepthInput = int.Parse(depthInput.Text);
                        }
                        else
                        {
                            // Tell user what the problem is
                            widthInput.Text = String.Empty;
                            widthInput.BackColor = Color.Red;
                            MessageBox.Show("Enter a width between 12 and 48");
                        }
                    }
                    else
                    {
                        // Tell user what the problem is
                        widthInput.Text = String.Empty;
                        widthInput.BackColor = Color.Red;
                        MessageBox.Show("Please enter a number value between 12 and 48");
                    }

                }
                else
                {
                    // Tell user what the problem is
                    widthInput.Text = String.Empty;
                    widthInput.BackColor = Color.Red;
                    MessageBox.Show("Please enter a number value between 12 and 48");
                }

            }
            else
            {
                // Tell user what the problem is
                widthInput.Text = String.Empty;
                widthInput.BackColor = Color.Red;
                MessageBox.Show("Please enter a number value between 12 and 48");
            }
        }

    }
}
