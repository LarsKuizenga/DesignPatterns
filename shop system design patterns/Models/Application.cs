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
        public Store Store { get; set; }
        
        public Application(EventLog eventLog, Store store)
        {
            EventLog = eventLog;
            Store = store;
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
