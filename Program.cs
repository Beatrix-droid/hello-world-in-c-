using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing to the console with writeline//
            Console.WriteLine("Hello World!");
           
           //types of variables strings and ints and how to declare them//

            string CharacterName = "John";
            int CharacterAge=11;

            Console.WriteLine("There once was a man named "+ CharacterName + " and he was " + CharacterAge +" years old.");
            

            // you can also create variables, assing them a type and map them to a vlaue later on. Here we have created a//
            // string variable called "name" and only later assigned it to a user input function"//
            string name;
            name=Console.ReadLine(); //console readline is used to get user input
            
            Console.WriteLine(name);

            //data types in c# :
            ///////////text////
            // string: denoted by opening and closing quotation marks//
            // character (char) a single caracter. for this we want to use single quotation marks'//

            //for numbers we have 3 data types that store numbers: integer float, decimal. and double//

            //an integer (int) is a whole number, can also do negative numbers//
            //decimals can be stored in floats, doubls or decmals. these range from least accurate to most acurate//

            // we also have boolean  (bool) (true false values)



        
        }
    }
}
