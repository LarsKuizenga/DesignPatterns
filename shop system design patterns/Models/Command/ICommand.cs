
namespace FrenchutoShop.Models.Command
{
    /// <summary>
    /// Interface to allow the Application class to give easy access to commands from the frontend.
    /// </summary>
    interface ICommand
    {
        void Execute(Application application);
    }
}
