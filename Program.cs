internal class Program
{
    private static void Main(string[] args)
    {

        //Task 1
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);

        Console.WriteLine();

        GetEvenOrOdd(23);

        Console.WriteLine();

        PrintNumbers();

        Console.WriteLine();

        //TASK 2
        void GetEvenOrOdd(int num)
        {
            Console.WriteLine("Input a number to check if it is odd or even number:");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Input numbers alone!!!");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        //TASK 3
        void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //TASK 4
        int[] array= {2,4,6,8,10};

        //Pint the sum of all elements.
        Console.WriteLine(array.Sum());

        //Print each element
        foreach(int i in array) Console.WriteLine(i);

        Console.WriteLine();

        Greet("Alice");
    }

    //TASK 5
    static void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}