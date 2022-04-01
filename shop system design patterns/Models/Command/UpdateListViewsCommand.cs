using System.Windows.Forms;

namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Command business logic to update all list views.
    /// </summary>
    class UpdateListViewsCommand : ICommand
    {
        public void Execute(Application application)
        {
            MethodInvoker methodInvoker = () =>
            {
                application.FrenchutoForm.shelvesListView.Items.Clear();
                application.FrenchutoForm.stockersListView.Items.Clear();
                application.FrenchutoForm.customersListView.Items.Clear();
                application.FrenchutoForm.warehouseListView.Items.Clear();

                application.FrenchutoForm.shelvesListView.Items.AddRange(application.Controller.UpdateShelveListView());
                application.FrenchutoForm.stockersListView.Items.AddRange(application.Controller.UpdateStockersListView());
                application.FrenchutoForm.customersListView.Items.AddRange(application.Controller.UpdateCustomersListView());
                application.FrenchutoForm.warehouseListView.Items.AddRange(application.Controller.UpdateWarehouseListView());
            };

            application.FrenchutoForm.BeginInvoke(methodInvoker);
        }
    }
}
