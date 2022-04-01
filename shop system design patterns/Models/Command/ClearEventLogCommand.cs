using System.Windows.Forms;

namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Command business logic to clear event log.
    /// </summary>
    class ClearEventLogCommand : ICommand
    {
        public void Execute(Application application)
        {
            MethodInvoker methodInvoker = () => application.FrenchutoForm.eventLogListBox.Items.Clear();
            application.FrenchutoForm.BeginInvoke(methodInvoker);
        }
    }
}
