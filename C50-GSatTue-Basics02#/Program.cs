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
            Book b1 = new Book();
            b1.Title = "C# is basic";
            b1.Pages = 300;
            object odj = b1;
            Console.WriteLine(odj);
            #endregion
        }
    }
}
