// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace MyAppData.Array{
    class Program{
        static void Main(string[] args){
        string[] favFoods = new string[3] {"pizza", "donoughts", "icecream"};
        string firstFood = favFoods[0];
        string secondFood = favFoods[1];
        string thirdFood = favFoods[2];
        Console.WriteLine("I like {0}, {1} and {2}", firstFood, secondFood, thirdFood);

        //List
        List<string> employees = new List<string>() {
            "adam", "amly"
        };
        employees.Add("barbara");
        employees.Add("billly");
        Console.WriteLine("My employees include {0}, {1}, {2},{3}", employees[0],employees[1],employees[2],employees[3]);
        //
        //Print using for loop
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine("My employees include {0}",employees[i]);
        }
    }
}
}
