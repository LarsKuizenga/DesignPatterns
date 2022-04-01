
namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Holds windows form, controller and all other classes related to frontend related functionality.
    /// Allows easy access to frontend to execute commands.
    /// </summary>
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
