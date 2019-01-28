using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 ---------Welcome to Andrew's Fishing simulator!---------");
            Fishing();
        }
        static void Fishing()
        {
            start:
            Console.WriteLine("\nChoose your fishing location!\n\n  [1] -The dock-\n\n  [2] -The boat- \n\n  [3] -Exit-");
            double answer;
            double.TryParse(Console.ReadLine(), out answer);
            
            switch (answer)
            {
                case 1:
                    TheDock dock = new TheDock();
                    dock.Dock(); 
                    break; 
                case 2:
                    TheBoat boat = new TheBoat();
                    boat.Boat();
                    break;
                case 3:
                    goto end;
                default:
                 Fishing();
                    break;


            }
            goto start;
        end:;
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

        
       
        
    }
}
