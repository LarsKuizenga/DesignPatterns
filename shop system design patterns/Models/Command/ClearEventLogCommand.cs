using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
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
