namespace LINQ_Introduction_Part0
{
    public class BookRepository
    {
        // Methods
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
           {
               new Book() {Title = "ADO.NET Step by Step" , Price = 5},
               new Book() {Title = "ASP.NET MVC" , Price = 9.99},
               new Book() {Title = "ASP.NET Web API" , Price = 12},
               new Book() {Title = "C# Advanced Topics" , Price = 7},
               new Book() {Title = "C# Intermediate Topics" , Price = 9},
               new Book() {Title = "ASP.NET MVC" , Price = 12.99},
           };
        }
    }
}