using shop_system_design_patterns.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_system_design_patterns
{
    public partial class FrenchutoForm : Form
    {
		private models.Application application;

        public FrenchutoForm()
        {
            InitializeComponent();
			application = new(new EventLog(), new Controller());
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			application.Controller.Initialize();
        }

		private void EventLogListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TimeSkip_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 60; i++)
			{
				List<String> stringList = application.Controller.Update();
				for (int j = 0; j < stringList.Count; j++)
				{
					string minuteString = i.ToString();
					if(i < 10)
                    {
						minuteString = "0" + i;
                    }
					stringList[j] = "[8:" + minuteString + "] " + stringList[j];
				}
				this.eventLogListBox.Items.AddRange(stringList.ToArray());
			}
		}

		private void ClearEventLog_Click(object sender, EventArgs e)
		{

		}
	}
}
