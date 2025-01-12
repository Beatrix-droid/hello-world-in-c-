﻿using System;
using System.Collections;
using System.Collections.Generic;



namespace dotnetcore
{
     //interfaces = an interface defines a "contract" that all classes inheriting from should follow.
        
    //an interace declares what a class "should have"
    // an intehriting class defines "how it should do it"


    // to create an interface type "interface" and then the name of the interface, precedded with an I

    interface IPrey{
        //if you are prey you need a method to flee from predators

        void Flee(); // we have declared it but not implemented it. That is the job of the class that wants to use it.
        // the rabbit class will inherit from this interface
    }

    interface IPredator{
        void Hunt();//implementing the method is the job of the class
    }
    
    class Rabbit: IPrey{
            //implement flee meehthod here
            public void Flee(){
                Console.WriteLine("The rabbit runs away");
            }
    }
   
    class Hawk: IPredator{
        public void Hunt(){
            Console.WriteLine("The hawk hunts");
        }
    }

        //fish can be both prey and predators so will inherit from both interfaces
     // this is the benefit of interfaces: you cna inherit from multiple interfaces unlike with standard class inheritance
    
    //auto implemented properties: shortuct when no additional logic is required in the property
    //you do not have to define a field or property, you only have to write get and/or set inside the property.
    
     class Fish: IPrey, IPredator {
         public void Hunt(){
            Console.WriteLine("The fish hunts");
        }

        public void Flee(){
                Console.WriteLine("The fish swims away");
            }

    }

    //abstract is a kyeword that you can apply to methods and classes
    //It is a modifier used in calsses to signify taht they are incomplete
    // the italian chef is a complete implemetnation of a class.
    // we want to prevent people from picking generic implementations of the chef class (the generic chef) and only pick specific ones (like the italian chef)
    // we will do this by using the abstract keyword
    
    // modifier that iindicates missing components or incomplete implementation
    abstract class GenericChef{
        public void CookFood(){
            Console.WriteLine("chef can cook food");
        }
    }
    class Chef: GenericChef{
        public void MakeChicken(){
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad(){
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish(){
            Console.WriteLine("The chef makes a special dish");
        
        }
    }
    
    // can do everything that the normal chef can do but can also specifically make italian food as well!
    // so italian chef inherits from the "normal" chef class
    //use colons to inherit from Chef class
    class Italianchef: Chef{
            public void MakePasta(){
                Console.WriteLine("Make Pasta!");
            }
            public override void MakeSpecialDish(){
            Console.WriteLine("The italian chef makes an italian special dish");
        
        }
    }

    class Japanesechef: Chef{
        public void MakeSushi(){
            Console.WriteLine("the japanese chef is making sushi");
        }
    }

    //italian chef can make pasta but not the normal chef.
    //Suppose that the italian chef's special dish is different from the regular chef's dish. Need to modify
    // or  overwrite that dish for the italian dish. You can fix this by copying the spoecial
    //dish methiod in the chef class into the italian chef class and using teh voveride keyword
// bThe "Virtual" keyword is used to modify a methid, property indexer or declaration so that it can be ovverridden by another class.

    class UsefulTools{

        //inheritance

        public static void SayHi(string name){
            Console.WriteLine("hello" + name);
        }
    }
    // can access this class by UsefulTools.SayHi("Mike) to printout "hello Mike"
    
    //static methods are methods that belong to a class themselves
    //don't have to create an object in that class to access the method and use it


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


        public Student(string name, string major, double gpa){
            this.name=name;
            this.major=major;
            this.gpa=gpa;
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

            //a function that changes the title of a book object
            static void Change_title(Books book, string title){
            book.title=title;
            }

            

            //arrays of objects. We initialise one exactly like we did in the past for varaibles.
            //specify the object type in the array (in our case chefs):

            // an array of chefs with index3

            Chef chef1= new Chef();
            Chef chef2 = new Chef();
            Chef chef3 = new Chef();

            
            //and tis is ow you create an array of obejcts
            Chef[] brigade = new Chef[3];
            brigade[0]=chef1;
            brigade[1]=chef2;
            brigade[2]=chef3;

            //polymorphisms  suppose we now want to create an array of multiple types
            // of chef (of italian chefs and japanese chefs). We can't create an array like before, because the array
            //can only contain one data type, so only one chef type.

            Japanesechef jchef= new Japanesechef();
            Italianchef ichef = new Italianchef();

            // we can enter them in an array by finding what they have in common. Thye
        // all identify as chefs, because they all inherit from the chef class. These objects have more
        // than one form because they can be identified in multiple ways.

        // so create an array of chefs!

        Chef[] chefs = new Chef[2];


    

            //inheritance

            Chef chef = new Chef();
            chef.MakeChicken();


            //static methods
           // can access this class by UsefulTools.SayHi("Mike) to 
           //printout "hello mike" without declaring an instance of the UsefullTools class

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
