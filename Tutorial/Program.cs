namespace Tutorial;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1) Prime numbers calculator\n2) Avarage calculator\n3) test your luck");
        switch (Console.ReadLine())
        {
            case "1":
                PrimeNumbers.PrimeNumberCalc();
                break;
            case "2":
                Avarage.AvarageCalc();
                break;
            case "3":
                RandomNumber.Guesser();
                break;
        }
    }
}