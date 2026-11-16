using System.Linq.Expressions;

namespace C50_GSatTue_Basics02
{
    class Book
    {
        public string? Title { get; set; }
        public int Pages { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            //variable of type object.Print it.
            //Book b1 = new Book();
            //b1.Title = "C# is basic";
            //b1.Pages = 300;
            //object odj = b1;
            //Console.WriteLine(odj);
            #endregion
            #region Q2
            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            // itself), GetHashCode(), and GetType() on book.
            //Book b2 = new Book();
            //b2.Title = "Learn C#";
            //b2.Pages = 300;
            //Console.WriteLine(b2.ToString());
            //Console.WriteLine(b2.Equals(b2));
            //Console.WriteLine(b2.GetHashCode());
            //Console.WriteLine(b2.GetType());
            #endregion
            #region Q3
            // Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Answer:it's a compile-time error can't implicitly convert type 'srting'to 'int'.
            // int Pages = 300;// this is the right solution ENG/ mohamed ramzy ❤️
            // Console.WriteLine(Pages);
            #endregion
            #region Q4
            // Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int result = a / b;
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("DONE");
            //}
            #endregion
            #region Q5
            // Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            //int Pages = 300;
            //double dPages = Pages;
            //Console.WriteLine(dPages);
            #endregion
            #region Q6
            // Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int intprice=(int)price;
            //Console.WriteLine(intprice);
            #endregion
            #region Q7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagestext = "464";
            ////int pages=Convert.ToInt32(pagestext);
            ////Console.WriteLine(pages);
            #endregion
            #region Q9
            // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;
            //string pagestext=pages.ToString();
            //Console.WriteLine(pagestext);
            //Console.WriteLine(pagestext.GetType());// system.string 
            #endregion
            #region Q10
            // Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //int copies = 100;
            ////object objcopies = copies; //Boxing
            ////int copies2=(int)objcopies; //Unboxing
            ////Console.WriteLine(objcopies);
            ////Console.WriteLine(copies2);
            #endregion;
            #region Q11
            // Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            //int? year = null;
            ////Console.WriteLine(year.HasValue)
            //year = 2023;
            ////Console.WriteLine($"Years:{year}");
            #endregion
            #region Q12
            // Q12. Declare a string? reviewer = null;. Print whether it is null.
            // string? reviewer = null;
            //Console.WriteLine(reviewer == null);
            #endregion
            #region Q13
            // Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
            //Book? book = null;
            //string? title = book?.Title;
            //Console.WriteLine(title);
            #endregion
            #region Q14
            //Using title from the previous question, use ?? to print "Untitled" if title is null.
            //Then use ??= to assign title the value "Untitled" only if it's still null
            //string? title = null;
            ////Console.WriteLine(title??"Untitled");
            ////title ??= "Untitiled";
            ////Console.WriteLine(title);
            #endregion
            #region Q15
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            #endregion
        }
    }
}
