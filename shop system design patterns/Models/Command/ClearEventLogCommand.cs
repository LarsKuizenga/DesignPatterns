﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchutoShop.Models
{
    class ClearEventLogCommand : ICommand
    {
        public ClearEventLogCommand() 
        { 
           
        }

        public void Execute(Application application)
        {
            MethodInvoker methodInvoker = () => application.FrenchutoForm.eventLogListBox.Items.Clear();
            application.FrenchutoForm.BeginInvoke(methodInvoker);
        }
    }
}
