using System;

namespace ProiectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Check day of the week");
            Console.WriteLine("2. Check if it's a weekday or weekend");
            Console.WriteLine("3. Check if it's a working day or holiday");
            Console.WriteLine("0. Exit");

            bool shouldExit = false;
            while (!shouldExit)
            {
                Console.Write("Your option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter a day (1-7): ");
                        int day = Convert.ToInt32(Console.ReadLine());
                        string dayOfWeek = GetDayOfWeek(day);
                        Console.WriteLine("The day of the week is: " + dayOfWeek);
                        break;

                    case "2":
                        Console.Write("Enter a day (1-7): ");
                        day = Convert.ToInt32(Console.ReadLine());
                        string weekdayOrWeekend = IsWeekdayOrWeekend(day) ? "Weekday" : "Weekend";
                        Console.WriteLine("It's a " + weekdayOrWeekend);
                        break;

                    case "3":
                        Console.Write("Enter a day (1-7): ");
                        day = Convert.ToInt32(Console.ReadLine());
                        string workingDayOrHoliday = IsWorkingDayOrHoliday(day) ? "Working day" : "Holiday";
                        Console.WriteLine("It's a " + workingDayOrHoliday);
                        break;

                    case "0":
                        shouldExit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Goodbye!");
        }

        static string GetDayOfWeek(int day)
        {
            string dayOfWeek = "";
            switch (day)
            {
                case 1:
                    dayOfWeek = "Monday";
                    break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
                default:
                    dayOfWeek = "Invalid day";
                    break;
            }

            return dayOfWeek;
        }

        static bool IsWeekdayOrWeekend(int day)
        {
            return (day >= 1 && day <= 5);
        }

        static bool IsWorkingDayOrHoliday(int day)
        {
            return (day >= 1 && day <= 5);
        }
    }
}
