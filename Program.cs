using System.Drawing;

class Program
{
    static void Main()
    {
        bool isStudent = true; //שלב 1 סעיף 1
        bool isWeekend = true;

        Console.WriteLine(isStudent && isWeekend); //שלב 1 סעיף 3
        Console.WriteLine(isStudent && !(isWeekend));
        Console.WriteLine(!(isStudent) && isWeekend);
        Console.WriteLine(!(isStudent) && !(isWeekend));


        Console.WriteLine(isStudent || isWeekend);
        Console.WriteLine(isStudent || !(isWeekend));
        Console.WriteLine(!(isStudent) || isWeekend);
        Console.WriteLine(!(isStudent) || !(isWeekend));


        Console.WriteLine(!(isStudent));
        Console.WriteLine(isStudent);


        int age = 10; //שלב 2 סעיף 2
        if (age < 12)
        {
            Console.WriteLine("כניסת ילד");
        }

        if (age <= 11) //שלב 3 סעיף 1
        {
            Console.WriteLine("כניסת ילד");
        }
        else
        {
            Console.WriteLine("כניסת מבוגר");
        }
        
        if (age < 3) //שלב 3 סעיף 2
        {
            Console.WriteLine("כניסה חינם");
        }
        else if (age <= 11)
        {
            Console.WriteLine("כניסת ילד");
        }
        else if (age <= 64)
        {
            Console.WriteLine("כניסת מבוגר");
        }
        else
        {
            Console.WriteLine("כניסת פנסיונר");
        }
        
        if (age < 3) //שלב 3 סעיף 3
        {
            Console.WriteLine("כניסה חינם");
        }

        if (age >= 3 && age <= 11)
        {
            Console.WriteLine("כניסת ילד");
        }

        if (age >= 12 && age <= 64)
        {
            Console.WriteLine("כניסת מבוגר");
        }

        if (age >= 65)
        {
            Console.WriteLine("כניסת פנסיונר");
        }


        if ((age >= 65 || isStudent) && !isWeekend) //שלב 4 סעיף 1
        {
            Console.WriteLine("יש הנחה");
        }
        else
        {
            Console.WriteLine("אין הנחה");
        }


        double x = 0.1; //שלב 5 סעיף 1
        double y = 0.2;

        Console.WriteLine(x + y == 0.3);

        Console.WriteLine(Math.Abs(0.3 - (x + y)) < 0.0001); //שלב 5 סעיף 3


        Console.Write("Enter your group size: "); //שלב 6 סעיפים 1 ו- 3
        int groupSize = Convert.ToInt32(Console.ReadLine());
        if (groupSize <= 0)
        {
            System.Console.WriteLine("Group size can not be Negative or equal to zero");
        } 
        else
        {
            Console.Write("Enter your full price: ");
            double fullPrice = Convert.ToDouble(Console.ReadLine());

            double personalPrice = fullPrice / groupSize;
            Console.WriteLine(personalPrice);
        }

        Console.WriteLine(5.0 / 0); //שלב 6 סעיף 4  
        

        bool ticket = true; //שלב 8 סעיף 1
        int hight = 115;
        if (ticket)
        {
            if (age >= 8)
            {
                if (hight >= 120)
                {
                    Console.WriteLine("You can enter");
                }
                else
                {
                    Console.WriteLine("Hight must be at least 120 cm");
                }
            }
            else
            {
                Console.WriteLine("Age must be at least eight");
            }
        }
        else
        {
            Console.WriteLine("You do not have a ticket");
        }

        if (ticket == true && age >= 8 && hight>= 120) //שלב 8 סעיף 3
        {
            Console.WriteLine("You can enter");
        }
        else
        {
            Console.WriteLine("You can not enter");
        }


        Console.Write("Enter one size of the triangle: "); //שלב 9 סעיף 1
        double size1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second size of the triangle: ");
        double size2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third size of the triangle: ");
        double size3 = Convert.ToDouble(Console.ReadLine());

        if (Math.Abs(size1 - size2) < 0.0001 && Math.Abs(size2 - size3) < 0.0001) //שלב 9 סעיף 2
        {
            Console.WriteLine("משולש שווה צלעות");
        }
        else if (Math.Abs(size1 - size2) < 0.0001 || 
                Math.Abs(size2 - size3) < 0.0001 || 
                Math.Abs(size1 - size3) < 0.0001)
        {
            Console.WriteLine("משולש שווה שוקיים");
        }
        else if (Math.Abs(size1 * size1 + size2 * size2 - size3 * size3) < 0.0001 || 
                Math.Abs(size1 * size1 + size3 * size3 - size2 * size2) < 0.0001 || 
                Math.Abs(size2 * size2 + size3 * size3 - size1 * size1) < 0.0001)
        {
            Console.WriteLine("משולש ישר זווית");
        }
        else
        {
            Console.WriteLine("משולש אחר");
        }
    }

    public static bool IsValidAge(int age) //שלב 7 סעיף 1
    {
        if (age >= 0 && age <= 120)
        {
            return true;
        }
        return false;
    }

    public static bool IsWeekend(int day) //שלב 7 סעיף 2
    {
        if (day == 6 || day ==7)
        {
            return true;
        }
        return false;
    }

    public static bool IsTriangle(double size1, double size2, double size3) //שלב 9 סעיף 1
    {
        if (size1 + size2 > size3)
        {
            return true;
        }
        return false;
    }
}