using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
        int index=1;
        while (index <= 5){
            Console.WriteLine(index);
            index++;
        }

        int index_2 = 6;
        //this is a do while loop, first executes code, and then checks the condition. This loop will print out 6 and then stop

        do{
            Console.WriteLine(index_2);
            index_2 ++;
        } while (index_2 <=5);
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

        static string GetDay(int dayNum){
            //learning about switch statements
            string DayName;
            
            switch(dayNum){
                case 0:
                    DayName= "Sunday";
                    break; //reserved keyword, break out of the structure we are currently in//
                case 1:
                    DayName = "Monday";
                    break;
                case 2:
                    DayName = "Tuesday";
                    break;
                case 3:
                    DayName = "Wednesday";
                    break;
                case 4:
                    DayName = "Thursday";
                    break;
                case 5:
                    DayName = "Friday";
                    break;
                case 6:
                    DayName = "Saturday";
                    break;
                default:
                    DayName= "Invalid day number entered";
                    break;

            }
            return DayName;
        }
    }
}
