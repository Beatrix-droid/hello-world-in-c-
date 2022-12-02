using System;
using System.Collections;
using System.Collections.Generic;



namespace dotnetcore
{

    class Movie
    { //getters and settersallow us to modify and set teh code in private methods or variables

        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating){
                title=aTitle;
                director=aDirector;
                //rating=aRating;
                Rating= rating; //more secure, rating can only be set through this class
        }


        public string Rating{ // a getter and setter for the private variable rating class
                get{return rating;}
                //create a mehtod that allows peeps to modify the rating attribute only if the value they want to set is in any of these categories:
                set{if (value == "G" || value =="PG" || value =="PG-13" || value=="R" || value =="NR"){
                    rating = value;
                        }
                else{
                    rating = "NR";
                }
        }


        //we have only certain types of ratings (like PG, pG!£, R etc etc). We need a way to prevent users to insert a rating that is not in a list (like movie_1.arating= "dog")
        //this is achieved by using a PRIVATE method. PUBLIC methods and varaibles can be accessed (and thus modified) by anyone. but with PRIVATE only code isnide of the class
        //will be able to access that method/variable.
        //create a static variable by using static
    }  

    }

//static attributes: a type of attribute in a class which is shared by all instances of that class
//an attribute that is contained on the class itself rather than on the individual objects of that class. This attribute is the same across  all instances of the c
//class

    class Song{
        public string title;
        public string artist;
        public int duration;
        public static int count=0; //this is a static method

        //use "this" keyword instead of "self" like in python
        public Song(string title, string artist, int duration ){
            this.title=title;
            this.artist=artist;
            this.duration=duration;
            count++; //every time a song gets created, song count is increased by 1

        }
    }



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


            //static methods

            //here these two songsd have their own title, artist and duration, which are different from one another.
            //these are the normal attributes
            //a  static attributes would be an attribute that is 
            Song song_1 = new Song("Holiday", "Green Day", 200);
            Song song_2 = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.count); //can do this as is attrbiute that belongs to the class

            //getters and setters
            Movie movie_1 = new Movie( "The Avengers", "Joss Whedon", "PG-13");
            Movie movie_2 = new Movie("Shrek", "Adam Adamson", "PG");


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




        //lists
        //crate a list with a List keyword, and specify the type. Like before you can populate it now or later. and can additems to it alter THE DIMENSIONS OF THE LIST CAN VARY
        List<string> myList = new List<string>();


        //use the add method to add items to the list//
        myList.Add("Hello");
        myList.Add("World");

        // The first argument to InsertRange is the index where we want to insert new elements. The second is an IEnumerable (a string array).
        myList.InsertRange(1, new string[] { "frog", "snake" });
       // myList.Add(10); // Compiler Error AS 10 IS NOT OF TYPE STRING
       //lsits are accessed in much the same manner as arrays are accessed.

        //IndexOf. This determines the element index of a certain value in the List collection. 
        myList.IndexOf("frog");

        myList.Clear(); //to delete the list

        //contains method checks if a specifici value is in the list.
        myList.Contains("frog"); //will return true

        //dictionaries are initlaised like this (again can populate them later. They do not have a fixed lenght, but their type must be specified from the beginning)
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        myDictionary.Add("fred", 33); //adding a new value pair to the dict
       // myDictionary.Keys;


        myDictionary.Add("bob", 27);
        myDictionary.Add("fred", 33);

        int theAge = myDictionary["bob"];

        //TryGetValue. This is often the most efficient lookup, tests if a key is in dictionary and if it is, returns the result
        int result;
        if (myDictionary.TryGetValue("c", out result))
        {
            Console.WriteLine(result);
        }

        //foreach lets us loop over the data in a dictionary
        
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"cat", 2},
            {"dog", 1},
            {"llama", 0},
            {"iguana", -1}
        };
        
        // Part 2: loop over pairs with foreach.
        foreach (KeyValuePair<string, int> pair in data)
        {
            Console.WriteLine($"FOREACH KEYVALUEPAIR: {pair.Key}, {pair.Value}");
        }
        //getting keys:
        //s. The Keys property returns a collection of type KeyCollection, not an actual List.
        // We can convert it into a List. This property is helpful in many programs.



        var datadict = new Dictionary<string, int>()
        {
            {"cat", 2},
            {"dog", 1},
            {"llama", 0},
            {"iguana", -1}
        };
        // Store keys in a List.
        var list = new List<string>(datadict.Keys); //convert the key collection into a list object
        // Loop through the List.
        foreach (string key in list)
        {
            Console.WriteLine("KEY FROM LIST: " + key);
        }


        //count returns the number of keys in a dictionary
        var lunch = new Dictionary<string, int>() { {"carrot", 1}, {"pear", 4}, {"apple", 6}, {"kiwi", 3} };
        Console.WriteLine("COUNT: " + lunch.Count);

        //remove eliminates the key and its value if its found in the dictionary

        // Remove pear.
        lunch.Remove("pear");
        Console.WriteLine("COUNT: " + lunch.Count);


        //TryAdd add an entry only if the key is not found. It returns a bool that tells us whether the key was added.
        var items = new Dictionary<string, int>();
        // Part 1: add the string with value 1.
        bool result1 = items.TryAdd("test", 1);
        Console.WriteLine("Added: " + result1);
        
        // Part 2: the value already exists, so we cannot add it again.
        bool result2 = items.TryAdd("test", 2);
        Console.WriteLine("Added: " + result2);
        
        // Part 3: the value is still 1.
        Console.WriteLine(items.GetValueOrDefault("test"));


        //contains key this commonly-called method sees if a given string is present in a Dictionary. 

        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        
        dictionary.Add("apple", 1);
        dictionary.Add("windows", 5);
        
        // See whether Dictionary contains this string.
        if (dictionary.ContainsKey("apple")){
            int value = dictionary["apple"];
            Console.WriteLine(value);
        }

        //contains value. This method tries to find a value in the Dictionary (not a key).
        var data1 = new Dictionary<string, int>();
        data1.Add("cat", 1);
        data1.Add("dog", 2);
        // Use ContainsValue to see if the value is present with any key.
        if (data1.ContainsValue(1))
        {
            Console.WriteLine("VALUE 1 IS PRESENT");
        }


        //indexer: another way to add items to a dict
        Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
        
        // We can assign with the indexer.
        dictionary2[1] = 2;
        dictionary2[2] = 1;
        dictionary2[1] = 3; // Reassign.

        //clear method to delte dict
        dictionary.Clear();


        //the next data structure are hashample maps: Here is how you initilaise one:
         // Create a hashtable
        // Using Hashtable class  (systems.collections)
        Hashtable my_hashtable = new Hashtable();
  
        // Adding key/value pair in the hashtable
        // Using Add() method
        my_hashtable.Add("A1", "Welcome");
        my_hashtable.Add("A2", "to");
        my_hashtable.Add("A3", "GeeksforGeeks");
  
        foreach(DictionaryEntry element in my_hashtable)
        {
            Console.WriteLine("Key:- {0} and Value:- {1} ",
                        element.Key, element.Value);
        }

        // a hashtable is a non generic collection. It is defined under the System.Collections namespace unlike the dictionary, that is defiend nder System.Collections.Generic namespace.
        

        //differences between hastable and a dictionary

        //                      Hashtable	                                                                                Dictionary
        //In Hashtable, you can store key/value pairs of the same type or of the different type.	In Dictionary, you can store key/value pairs of same type
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //In Hashtable, there is no need to specify the type of the key and value.	                In Dictionary, you must specify the type of key and value.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //The data retrieval is slower than Dictionary due to boxing/ unboxing.	                 The data retrieval is faster than Hashtable due to no boxing/ unboxing.
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //In Hashtable, if you try to access a key that doesn’t present in the given Hashtable,   In Dictionary, if you try to access a key that doesn’t present in the given Dictionary, then 
        //then it will give null values.	                                                        it will give error.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //It is thread safe.	                                                                    It is also thread safe but only for public static members.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //It doesn’t maintain the order of stored values.	It always maintain the order of stored values.

        // the methods for manipulating hastbales are the same as the ones used in dictionaries


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


        //creating methods with multiple parameters:useful when you are unsure of how many parameters to pass into the function.

        //here is a function that takes in as paramters the surface areas of walls to paint and adds them together to get a total surface area. The nmber of walls may vary,
        //so the number of paramters in the function is variable: (use params keyword, and this time we pass in an array of integers)
        static int GetTotalArea(params int[] walls){
            int total=0;
            for (int i=0; i < walls.Length; i++){
                total += walls[i];
            }
            return total;
        }
        Console.WriteLine(GetTotalArea(2, 3, 58));


        //optional paramters are defined very similarly to python: Optional parameters are defined at the end of the parameter list, after any required parameters
        void ExampleMethod(int required, string optionalstr = "default string", int optionalint = 10){
            Console.WriteLine("do something");
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
