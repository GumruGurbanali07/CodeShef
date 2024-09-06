
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

Healthy Sleep
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

Saving Taxes
using System;

public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}

---------------------------------------------------------------------------------------------

Water Consumption
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            string result = (x >= 2000) ? "YES" : "NO";
            Console.WriteLine(result);
        }


    }
}

---------------------------------------------------------------------------------------------

Masterchef finals
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            string result = (x >= 10) ? "NO" : "YES";
            Console.WriteLine(result);
        }
    }
}

---------------------------------------------------------------------------------------------

Biryani classes
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            Console.WriteLine(x * y);
        }
    }
}

---------------------------------------------------------------------------------------------

Fitness
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            Console.WriteLine(x * 10);
        }
    }
}

---------------------------------------------------------------------------------------------

Chef Plays Ludo
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            string result = (x >= 6) ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }
}

---------------------------------------------------------------------------------------------

Burgers
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            int result = Math.Min(x, y);
            Console.WriteLine(result);
        }
    }
}

---------------------------------------------------------------------------------------------

How many unattempted problems
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int x = int.Parse(st[0]);
        int y = int.Parse(st[1]);
        Console.WriteLine(x - y);

    }
}

---------------------------------------------------------------------------------------------

Yoga Day
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 12)
        {
            Console.WriteLine(n / 12);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

---------------------------------------------------------------------------------------------

International Justice Day
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int x = int.Parse(st[0]);
        int y = int.Parse(st[1]);
        string result = (x >= y) ? "YES" : "NO";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------

Determine the Score
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            Console.WriteLine((x / 10 * y));
        }
    }
}

---------------------------------------------------------------------------------------------

404 Not Found
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = (n == 404) ? "Not Found" : "Found";
        Console.WriteLine(result);
    }
}

---------------------------------------------------------------------------------------------

Off By One
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int n = int.Parse(st[0]);
        int m = int.Parse(st[1]);
        int result = (n + m) * 10 + 1;
        Console.WriteLine(result);

    }
}

---------------------------------------------------------------------------------------------

International Education Day!
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int x = int.Parse(st[0]);
        int y = int.Parse(st[1]);
        int z = int.Parse(st[2]);
        int n = x * z;
        int m = y * z;

        if (n > m)
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(m);
        }

    }
}

---------------------------------------------------------------------------------------------

Writing Speed
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (5 * n <= 60)
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

Donation Drive
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            Console.WriteLine(x - y);
        }
    }
}

---------------------------------------------------------------------------------------------

Sports Section
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 8 || n == 9 || n == 10)
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

Fan Poll
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int a = int.Parse(st[0]);
        int b = int.Parse(st[1]);
        int c = int.Parse(st[2]);
        if (a > b && a > c)
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

Tax in Chefland
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            if (x <= 100)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x - 10);
            }
        }
    }
}

---------------------------------------------------------------------------------------------

Reach on Time
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            if (x >= 30)
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

Puzzle Hunt
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 6 && n <= 8)
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

Algomaniac Finals
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 17)
        {
            Console.WriteLine("YAY");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

---------------------------------------------------------------------------------------------

Overspeeding
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 40)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

---------------------------------------------------------------------------------------------

Bone Appetit
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            string[] st2 = Console.ReadLine().Split(' ');
            int a = int.Parse(st2[0]);
            int b = int.Parse(st2[1]);
            Console.WriteLine(x * a + y * b);
        }
    }
}

---------------------------------------------------------------------------------------------

Who is taller!
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            string[] st = Console.ReadLine().Split(' ');
            int c = int.Parse(st[0]);
            int d = int.Parse(st[1]);
            if (a > b)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }
            if (c > d)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }

        }
    }
}

---------------------------------------------------------------------------------------------

RCB vs CSK
public class Test
{
    public static void Main()
    {
        string[] st = Console.ReadLine().Split(' ');
        int a = int.Parse(st[0]);
        int b = int.Parse(st[1]);
        if (a - b >= 18)
        {
            Console.WriteLine("RCB");
        }
        else
        {
            Console.WriteLine("CSK");
        }
    }
}

---------------------------------------------------------------------------------------------

IOI 2024
public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 8)
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


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}

---------------------------------------------------------------------------------------------


public class Test
{
    public static void Main()
    {

    }
}
