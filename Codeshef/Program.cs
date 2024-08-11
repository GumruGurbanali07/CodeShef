
using System;

Christmas Greetings
public class Test
{
    public static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());

        if (x == 25)
        {
            Console.WriteLine("CHRISTMAS");
        }
        else
        {
            Console.WriteLine("ORDINARY");
        }
    }
}

-----------------------------------------------------------------------------------------

Food Costs
public class Test
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int x = Convert.ToInt32(inputs[0]);
        int y = Convert.ToInt32(inputs[1]);
        int z = x * 6 + y;
        Console.WriteLine(z);
    }
}

-------------------------------------------------------------------------------------------

Number Mirror
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);
    }
}

-------------------------------------------------------------------------------------------

Cricket World Cup Qualifier
public class Test
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x >= 12)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

-------------------------------------------------------------------------------------------

Lucky Seven
public class Test
{
    public static void Main()
    {
        string S = Console.ReadLine();
        if (S.Length == 10)
        {
            Console.WriteLine(S[6]);
        }
        else
        {
            Console.WriteLine("False");
        }

    }
}

-------------------------------------------------------------------------------------------

The Ides of March
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 15)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

-------------------------------------------------------------------------------------------

Codechef Round
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 4)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

-------------------------------------------------------------------------------------------

Clear Day
public class Test
{
    public static void Main()
    {
        string inputs = Console.ReadLine();
        string[] input = inputs.Split(' ');
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int z = 7 - (x + y);
        Console.WriteLine(z);
    }
}

-------------------------------------------------------------------------------------------

