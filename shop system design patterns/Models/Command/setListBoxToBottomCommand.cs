using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchutoShop.Models
{
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
