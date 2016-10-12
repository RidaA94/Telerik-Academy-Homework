using System;

public class Example
{
    public static void Main()
    {
        string input = Console.ReadLine();
        DateTime inputDate = DateTime.ParseExact(input, "MM.dd.yyyy", null);

        int currentAge = GetAge(inputDate);
        int ageAfter10years = currentAge + 10;

        Console.WriteLine(currentAge);
        Console.WriteLine(ageAfter10years);
    }

    private static int GetAge(DateTime date)
    {
        DateTime currentDate = DateTime.Now;

        int age = currentDate.Year - date.Year;

        if (date.Month > currentDate.Month)
        {
            age--;
        }
        else if (date.Month == currentDate.Month)
        {
            if (date.Day > currentDate.Day)
            {
                age--;
            }
        }

        return age;
    }
}