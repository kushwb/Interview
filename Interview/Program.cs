using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace Interview
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter start,stop to control the timer:");
            var input = Console.ReadLine();
            StopWatch obj = new StopWatch();
            while (input != "exit")
            {
                if(input == "start")
                {
                    obj.Start();
                    Console.WriteLine("Timer Started");                                        
                }
                else if(input == "stop")
                {
                    obj.Stop();
                }
                Console.Write("Start/Stop timer:");
                input = Console.ReadLine();
            }
        }

        private static void OutExample(out int number)
        {
            number = 222;
            Console.WriteLine(number);
            number = 10;
            Console.WriteLine(number);
        }

        private static void IndexersExample()
        {
            Calculator test = new Calculator();
            test["Brijesh1"] = 32;
            test["Brijesh2"] = 332;
            test["Brijesh3"] = 55;

            test.GamerAge("Brijesh3");
        }

        public static void BiggestNumberAmongCommaSeperatedNumbers()
        {
            Console.WriteLine("Enter the numbers separated by comma:");
            var numbers = Console.ReadLine().Split(',');
            int big = 0;
            foreach (var number in numbers)
            {
                if (Convert.ToInt32(number) > big)
                    big = Convert.ToInt32(number);
            }

            Console.WriteLine("{0} is the biggest number", big);
        }

        public static void Excercise1()
        {
            int number;
            Console.Write("Enter number between 1-10:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 1 || number > 10)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("Valid Number");
            }
        }

        public static void Excercise2()
        {
            Console.WriteLine("Enter first number");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine("First number is less than second number");
            }
            else
                Console.WriteLine("First number is big");
        }

        public static int Fib(int number)
        {
            if (number < 2)
                return number;
            return Fib(number - 1) + Fib(number - 2);
        }

        public static void NumberDivisibleByThree()
        {
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        public void Fibonacci()
        {
            Console.WriteLine("Hello World!");
            int number = 5;
            for (int i = 1; i <= number;)
            {
                Console.WriteLine(Fib(i));
                i++;
            }
        }

        private static void ArrayOperations()
        {
            var md = new int[3, 5];
            var test = new int[] { 2, 25, 235, 2, 43 };
            var dest = new int[3];
            Console.WriteLine("Source Array:");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Array.Copy(test, dest, 3);
            test[1] = 10;
            Console.WriteLine("Dest Array:");
            foreach (var item in dest)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Source Array Modified:");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Array.Sort(test);
            Console.WriteLine("Source Array Sorted:");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Array.Clear(test, 0, test.Length);
            Console.WriteLine("Source Array Cleared:");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }

        private static void FileExcercises()
        {
            //var path = @"C:\TestFiles\Test.txt";
            var file = "this  isis  a very big sentence aslkdfjasj dfjlkadsj jjj aklfjldja;fj  123456789101010101";
            var words = file.Split(' ').ToList().Select(x => x.Trim());
            var biggestword = string.Empty;
            var tems = words.Where(x => x.Length > biggestword.Length);
            foreach (var word in words.Where(x => x.Length > biggestword.Length))
            {
                biggestword = word;
            }

            Console.WriteLine(biggestword);
        }

        private static void IsConsicutiveNumbers()
        {
            Console.WriteLine("Enter numbers seperated by - sign :");
            var numbers = (Console.ReadLine().Split('-'));
            bool isConsicutive = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) != (Convert.ToInt32(numbers[i - 1]) + 1))
                {
                    isConsicutive = false;
                    break;
                }
            }
            if (isConsicutive)
            {
                Console.WriteLine("Consicutive numbers");
            }
            else
                Console.WriteLine("Non consicutive numbers");
        }        
        //String Excercises
        private static void StringExcercise2()
        {
            Console.WriteLine("Enter numbers seperated by - :");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            List<int> numbers = new List<int>();
            foreach (var item in input.Split('-'))
                numbers.Add(Convert.ToInt32(item));

            if (numbers.Distinct().Count() != numbers.Count)
                Console.WriteLine("Duplicates found");
            //bool duplicate = false;
            //for(int i=0;i<numbers.Count-1;i++)
            //{
            //    if(numbers[i] == numbers[i+1])
            //    {
            //        duplicate = true;
            //        break;
            //    }
            //}
            //if (duplicate)-
            //    Console.WriteLine("Duplicates found");
        }

        private static void StringExcercise3()
        {
            Console.WriteLine("Enter time in hrs format:");
            var time = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(time) || time.Split(':').Count() != 2)
            {
                Console.WriteLine("Invalid");
                return;
            }
            try
            {
                var timevalidation = Convert.ToDateTime(time);
            }
            catch
            {
                Console.WriteLine("Invalid time entered");
            }
        }

        private static void StringExcercise4()
        {
            Console.Write("Enter the statement:");
            var statement = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(statement))
            {
                Console.WriteLine("Enter a valid statement");
                Console.Write("Enter the statement:");
                statement = Console.ReadLine();
            }
            var words = statement.Split(' ');
            string fullStatement = string.Empty;
            foreach (var word in words)
            {
                fullStatement = fullStatement + char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }
            Console.WriteLine(fullStatement);
        }

        private static void StringExcercise5()
        {
            Console.WriteLine("Enter a statement:");
            var input = Console.ReadLine();
            string vowels = "aeiou";
            int count = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    count++;
            }

            Console.WriteLine(count);
        }
        private static void StringOperations()
        {
            var name = "Brijesh kuushwaha    ";
            var names = new[] { "i", "am", "brijesh" };

            //Join
            Console.WriteLine(string.Join(':', names));

            //Trim
            Console.WriteLine("'{0}'", name.Trim());

            //Split
            var firstname = name.Split(" ");
            Console.WriteLine(firstname[0]);

            //IndexOF
            var index = name.IndexOf(' ');

            //Substring
            var secondName = name.Substring(index + 1);
            Console.WriteLine(secondName);

            //Replace
            var newName = name.Replace("Brijesh", "Bhupes");
            Console.WriteLine(newName);

            //Null or Empty or Whitespace

            if (string.IsNullOrWhiteSpace(""))
                Console.WriteLine("Invalid string");

            //conversion
            var str = "260";
            var numer = Convert.ToInt32(str);
            Console.WriteLine("Converted number{0}", numer);

            float price = 12.235f;
            Console.WriteLine(price.ToString("F1"));
        }

        private static void SummarisingString()
        {
            var sentense = "thi si s avaerry big string kajf;dlksjafdj  l;asdjfl;kasj;dlfj klkusal;fjdlsafj aslkdfj;als";
            var summary = sentense.Substring(0, 25) + "...";
            Console.WriteLine(summary);
        }
    }
}