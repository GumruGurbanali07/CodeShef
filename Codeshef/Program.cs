
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

Double Rent
public class Test
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(2 * x);

    }
}

---------------------------------------------------------------------------------------------

Thala For A Reason
public class Test
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x == 7)
        {
            Console.WriteLine("THALA");
        }
        else
        {
            Console.WriteLine("SADGE");

        }
    }
}

---------------------------------------------------------------------------------------------

Lucky Clover
public class Test
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = 4 + ((x - 1) * 3);
        Console.WriteLine(z);
    }
}

---------------------------------------------------------------------------------------------

Good Turn
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            if (x + y > 6)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

---------------------------------------------------------------------------------------------

Devouring Donuts
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int x = int.Parse(st[0]);
        int y = int.Parse(st[1]);
        Console.WriteLine(x * y);
    }
}

---------------------------------------------------------------------------------------------

Add Two Numbers
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            Console.WriteLine(x + y);
        }
    }
}

---------------------------------------------------------------------------------------------

Summer Time
public class Test
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        if (n > 35)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

---------------------------------------------------------------------------------------------

Advitiya
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 16 || n == 17 || n == 18)
        {
            Console.WriteLine("ADVITIYA");
        }
        else
        {
            Console.WriteLine("WAITING FOR ADVITIYA");
        }
    }
}

---------------------------------------------------------------------------------------------

AC Please
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = (x > 30) ? "YES" : "NO";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------

Election Hopes
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int x = int.Parse(st[0]);
        int y = int.Parse(st[1]);
        string result = (x >= 2 * y) ? "Yes" : "No";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------

Minimum Wage
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = (n > 11) ? "YES" : "NO";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = (n < 8) ? "LESS" : (n == 8) ? "PERFECT" : "MORE";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------

