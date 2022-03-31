using FrenchutoShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchutoShop
{
    public partial class FrenchutoForm : Form
    {
		private Models.Application application;
		
        public FrenchutoForm()
        {
            InitializeComponent();
			application = new Models.Application(new Controller(), this);
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			
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
