using System;



namespace dotnetcore
{

     public class Books
    {
        public string title;
        public string author;

        public Books(string author, string title){
            Console.WriteLine("Creating book");
        }

    }

    public class Student{
        public string name;
        public string major;
        public double gpa;


        public Student( string aname, string amajor, double agpa){
            name=aname;
            major=amajor;
            gpa=agpa;

        }
        
        //create a class method that checks if a particualr student is on the honour roll (gpa greater than 3.5)
        public bool HasHonours(){
            if (gpa >=3.5){
                return true;
            }
            return false;
        }
    }





















    class Program
    {
        static void Main(string[] args)
        {

            //creating two students
            Student student1 = new Student("Pam", "maths", 4.0);
            Student student2 = new Student("jim", "art", 3.2);


            Console.WriteLine(student1.HasHonours());
            //creating a book object (variabe is of type book)
            Books book1 = new Books("The Picture of Dorian Grey", "Oscar Wilde");


                // don't need to manually set these attributes any more, can direclty initialise them with constuctor
            /* book1.title = "The picture of Dorian Grey"; */
            /*      book1.author= "Oscar wilde";
 */
            Books book2 = new Books("Lord of the rings", "Tolkien");
        /*    book2.title = "Lord of the Rings";
            book2.author= "Tolkein"; */


            


            //printing out attributes of the class

            Console.WriteLine($"{book1.author}{book2.title}"); // the $ and " are the equivalent of f strings in python
            Console.WriteLine($"Using a $ sgn that precedes quotation marks ina  string with a variable in curly braces inserted into the string (such as this one {book2.author} is like using f strings in python.) ");
            

            /// READ, READLINE READKEY, WRITE, WRITELINE, WRITE KEY DIFFERENCES
            //readline reads all characters unti the end of the line (the whole string)
            //read reads the next character from the standard input stream, only accepts a single character from user input, and returns its ascii code
            //readkey obtains the next character or function key pressed by the user and returns its name. It does not require to press the neter key before entering


            //write (writes the string)
            //write line writes the line and adds a new string
            //write key just writes one character


            //exception handling
            
            Console.Write("Enter a number");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number");
            int num_2 = Convert.ToInt32(Console.ReadLine());


            try{
                Console.Write(num_1/num_2);
                }

            
        /*    catch(Exception e){
                Console.Write(e.Message);  //print out the error message  but can also define specific exceptions
            }
 */         catch(DivideByZeroException){ //do something when this specific exception occurs (ie divide by 0)
                Console.Write("You attempted to divide by 0");
}
            catch(FormatException){
                Console.Write("You did not enter a number"); // do something when user enters string instead of number
            }
            finally {//optional block of code after try cath that gets executed no matter what
                    Console.Write("Thanks for using the calculator");
            }






        //two dim arrays//
        //Here is how you init one://

        int [,] TwoDimArr ={
            {1, 2},
            {2, 3},
            {4, 5}
        };

        //accessing the array//
        Console.WriteLine(TwoDimArr[0, 1]);  //row 0 column 1 prints out 2//
        Console.WriteLine(TwoDimArr[2, 1]);  //row 2 column 1 prints out 5//

        //like before can creat a new arrayw ithout populating it immediately so long you specify the dimensions//
        int[,] myArray= new int[2,3]; //array of two rows and three columns//




        
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
