using System.Collections.Generic;
using System.Windows.Forms;

namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Command business logic to perform a timeskip.
    /// </summary>
    class TimeSkipCommand : ICommand
    {
        public void Execute(Application application)
        {
            if (application.Controller.Store == null)
            {
                string message = "No store has been created yet";
                MessageBox.Show(message);
                return;
            }

            if (application.TimeStamp.IsStartDay())
            {
                MethodInvoker methodInvoker = () => application.FrenchutoForm.eventLogListBox.Items.Add(application.TimeStamp.StartDay());
                application.FrenchutoForm.BeginInvoke(methodInvoker);
            }

            for (int i = 0; i < 60; i++)
            {
                List<string> stringList = application.Controller.Update();
                for (int j = 0; j < stringList.Count; j++)
                {
                    string minuteString = i.ToString();
                    if (i < 10)
                    {
                        minuteString = "0" + i;
                    }

                    stringList[j] = $"Day {application.TimeStamp.DayCount} [{application.TimeStamp.CurrHour}:{minuteString}] {stringList[j]}";
                }

                MethodInvoker methodInvoker = () => application.FrenchutoForm.eventLogListBox.Items.AddRange(stringList.ToArray());
                application.FrenchutoForm.BeginInvoke(methodInvoker);
            }

            application.TimeStamp.UpdateHour();

            if (application.TimeStamp.IsEndOfDay())
            {
                MethodInvoker methodInvoker = () => application.FrenchutoForm.eventLogListBox.Items.Add(application.TimeStamp.EndDay());
                application.FrenchutoForm.BeginInvoke(methodInvoker);
                application.Controller.AllCustomersLeave();
            }

            application.ExecuteCommend(new UpdateListViewsCommand());
            application.ExecuteCommend(new SetListBoxToBottomCommand());
        }
    }
}
