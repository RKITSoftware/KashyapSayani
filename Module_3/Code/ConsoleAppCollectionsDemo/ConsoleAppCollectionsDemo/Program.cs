using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppCollectionsDemo
{
    class ArrayListDemo
    {
        void addElement()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);


            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

           // Adding Entire Array / ArrayList into ArrayList
            var arlist3 = new ArrayList();

            var arlist4 = new ArrayList()
                    {
                        1, "Bill", " ", true, 4.5, null
                    };

            int[] arr = { 100, 200, 300, 400 };

            // Queue Insertion
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist3.AddRange(arlist2); //adding arraylist in arraylist
            arlist3.AddRange(arr); //adding array in arraylist 
            arlist3.AddRange(myQ); //adding Queue in arraylist

            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist.Insert(1, "Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);


            //Insert Collection in ArrayList
            ArrayList arlist5 = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist6 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist5.InsertRange(2, arlist6);

            foreach (var item in arlist5)
                Console.Write(item + ", "); //output: 100, 200, 300, 400, 500, 600, 
        }

        void accessingElement()
        {
            //Accessing Elements of ArrayList
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            string secondElement = (string)arlist[1]; //returns "Bill"
                                                      //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var firstElement1 = arlist[0]; //returns 1
            var secondElement1 = arlist[1]; //returns "Bill"
                                           //var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            arlist[0] = "Steve";
            arlist[1] = 100;
            //arlist[5] = 500; //Error: Index out of range
        }

        void iterateArrayList()
        {
            //Iterate ArrayList
            ArrayList arlist = new ArrayList()
                        {
                            1,
                            "Bill",
                            300,
                            4.5F
                        };

            foreach (var item in arlist)
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

            for (int i = 0; i < arlist.Count; i++)
                Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 
        }

        void removeElement()
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

            arList.Remove(null); //Removes first occurance of null
            arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
        }

        void checkElementInArray()
        {
            //Check for Elements
            ArrayList arList = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList.Contains(300)); // true
            Console.WriteLine(arList.Contains("Bill")); // true
            Console.WriteLine(arList.Contains(10)); // false
            Console.WriteLine(arList.Contains("Steve")); // false
        }
    }

    class List
    {
        void addingElement()
        {
            //Adding elements in List
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            /*Add Custom Class Objects in List
                var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            }; */

            //Add Arrays in List
            string[] cities_ = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);
        }

        void accessingList()
        {
            //Accessing List
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
        }

        void removeElement()
        {
            //Remove elements from List
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes the first 10 from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers)
                Console.Write(el); 
        }

        void checkElements()
        {
            // Check Elements in List

            var numbers = new List<int>() { 10, 20, 30, 40 };
            numbers.Contains(10); // returns true
            numbers.Contains(11); // returns false
            numbers.Contains(20); // returns true
        }
    }

    class DictionaryDemo
    { 
        void addElement()
        {
            //Create Dictionary and Add Elements
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
};

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        void accessElement()
        {
            //Access Dictionary Elements
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }
        }

        void updateDisctionaryElement()
        {
            //Update Dictionary Elements
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
};

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
        }

        void removeElement()
        {
            //Remove Dictionary Elements
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
};

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
        }
    }

    class HashtableDemo
    {
        void addElement()
        {
            //Create and Add Elements
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
};

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //Add Dictionary in Hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);
        }

        void updateHashtable()
        {
            
            //creating a Hashtable using collection-initializer syntax
            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
};

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
        }

        void removeHashtable()
        {
            //Remove Elements from Hashtable
            var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
};

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
        }
    }

    class StackDemo
    {
        void createStack()
        {
            //Create and Add Elements in Stack
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.Write(item + ","); //prints 4,3,2,1, 

            //ou can also create a Stack from an array, as shown below.
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack2 = new Stack<int>(arr);

            foreach (var item in myStack2)
                Console.Write(item + ","); //prints 4,3,2,1, 
        }

        void accessElement()
        {
            //Access Stack using Pop()
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
                Console.Write(myStack.Pop() + ",");

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            //Retrieve Elements usign Peek()
            Stack<int> myStack3 = new Stack<int>();
            myStack3.Push(1);
            myStack3.Push(2);
            myStack3.Push(3);
            myStack3.Push(4);

            Console.Write("Number of elements in Stack: {0}", myStack3.Count);// prints 4

            if (myStack3.Count > 0)
            {
                Console.WriteLine(myStack3.Peek()); // prints 4
                Console.WriteLine(myStack3.Peek()); // prints 4
            }
            Console.Write("Number of elements in Stack: {0}", myStack.Count);// prints 4
        }

        void contains()
        {
            //Contains()
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            myStack.Contains(2); // returns true
            myStack.Contains(10); // returns false
        }
    }

    class QueueDemo
    {
        void createQueue()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); //prints 1234
        }

        void readingQueue()
        {
            //Reading Queue
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0

            //Peek()
            Queue<string> strQ1 = new Queue<string>();
            strQ1.Enqueue("H");
            strQ1.Enqueue("e");
            strQ1.Enqueue("l");
            strQ1.Enqueue("l");
            strQ1.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ1.Count); //prints 5

            if (strQ1.Count > 0)
            {
                Console.WriteLine(strQ1.Peek()); //prints H
                Console.WriteLine(strQ1.Peek()); //prints H
            }

            Console.WriteLine("Total elements: {0}", strQ1.Count); //prints 0
        }

        void contains()
        {
            //Contains()
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            callerIds.Contains(2); //true
            callerIds.Contains(10); //false
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
