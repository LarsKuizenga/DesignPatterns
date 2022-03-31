using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchutoShop.Models
{
    class TimeSkipCommand : ICommand 
    {
		
		public TimeSkipCommand()
        {

		}

        public void Execute(Application Application)
        {
			if (Application.Controller.Store == null)
			{
				string message = "No store has been created yet";
				MessageBox.Show(message);
				return;
			}

			if (Application.TimeStamp.IsStartDay())
			{
				MethodInvoker methodInvoker = () => Application.FrenchutoForm.eventLogListBox.Items.Add(Application.TimeStamp.StartDay());
				Application.FrenchutoForm.BeginInvoke(methodInvoker);
			}

			for (int i = 0; i < 60; i++)
			{
				List<String> stringList = Application.Controller.Update();
				for (int j = 0; j < stringList.Count; j++)
				{
					string minuteString = i.ToString();
					if (i < 10)
					{
						minuteString = "0" + i;
					}
					stringList[j] = $"Day {Application.TimeStamp.DayCount} [{Application.TimeStamp.CurrHour}:{minuteString}] {stringList[j]}";
				}
				MethodInvoker methodInvoker = () => Application.FrenchutoForm.eventLogListBox.Items.AddRange(stringList.ToArray());
				Application.FrenchutoForm.BeginInvoke(methodInvoker);
			}

			Application.TimeStamp.UpdateHour();

			if (Application.TimeStamp.IsEndOfDay())
			{
				MethodInvoker methodInvoker = () => Application.FrenchutoForm.eventLogListBox.Items.Add(Application.TimeStamp.EndDay());
				Application.FrenchutoForm.BeginInvoke(methodInvoker);
				Application.Controller.AllCustomersLeave();
			}

			Application.ExecuteCommend(new UpdateListViewsCommand());
			Application.ExecuteCommend(new SetListBoxToBottomCommand());
        }
    }
}
