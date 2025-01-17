using System;

namespace GameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.MainController mainController = new Controllers.MainController();
            mainController.Run();
        }
    }
}
