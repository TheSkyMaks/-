using System;

namespace ZNO_ukr
{
    public class MainMenu
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter number: (1)");
                int.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        var startNagolosi = new Nagolosi();
                        startNagolosi.Start();
                        return;

                    default:
                        Console.WriteLine("Error: Invalid key, try again. Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}