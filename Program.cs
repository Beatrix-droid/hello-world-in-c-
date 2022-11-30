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
            bool isFemale=false;
            bool isTall=true;
            //general structure of an if statement  if (condition){code for that condition}
            if (isFemale && isTall){ // and is represented with two ampersands &&
                Console.WriteLine("is a female and tall");
            }   
            else{
                Console.WriteLine("You are not tall or female");
            }     
            if (isFemale || isTall){ //or is represented by ||
                Console.WriteLine("You are either female or tall.");
            }
            //negation operator represente by a ! that you place in front of the variable name

            Console.WriteLine(Maxit(3,7,3));
        }

        // we can also have methods that return things. in which case we will not put "void" next to statci but the data type we want to return. here in the cubing function we are returning an int, so static int

        static int  CubeIt(int number){    // this method will not return any info, but jst print to the console (methods are functions in c#)
            int result = number*number*number;
            return result;
        }
        
        static string Maxit(int n1, int n2, int n3){

               string T;
                if (n1 >= n2 && n1==n3){
                    T= n1.ToString() + n3.ToString() + " are equal";
                }
                else{
                    T=n2.ToString();
                }
            return T.ToString();

        }
    }
}
