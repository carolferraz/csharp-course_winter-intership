namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {   //Here I create the vector of type Student that instantiates this vector with 10 elements.
            Student[] vector = new Student[10];

            Console.Write("How many rooms will be rented: ");
            int n = int.Parse(Console.ReadLine()); //N represents the number of elements that will be instantiated in the array. It can go up to ten, as the vector is length 10.


            for (int i = 1; i <= n; i++) // i represents an element, each element of the vector that is filled with a class instance is added, until reaching the total number of elements, N.
            {
                Console.WriteLine($"Aluguel #{i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine()); //The room number entered by the user represents the index of the vector in which the Student class will be instantiated with each field name and email.

                vector[room] = new Student(name, email);

            }

            Console.WriteLine("Rented rooms:");
            for (int i = 0; i < vector.Length; i++) //In this 'for', we go through the entire array of vectors and check if an index is null or not. If it is null, it goes on to the next index, until it finds one with the fields filled in, when it displays that information.
            {
                if (vector[i] != null)
                    Console.WriteLine(i + ": " + vector[i].ToString());
            }


        }
    }
}