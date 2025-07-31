using MVC_Learn.Controllers;
using MVC_Learn.Views;

namespace MVC_Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ConsoleContactView();
            var controller = new ContactController(view);
            controller.Run();
        }
    }
}
