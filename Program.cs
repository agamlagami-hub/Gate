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


        int age = 12; //שלב 2 סעיף 2
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

        
    }
}