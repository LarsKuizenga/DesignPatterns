using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class TimeSkipCommand : ICommand
    {
        public EventLog EventLog { get; set; }
        public Store Store { get; set; }

        public TimeSkipCommand(EventLog eventLog, Store store)
        {
            EventLog = eventLog;
            Store = store;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
