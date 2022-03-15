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
        public Controller Controller { get; set; }

        public TimeSkipCommand(EventLog eventLog, Controller controller)
        {
            EventLog = eventLog;
            Controller = controller;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
