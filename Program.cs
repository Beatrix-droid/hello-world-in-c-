using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CubeIt(8)); //call functions you created into main mehtod(or main function to execute them)
            int cubed= CubeIt(3);
            Console.WriteLine(cubed);
        
        //if statements
            bool isFemale=true;

            //general structure of an if statement  if (condition){code for that condition}
            if (isFemale){
                Console.WriteLine("is a female");
            }        

        }

        // we can also have methods that return things. in which case we will not put "void" next to statci but the data type we want to return. here in the cubing function we are returning an int, so static int

        static int  CubeIt(int number){    // this method will not return any info, but jst print to the console (methods are functions in c#)
            int result = number*number*number;
            return result;
        }
    }
}
