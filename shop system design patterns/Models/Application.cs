using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_system_design_patterns.models
{
    class Application
    {
        public EventLog EventLog { get; set; }
        public Controller Controller { get; set; }
        
        public Application(EventLog eventLog, Controller controller)
        {
            EventLog = eventLog;
            Controller = controller;
        }

        public void ExecuteCommend(ICommand command) 
        {
            throw new NotImplementedException();
        }

        public void CreateUI() 
        {
            throw new NotImplementedException();
        }
    }
}
