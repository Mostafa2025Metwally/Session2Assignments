using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session2Assignment
{
    internal class  Program
    {
        static void Main(string[] args)
        {
            //Q1
            Book book = new Book();

            book.Title = "Computer Science";
            book.Pages = 500;

            object obj = book;

            Console.WriteLine(obj);

            //___________________________________________________________________
            //Q2
            Console.WriteLine(book.ToString());

            Console.WriteLine(book.Equals(book));

            Console.WriteLine(book.GetHashCode());

            Console.WriteLine(book.GetType());

            //___________________________________________________________________
            //Q3
            //Compile time error
            int pages = 464;

            //___________________________________________________________________
            //Q4
            try
            {
                int number1 = 10;
                int number2 = 0;
                int result = number1 / number2;
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }

            //___________________________________________________________________
            //Q5
            int pages2 = 300;
            double d= pages2;

            //___________________________________________________________________
            //Q6
            double price = 49.99;
            int price2 = (int)price;

            //___________________________________________________________________
            //Q7
            string pagesText = "464";
            int n = Convert.ToInt32(pagesText);

            //___________________________________________________________________
            //Q8
            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";

            if (int.TryParse(badText, out int badNumber))
            {
                Console.WriteLine($"Conversion successful: {badNumber}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            //___________________________________________________________________
            //Q9
            int pages5 = 464;
            string convert = Convert.ToString(pages5);
            
            Console.WriteLine(convert.GetType());

            //___________________________________________________________________
            //Q10
            int copies = 100;

            object obj2 = copies;
            int unbox = (int)obj2;

            Console.WriteLine(copies);
            Console.WriteLine(unbox);

            //___________________________________________________________________
        }
    }
}