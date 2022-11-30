using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            string num_1;
            string op;
            string num_2;

            Console.WriteLine("Welcome to the simple calculator");
            Console.WriteLine("Please the the first number");
            
            num_1=Console.ReadLine();
            Console.WriteLine("Please the operator");
            op=Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            num_2= Console.ReadLine();
            Console.WriteLine(Calculate(num_1,op, num_2));
        }

        // we can also have methods that return things. in which case we will not put "void" next to statci but the data type we want to return. here in the cubing function we are returning an int, so static int
        static string Calculate(string num_1, string op, string num_2){

            string result;


            try{
                Convert.ToDecimal(num_1);
                Convert.ToDecimal(num_2);
            }
            catch(System.FormatException ex){
                Console.WriteLine("operands incorrecty entered. Please make sure to enter numbers only");
            }

            if (op =="+"){
                result=(Convert.ToDecimal(num_1) + Convert.ToDecimal(num_2)).ToString();
            }
            else if( op == "-"){
                 result=(Convert.ToDecimal(num_1) - Convert.ToDecimal(num_2)).ToString();
            }
            else if (op == "/"){
                 result=(Convert.ToDecimal(num_1)/Convert.ToDecimal(num_2)).ToString();
            }
            else if (op =="*"){
                 result=(Convert.ToDecimal(num_1) * Convert.ToDecimal(num_2)).ToString();      
            }

            else{
                result = "operators or numbers not valid. Please reenter any of the accepted ones: *, -, +, /";
            }
            return result.ToString();
        }
    }
}
