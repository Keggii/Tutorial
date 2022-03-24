namespace Tutorial;

public class Avarage
{
    public static void AvarageCalc()
    {
        Console.WriteLine("from what numbers do you wanna have the avarage? (split them with space)");
        String[] numbers = Console.ReadLine().Split(" ");
        int avarage = 0;
        int j = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            avarage += Convert.ToInt32(numbers[i]);
            j++;
        }

        avarage /= j;
        Console.WriteLine(avarage);
    }
}