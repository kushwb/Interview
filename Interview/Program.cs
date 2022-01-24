using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Interview
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            //var obj = new Child("test")
            //{
            //    isvalid = true
            //};

            //obj.Method1();
            //IndexersExample();
            //OpenRegKey();
            //var test = $"fs_dasfdas_4 (FORECAST) [INT(16,(1,9))] 96  ;  60.000";
            //var obj = new Post();
            //obj["gamer1"] = new Gamer();
            //Console.WriteLine(obj["gamer1"]);            


            


            
            var reslt = Utilities.Max(2, 5);
            Console.WriteLine($"{reslt} is max");

            var num = new Nullable<int>();
            if (num.HasValue)
                Console.WriteLine(num.GetValueOrDefault());
            else
                Console.WriteLine(num.GetValueOrDefault());
        }

        private static void InhertanceExample()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            // The following two calls do what you would expect. They call  
            // the methods that are defined in BaseClass.  
            bc.Method1();
            bc.Method2();
            
            // Output:  
            // Base - Method1  
            // Base - Method2  

            // The following two calls do what you would expect. They call  
            // the methods that are defined in DerivedClass.  
            dc.Method1();
            dc.Method2();
            
            // Output:  
            // Derived - Method1  
            // Derived - Method2  

            // The following two calls produce different results, depending
            // on whether override (Method1) or new (Method2) is used.  
            bcdc.Method1();
            bcdc.Method2();
            // Output:  
            // Derived - Method1  
            // Base - Method2  
        }
        public class BaseClass
        {
            private protected int test = 10;
            public virtual void Method1()
            {
                Console.WriteLine("Base - Method1");
            }

            public virtual void Method2()
            {
                Console.WriteLine("Base - Method2");
            }
        }

        public class DerivedClass : BaseClass
        {
            public sealed override void Method1()
            {
                Console.WriteLine("Derived - Method1");
            }

            public override void Method2()
            {
                test = 25;
                Console.WriteLine("Derived - Method2");
                Console.WriteLine(test);
            }
        }       
        private static void HashingExmaple()
        {
            var obj = new Post();
            obj.Description = "test";
            string s = JsonConvert.SerializeObject(obj);
            string hashedData = ComputeSha256Hash(s);
            Console.WriteLine("Hash {0}", hashedData);
            obj.Description = "test2";
            string s1 = JsonConvert.SerializeObject(obj);
            string hashedData1 = ComputeSha256Hash(s1);
            Console.WriteLine("Hash {0}", hashedData1);
            Console.WriteLine("Hash 0 == 1 :{0}", hashedData1 == hashedData);
            var obj2 = new Post();
            obj2.Description = "test";
            string s3 = JsonConvert.SerializeObject(obj2);
            string hashedData2 = ComputeSha256Hash(s3);
            Console.WriteLine("Hash {0}", hashedData2);
            Console.WriteLine("Hash 0 == 2 :{0}", hashedData2 == hashedData);
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private static void OpenRegKey()
        {
            string value64 = string.Empty;
            string value32 = string.Empty;

            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            localKey = localKey.OpenSubKey(@"SOFTWARE\Windows\CurrentVersion\AutoRotation");
            if (localKey != null)
            {
                value64 = localKey.GetValue("RegisteredOrganization").ToString();
            }
            RegistryKey localKey32 = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32);
            localKey32 = localKey32.OpenSubKey(@"SOFTWARE\Windows\CurrentVersion\AutoRotation");
            if (localKey32 != null)
            {
                value32 = localKey32.GetValue("RegisteredOrganization").ToString();
            }
        }

        private static void StackExample()
        {
            Stack myStack = new Stack();

            //verbatim string example
            string input = @"Enter you choice 
1. Push a item
2. Pop item
3. Clear list
4. Exit";
            Console.WriteLine(input);
            var choice = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your item");
                        var item = Console.ReadLine();
                        myStack.Push(item);
                        break;

                    case 2:
                        _ = myStack.Pop();
                        break;

                    case 3:
                        myStack.Clear();
                        break;
                    default:
                        break;
                }
                Console.WriteLine(input);
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice != 4);
        }        

        private static void StopWatchExcercise()
        {
            Console.WriteLine("Enter start,stop to control the timer:");
            var input = Console.ReadLine();
            StopWatch obj = new StopWatch();
            while (input != "exit")
            {
                if (input == "start")
                {
                    obj.Start();
                    Console.WriteLine("Timer Started");
                }
                else if (input == "stop")
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
            var test = new Gamer();
            test["Brijesh1"] = 32;
            test["Brijesh2"] = 332;
            test["Brijesh3"] = 55;

            test.GamerAge("Brijesh2");
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