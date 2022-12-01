using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine(exponentiate(4,3));
        // for loops//
        // for i less than 5 and starting at one, with i incrementing by one each time
        for (int i=1; i <=5; i ++){
            Console.WriteLine(i);  //prints i one through//
        }

    /*   int index_2 = 6;
        //this is a do while loop, first executes code, and then checks the condition. This loop will print out 6 and then stop

        do{
            Console.WriteLine(index_2);
            index_2 ++;
        } while (index_2 <=5);
 */

        // creating a  guessing game//
        string secret_word= "giraffe";
        string guess="";
        int no_of_guesses= 3;

        /*  while(guess != secret_word){
            Console.WriteLine("enter a guess");
            guess= Console.ReadLine();
        }
        Console.WriteLine("You win"); */

        // can also do the same thing with a do while loop
        
        while(guess!=secret_word){
        
            if (no_of_guesses < 1){
                Console.WriteLine("You have run out of guesses");
                break;
            }
            else{
                Console.WriteLine("You have " + no_of_guesses.ToString() + " guesses left.");
                Console.WriteLine("Please enter a guess");
                guess= Console.ReadLine();
                no_of_guesses -= 1;
            }
        }

    //working with for loops and arrays//
    int[] numbers = {1, 12, 31, 44, 95};

    for (int i=1; i < numbers.Length; i++){
        Console.WriteLine(numbers[i]);
    }

    if (guess == secret_word){
        Console.WriteLine("You Win!");
    }

        // we can also have methods that return things. in which case we will not put "void" next to statci but the data type we want to return. here in the cubing function we are returning an int, so static int
        static string Calculate(string num_1, string op, string num_2){

            string result;


            try{
                Convert.ToDecimal(num_1);
                Convert.ToDecimal(num_2);
            }
            catch(System.FormatException){
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
    static int exponentiate( int base_num, int power_num){
        int result=1;

        for(int i=0; i< power_num; i++){
            result = result * base_num;
        }

        return result;


    }
}
}
