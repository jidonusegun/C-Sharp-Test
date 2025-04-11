namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("**************** Task 1 ****************");
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;
            Console.WriteLine($"{name}, {age}, {isAdmin}");

            //Task 2
            Console.WriteLine("**************** Task 2 ****************");
            Console.WriteLine("Enter a number");
            int inputNumber = int.Parse(Console.ReadLine());

            if(inputNumber % 2 == 0)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }

            //Task 3
            Console.WriteLine("**************** Task 3 ****************");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Task 4
            Console.WriteLine("**************** Task 4 ****************");
            int[] numArray = { 2, 4, 6, 8, 10 };
            int sumValue = 0;

            foreach(int num in numArray)
            {
                sumValue += num;
            }

            Console.WriteLine($"Total sum: {sumValue}");

            //Task 5
            Console.WriteLine("**************** Task 5 ****************");
            Greet("Alice");

            Console.ReadKey();
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
