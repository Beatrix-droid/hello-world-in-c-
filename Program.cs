using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
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
            SayHi("John"); //call functions you created into main mehtod(or main function to execute them)
        }
        static void  SayHi(string name){    // this method will not return any info, but jst print to the console (methods are functions in c#)
            Console.WriteLine("Hi " + name);
        }
    }
}
