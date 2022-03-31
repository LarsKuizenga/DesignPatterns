using FrenchutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchutoShop.Models
{
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
