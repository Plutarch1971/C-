// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
namespace MyApp.Data{
    class Program{
        static void Main(string[] args){
            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
            { "firstInning", 10},
            { "secondInning", 20},
            {"thirdInning", 30},
            {"fourthInning", 40},
            {"fifthInning", 50}
            };

            Console.WriteLine("-----------------");
            Console.WriteLine("  My Score Board ");
            Console.WriteLine("-----------------");
            Console.WriteLine("  Innings | Score ");
            Console.WriteLine("   1      |  {0} ", myScoreBoard["firstInning"] );
            Console.WriteLine("   2      |  {0} ", myScoreBoard["secondInning"] );
            Console.WriteLine("   3      |  {0} ", myScoreBoard["thirdInning"] );
            Console.WriteLine("   4      |  {0} ", myScoreBoard["fourthInning"] );
            Console.WriteLine("   5      |  {0} ", myScoreBoard["fifthInning"] );
            
        }
    }
}

