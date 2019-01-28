using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;


namespace Fishing
{
    public class TheDock
    {
        public async void Dock()
        {
            start:
            Random random = new Random();
            Console.WriteLine("Welcome to the dock. Would you like cast your line?\n\n [1] for yes\n\n [2] for no");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);

            switch (answer)
            {
                case 1:
                    goto cast;
                case 2:
                    goto end;
            
                default:
                goto start;
            }
        cast:
            int cast = random.Next(0, 3);
            if (cast == 0)
            {
                Console.WriteLine("You cast your line out...");
                Task.Delay(1000).Wait();
                Console.WriteLine(".");
                Task.Delay(1000).Wait();
                Console.WriteLine(".");
                Task.Delay(1000).Wait();
                Console.WriteLine(".");
                Task.Delay(1000).Wait();
                Console.WriteLine(".");
                Task.Delay(1000).Wait();
                Console.WriteLine(".");
                Task.Delay(1000).Wait();
                Console.WriteLine("Nothing...");
                Task.Delay(2000).Wait();
                Console.WriteLine("\n  [1] -Cast again- \n\n  [2] -Stop-");
                again:
                double again;
                double.TryParse(Console.ReadLine(), out again);
                switch (again)
                {
                    case 1:
                        goto cast;
                    case 2:
                        goto start;
                    default:
                        goto again;

                }
                
            }
            else

            Console.WriteLine("You cast your line out...");
            Task.Delay(1000).Wait();
            Console.WriteLine(".");
            Task.Delay(1000).Wait();
            Console.WriteLine(".");
            Task.Delay(1000).Wait();
            Console.WriteLine(".");
            Task.Delay(1000).Wait();
            Console.WriteLine(".");
            Task.Delay(1000).Wait();
            Console.WriteLine(".");
            Task.Delay(1000).Wait();
            Console.WriteLine("You feel a bite!");
            Task.Delay(500).Wait();
            Console.WriteLine("Press enter to reel the fish in!");
            Console.ReadLine();
          
            int fish = random.Next(0, 10);
            if (fish == 0)
            Console.WriteLine($"You caught a Blue Gill!\n\n Weighing 2 Lbs.");
            
            if (fish == 1)
                Console.WriteLine($"You caught a Blue Gill!\n\n Weighing 5 Lbs!");
            
            if (fish == 2)
                Console.WriteLine($"You caught a Blue Gill!\n\n Weighing .5 Lbs.");
            
            if (fish == 3)
                Console.WriteLine($"You caught a Small Mouth Bass!\n\n Weighing 7 Lbs.");
           
            if (fish == 4)
                Console.WriteLine($"You caught a Small Mouth Bass!\n\n Weighing 11 Lbs!");
            
            if (fish == 5)
                Console.WriteLine($"You caught a Large Mouth Bass!\n\n Weighing 12 Lbs.");
            
            if (fish == 6)
                Console.WriteLine($"You caught a Large Mouth Bass!\n\n Weighing 16 Lbs!");
           
            if (fish == 7)
                Console.WriteLine($"You caught a Catfish!\n\n Weighing 8 Lbs.");
           
            if (fish == 8)
                Console.WriteLine($"You caught a Catfish!\n\n Weighing 14 Lbs!");
            
            if (fish == 9)
                Console.WriteLine($"You caught...\n\n\n..An old boot...");
            
            if (fish == 10)
                Console.WriteLine($"You caught a...\n\n\n..Seaweed...");
            Task.Delay(2000).Wait();
            
        swi:
            Console.WriteLine("\n\nPress [1] to cast again or [2] to go back!\n\n  [1] -Cast Again- \n\n  [2] -Go Back-");
            double answer1;
            double.TryParse(Console.ReadLine(), out answer1);
            switch (answer1)
            {
                case 1:
                    goto cast;
                case 2:
                    goto end;
                default:
                    goto swi;
                    
            }
                
        end:
            Console.WriteLine("");
        }
    }
}
