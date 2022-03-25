namespace Tutorial;

public class RandomNumber
{
    public static void Guesser()
    {
        Random rand = new Random();
        Console.WriteLine("Guesse a number between 1 and 10");
        byte randomNumber = Convert.ToByte( rand.Next(1, 10) );
        byte input = Convert.ToByte(Console.ReadLine());
        byte i = 1;
        while (randomNumber != input)
        {
            input = Convert.ToByte(Console.ReadLine());
            i++;
        }

        if (i <= 4)
            Console.WriteLine("Nice! You only needed" + i + "tries");
        else
            Console.WriteLine("Really? You needed " + i + " tries?");
    }
}