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
		private TimeStamp timeStamp;
		

        public FrenchutoForm()
        {
            InitializeComponent();
			application = new(new EventLog(), new Controller());
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			
        }

		private void StartNewStoreButton_Click(object sender, EventArgs e)
		{
			eventLogListBox.Items.Clear();
			shelvesListView.Items.Clear();
			application.Controller.Initialize();
			timeStamp = new TimeStamp(1, 8, 20);
			UpdateListViews();
		}

		private void TimeSkip_Click(object sender, EventArgs e)
		{
			if (application.Controller.Store == null)
			{
				string message = "No store has been created yet";
				MessageBox.Show(message);
				return;
			}

			if (timeStamp.IsStartDay())
            {
				eventLogListBox.Items.Add(timeStamp.StartDay());
			}

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
					stringList[j] = $"Day {timeStamp.DayCount} [{timeStamp.CurrHour}:{minuteString}] {stringList[j]}";
				}
				eventLogListBox.Items.AddRange(stringList.ToArray());
			}

			timeStamp.UpdateHour();

			if (timeStamp.IsEndOfDay())
            {
				eventLogListBox.Items.Add(timeStamp.EndDay());
				application.Controller.AllCustomersLeave();
			}

			UpdateListViews();
			SetListBoxToBottom();
		}

		private void UpdateListViews()
        {
			shelvesListView.Items.Clear();
			stockersListView.Items.Clear();
			customersListView.Items.Clear();
			warehouseListView.Items.Clear();

			shelvesListView.Items.AddRange(application.Controller.UpdateShelveListView());
			stockersListView.Items.AddRange(application.Controller.UpdateStockersListView());
			customersListView.Items.AddRange(application.Controller.UpdateCustomersListView());
			warehouseListView.Items.AddRange(application.Controller.UpdateWarehouseListView());
		}

		private void SetListBoxToBottom()
		{ 
			eventLogListBox.TopIndex = eventLogListBox.Items.Count-1;
		}

		private void ClearEventLog_Click(object sender, EventArgs e)
		{
			eventLogListBox.Items.Clear();
		}
    }
}
