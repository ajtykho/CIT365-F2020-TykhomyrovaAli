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
    public partial class DisplayQuote : Form
    {
        private Desk _desk;

        public DisplayQuote(Desk desk)
        {
            
            _desk = desk;
           // _quote = deskQuote;

            InitializeComponent();
            quoteOutput.Text = _desk.materialType;
           // nameOutput.Text = 
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
           // MainMenu viewMainMenu = (MainMenu)Tag;
         //   viewMainMenu.Show();
           // Close();

            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            this.Hide();
        }


    }
}
