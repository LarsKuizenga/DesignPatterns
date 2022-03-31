using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenchutoShop.Models
{
    class Application
    {
        public TimeStamp TimeStamp;
        public Controller Controller { get; set; }

        public FrenchutoForm FrenchutoForm { get; set; }

        public Application(Controller controller, FrenchutoForm frenchutoForm)
        {
            Controller = controller;
            FrenchutoForm = frenchutoForm;
            TimeStamp = new TimeStamp(1, 8, 20);
        }

        public void ExecuteCommend(ICommand command) 
        {
            command.Execute(this);
        }
    }
}
