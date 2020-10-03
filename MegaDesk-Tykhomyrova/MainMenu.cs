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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteButtom_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            this.Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewAllQuotes = new ViewAllQuotes();
            viewViewAllQuotes.Tag = this;
            viewViewAllQuotes.Show(this);
            this.Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the main menu form
            Close();
        }
    }
}
