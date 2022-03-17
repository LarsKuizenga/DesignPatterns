using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class ClearEventLogCommand : ICommand
    {
        public EventLog EventLog { get; set; }

        public ClearEventLogCommand(EventLog eventLog) 
        { 
            EventLog = eventLog; 
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
