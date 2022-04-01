using System.Windows.Forms;

namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Command business logic to start a new store.
    /// </summary>
    class StartNewStoreCommand : ICommand
    {
        public void Execute(Application application)
        {
            MethodInvoker methodInvoker = () =>
            {
                application.FrenchutoForm.eventLogListBox.Items.Clear();
                application.FrenchutoForm.shelvesListView.Items.Clear();
                application.FrenchutoForm.eventLogListBox.Items.Clear();
            };

            application.FrenchutoForm.BeginInvoke(methodInvoker);
            application.Controller.Initialize();
            application.ExecuteCommend(new UpdateListViewsCommand());
        }
    }
}
