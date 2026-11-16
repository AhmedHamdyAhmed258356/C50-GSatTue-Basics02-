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
            //#endregion
            //#region Q04
            //// Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide by zero");
            }
            finally
            {
                Console.WriteLine("DONE");
            }
            #endregion
        }
    }
}
