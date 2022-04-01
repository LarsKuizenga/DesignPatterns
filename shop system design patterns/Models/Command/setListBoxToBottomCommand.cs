using System.Windows.Forms;

namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Command business logic to set eventlog to last entry when a timeskip occurs.
    /// </summary>
    class SetListBoxToBottomCommand : ICommand
    {
        public void Execute(Application application)
        {
            MethodInvoker methodInvoker = () =>
            {
                application.FrenchutoForm.eventLogListBox.TopIndex = application.FrenchutoForm.eventLogListBox.Items.Count - 1;
            };

            application.FrenchutoForm.BeginInvoke(methodInvoker);
        }
    }
}
