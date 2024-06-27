namespace Calculations_On_Collections;

public class Program
{
    public static void Main()
    {
        Random r = new();
        List<int> listOfNums = new();
        int len = r.Next(50, 150);

        for (int i = 0; i < len; i++)
            listOfNums.Add(r.Next(100));

        /* None of these methods are part of the .NET
        collections classes…they’re all defined by LINQ. */
        Console.WriteLine("There are {0} numbers", listOfNums.Count());
        Console.WriteLine("There are {0} numbers", listOfNums.Min());
        Console.WriteLine("There are {0} numbers", listOfNums.Max());
        Console.WriteLine("There are {0} numbers", listOfNums.Sum());
        Console.WriteLine("There are {0:F2} numbers", listOfNums.Average());

        var under50sorted =
            from num in listOfNums
            where num < 50
            orderby num descending
            select num;

        List<int> newList = under50sorted.ToList();
        var firstFive = under50sorted.Take(15);
        List<int> shortList = firstFive.ToList();

        foreach (int n in shortList)
            Console.WriteLine(n);
        Console.ReadLine();
    }
}