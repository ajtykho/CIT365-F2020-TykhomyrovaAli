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
        private DeskQuote _deskQuote;

        public DisplayQuote(Desk desk, DeskQuote deskQuote)
        {
            
            _desk = desk;
            _deskQuote = deskQuote;

            InitializeComponent();
            quoteOutput.Text = _desk.materialType;
            nameOutput.Text = _deskQuote.customerName;
            //int deskWidth = _desk.deskWidth;
            //nameOutput.Text = Cstr(deskWidth); 
        }

        private string Cstr(int deskWidth)
        {
            throw new NotImplementedException();
        }

        private void backMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Tag = this;
            viewMainMenu.Show(this);
            this.Hide();
        }


    }
}
