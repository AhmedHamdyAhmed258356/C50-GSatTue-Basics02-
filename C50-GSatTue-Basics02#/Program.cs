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
           Book b2 = new Book();
            b2.Title = "Learn C#";
            b2.Pages = 300;
            Console.WriteLine(b2.ToString());
            Console.WriteLine(b2.Equals(b2));
            Console.WriteLine(b2.GetHashCode());
            Console.WriteLine(b2.GetType());
            #endregion
        }
    }
}
