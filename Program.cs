using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num1;
            string Num2;
            
            Console.WriteLine("Please enter the first numer:");
            Num1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            Num2 = Console.ReadLine();
            
            //user input is string, must convert to int32 to perfomr the calculation
            Console.WriteLine("The result of the calculation is:");
            Console.WriteLine( Convert.ToInt32(Num1)+ Convert.ToInt32(Num2));

            Console.WriteLine("array notes");
            //initialising an array with square brackets, the type of variable the array contains, the name of the array and some curly brackets.
            int [] luckyNumbers={4, 6, 89, 3};

            //accessing arrays (specify index)
            Console.WriteLine(luckyNumbers[2]); //returns 89
        

            //you can also initiliase arrays without populating them immediately. So long as you use the "new" keyword and give the array a size (in this case it is an array of size 7)
            string []  friends=new string[7];

            //now we can populate the array
            friends[0]="Jim";
            friends[1]= "Henry";
            friends[6]= "cat";

           
        }
    }
}
