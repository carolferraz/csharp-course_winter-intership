namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); //The Add method will add an item at the final index of a list.
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Caroline");
            list.Add("Amanda");
            list.Add("Joanne");
            list.Add("Anna");
            list.Insert(2, "Marco"); //Using the Insert method we can specify the index it will be added.


            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");


            Console.WriteLine("List Count: " + list.Count); //The Count method show how many elements we have in our list.

            string string1 = list.Find(Test); //The method Find needs as a parameter a predicate (another method) that specifies what we are going to find. In these case we are using the Test (line 32) method as predicate.

            Console.WriteLine("First A: " + string1);
            static bool Test(string s)
            {
                return s[0] == 'A'; //Here we are saying that this method returns when we find the first string that starts (so we have an index [0] here) with an A.
            }
            

            string string2 = list.Find(item => item[0] == 'A'); //Using it with the lambda expression, we say the same as on 29 line, but concisely. 
            Console.WriteLine("First started by A letter using lambda: " + string2);


            string string3 = list.FindLast(item => item[0] == 'A'); //Finds the last element that starts with an A letter.
            Console.WriteLine("Last started by A letter using lambda: " + string3);

            int position = list.FindIndex(item => item[0] == 'A'); //FindIndex returns the position of the first element that meets our condition. Remember to use the correct type (int) when declaring the variable.
            Console.WriteLine("First position started by A letter: " + position);
            
            int position2 = list.FindLastIndex(item => item[0] == 'A'); //Here we are finding the last element that meets our condition, and returning his position.
            Console.WriteLine("First position started by A letter: " + position2);

            Console.WriteLine("-----------");

            List<string> list2 = list.FindAll(item => item.Length == 5); //This works like a map on JS: we create a new list and fill it with elements that we are filtering from another list, which meets our condition. On the foreach below we show the elements in the console.
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------Without Alex below -----------");

            list.Remove("Alex");
            foreach (string item in list) //Here we show all the list without Alex. Note that if we try to remove an element that is not in the list, nothing will happen.
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------Remove Caroline below -----------");

            list.RemoveAt(3); //Removes the element found at the index that we especify on the parameters.
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------List without the names that starts with M below -----------");
            
            list.RemoveAll(item => item[0] == 'M'); //Here we show all the list without the names that starts with a M letter.
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------Remove 2 elements after the index 2 -----");
            list.RemoveRange(2, 2); //Within the parameters, this method expects a position and a count of the elements to be removed (int index, int count). In these case we will remove after position 2, 2 elements.
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            
             
        }
    }
}