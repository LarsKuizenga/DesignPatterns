using FrenchutoShop.Models;
using FrenchutoShop.Models.Command;
using System;
using System.Windows.Forms;

namespace FrenchutoShop
{
    public partial class FrenchutoForm : Form
    {
        private readonly Models.Command.Application application;

        public FrenchutoForm()
        {
            InitializeComponent();
            application = new Models.Command.Application(new Controller(), this);
        }

        private void StartNewStoreButton_Click(object sender, EventArgs e)
        {
            application.ExecuteCommend(new StartNewStoreCommand());
        }

        private void TimeSkip_Click(object sender, EventArgs e)
        {
            application.ExecuteCommend(new TimeSkipCommand());
        }

        private void ClearEventLog_Click(object sender, EventArgs e)
        {
            application.ExecuteCommend(new ClearEventLogCommand());
        }
    }
}
