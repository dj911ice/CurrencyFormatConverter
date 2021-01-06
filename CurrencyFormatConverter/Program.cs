using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using System.Text;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }
        public static void RunProgram()
        {
            Console.WriteLine("Please enter a amount one...");
            string input = Console.ReadLine();
            double.TryParse(input, out double amount1);
            //double amount1 = ConvertToDouble(input);
            while (!double.TryParse(input, out amount1))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount one...");
                input = Console.ReadLine();
                double.TryParse(input, out amount1);
            }

            Console.Clear();

            Console.WriteLine($"Amount one is saved as: {input}");

            Console.WriteLine("Please enter a amount two...");
            input = Console.ReadLine();
            double.TryParse(input, out double amount2);

            while (!double.TryParse(input, out amount2))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount two...");
                input = Console.ReadLine();
                double.TryParse(input, out amount2);
            }

            Console.Clear();

            Console.WriteLine($"Amount two is saved as: {input}");

            Console.WriteLine("Please enter a amount three...");
            input = Console.ReadLine();
            double.TryParse(input, out double amount3);

            while (!double.TryParse(input, out amount3))
            {
                Console.WriteLine("Sorry not a valid input! Please enter an amount three...");
                input = Console.ReadLine();
                double.TryParse(input, out amount3);
            }

            Console.WriteLine($"Amount three is saved as: {input}");

            Console.Clear();

            double amount_total = amount1 + amount2 + amount3;
            Console.WriteLine($"Total amount: {amount_total}");

            double amount_avg = (amount_total) / 3;
            Console.WriteLine($"Average amount: {amount_avg}");

            double[] AmountArray = { amount1, amount2, amount3 };
            // Test Array
            //for (int i = 0; i < AmountArray.Length; i++)
            //{
            //    Console.WriteLine(AmountArray[i]);    
            //}

            Console.WriteLine($"Minimum amount: {AmountArray.Min()}");
            Console.WriteLine($"Maximum amount: {AmountArray.Max()}");

            // Test and extract region information
            Console.OutputEncoding = Encoding.UTF8;
            RegionInfo regioninfoTH = new RegionInfo("TH");
            Console.WriteLine(regioninfoTH.DisplayName);
            Console.WriteLine(regioninfoTH.CurrencySymbol);

            RegionInfo regioninfoDE = new RegionInfo("DE");
            Console.WriteLine(regioninfoDE.DisplayName);
            Console.WriteLine(regioninfoDE.CurrencySymbol);

            Thread.Sleep(6500);
            Console.Clear();

            //CultureInfo usd = new CultureInfo("en-US");

            //Console.WriteLine($"American: {amount_total.ToString("c", usd)}");
           
            Console.WriteLine($"American: {amount_total.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))}");

            CultureInfo swk = new CultureInfo("sv-SE");
            Console.WriteLine($"Swedish: {amount_total.ToString("c", swk)}");

            CultureInfo jpy = new CultureInfo("ja-JP");
            Console.WriteLine($"Japanese: {amount_total.ToString("c", jpy)}");
            CultureInfo thb = new CultureInfo("th-TH");
            Console.WriteLine($"Thai: {amount_total.ToString("c", thb)}");
            CultureInfo enl = new CultureInfo("nl-NL");
            Console.WriteLine($"Dutch: {amount_total.ToString("c", enl)}");
            CultureInfo ede = new CultureInfo("de-DE");
            Console.WriteLine($"German: {amount_total.ToString("c", ede)}");
            CultureInfo gbp = new CultureInfo("en-GB");
            Console.WriteLine($"UK: {amount_total.ToString("c", gbp)}");
            CultureInfo cad = new CultureInfo("en-CA");
            Console.WriteLine($"Canadian: {amount_total.ToString("c", cad)}");
            CultureInfo mex = new CultureInfo("es-MX");
            Console.WriteLine($"Mexican: {amount_total.ToString("c", mex)}");
            CultureInfo plz = new CultureInfo("pl-PL");
            Console.WriteLine($"Polish: {amount_total.ToString("c", plz)}");
            CultureInfo rur = new CultureInfo("ru-RU");
            Console.WriteLine($"Russian: {amount_total.ToString("c", rur)}");
            CultureInfo brr = new CultureInfo("pt-BR");
            Console.WriteLine($"Brazilian: {amount_total.ToString("c", brr)}");
            ContinueProgram();
        }
        public static void ContinueProgram()
        {
            Console.WriteLine("Would you like to try different amounts? Y/N");
            string Continue = Console.ReadLine();

            if (Regex.Match(Continue, @"^[Y|y]$").Success)
            {
                Console.Clear();
                RunProgram();
            }
            else
            {
                Console.WriteLine("Thanks for playing! Good Bye!\nPress enter to exit program...");
                Console.ReadLine();
            }
        }
    }
}