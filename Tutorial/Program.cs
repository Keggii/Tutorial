namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("from where to where do you wanna know the prime numbers?");
            
            string[] betterInput = Console.ReadLine().Split(" ");
            
            for (int j = Convert.ToInt32(betterInput[0]); j <= Convert.ToInt32(betterInput[1]); j++)
            {
                bool primeNumber = true;
                for (int i = 2; i < j && primeNumber; i++)
                {
                    if (j % i == 0)
                    {
                        primeNumber = false;
                    }
                }

                if (primeNumber)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}

