internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //ForLoop();
        //  WhileLoop();
        // DoWhileLoop();
        //foreachLoop();
        if (IsPrimeNumber(7)) 
        {
            Console.WriteLine("This is a prime number");
        }
        else 
        {
            Console.WriteLine("This is not a Prime number");
        }

        Console.ReadLine();


    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int  i= 2; i < number-1; i++) 
        {
            if (number % i ==0) 
            {
            result = false;
                i = number;
                //break;
            
            }
        }

        return result;
    }

    private static void foreachLoop()
    {
        string[] students = new string[3] { "Engin 2", "Derin  2", "Salih 2" };
        foreach (string student in students)
        {
            Console.WriteLine(student);

        }
    }

    static void ForLoop()
    {
        for (int i = 100; i >= 0; i = i - 2)
        {
            Console.WriteLine(i);

        }
        Console.WriteLine("Finished!");
    }
    static void WhileLoop()
    {
        int number = 100;

        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}" + number);
    }
     static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 11);
    }

}