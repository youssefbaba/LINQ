namespace LINQ_Introduction_Part0
{
    public class Program
    {
        /*
         - Link : https://www.c-sharpcorner.com/uploadfile/babu_2082/linq-operators-and-lambda-expression-syntax-examples/ 
         - LINQ
            - Stands for : Language Integrated Query.
            - Gives us the capability to query objects.
         - With LINQ we can query :
            - Objects in memory , eg Collection , Array ,... (LINQ to Objects).
            - Databases (LINQ to Entities).
            - XML (LINQ to XML).
            - ADO.NET Data Sets (LINQ to Data Sets).
         - We have two syntax of creating LINQ :
            - LINQ Query Operators.  
            - LINQ Extension Methods. 
        - When we use LINQ , we need to respect this order mandatory :
            1 - Where
            2 - GroupBy
            3 - Having
            4 - OrderBy
        -



        */

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Without Using LINQ :
            List<Book> cheaperBooksZero = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price <= 10)
                {
                    cheaperBooksZero.Add(book);
                }
            }
            foreach (var book in cheaperBooksZero)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();


            // LINQ Query Operators : 
            //var cheaperBooksOne = from b in books where b.Price <= 10 select b;
            var cheaperBooksOne = from b in books
                                  where b.Price <= 10
                                  select new { b.Title, b.Price };
            foreach (var book in cheaperBooksOne)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();

            // LINQ Extension Methods : 
            //var cheaperBooksTwo = books.Where(b => b.Price <= 10);
            var cheaperBooksTwo = books
                .Where(b => b.Price <= 10)
                .Select(b => new { b.Title, b.Price });
            foreach (var book in cheaperBooksTwo)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();


            // LINQ Query Operators :
            var cheaperBooksThree = from b in books
                                    where b.Price <= 10
                                    orderby b.Title
                                    select b;
            foreach (var book in cheaperBooksThree)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();

            // LINQ Extension Methods :
            var cheaperBooksFour = books
                .Where(b => b.Price <= 10)
                .OrderBy(b => b.Title);
            foreach (var book in cheaperBooksFour)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();


            // LINQ Query Operators :
            var cheaperBooksFive = from b in books
                                   where b.Price <= 10
                                   orderby b.Title descending
                                   select b;
            foreach (var book in cheaperBooksFive)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();

            // LINQ Extension Methods :
            var cheaperBooksSix = books
                .Where(b => b.Price <= 10)
                .OrderByDescending(b => b.Title);
            foreach (var book in cheaperBooksSix)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();


            // LINQ Query Operators :
            var cheaperBooksSeven = from b in books
                                    where b.Price <= 10
                                    orderby b.Title descending
                                    select b.Title;
            foreach (var title in cheaperBooksSeven)
            {
                Console.WriteLine($"Title = {title}");
            }
            Console.WriteLine();

            // LINQ Extention Methods :
            var cheaperBooksEight = books
                .Where(b => b.Price <= 10)
                .OrderByDescending(b => b.Title)
                .Select(b => b.Title);
            foreach (var title in cheaperBooksEight)
            {
                Console.WriteLine($"Title = {title}");
            }
            Console.WriteLine();

            // LINQ Extension Methods :
            var valueOne = books.Where(b => b.Title == "ASP.NET MVC");
            foreach (var book in valueOne)
            {
                Console.WriteLine($"Title = {book.Title} & Price = {book.Price}");
            }
            Console.WriteLine();
            try
            {
                //var valueTwo = books.Single(b => b.Title == "ASP.NET MVC"); // Throws an Exception , because we have more than book matches this condition.
                var valueTwo = books.Single(b => b.Title == "C# Advanced Topics");
                Console.WriteLine($"Title = {valueTwo.Title} & Price = {valueTwo.Price}");

            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine();
            try
            {
                //var valueThree = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); // Throws an Exception , because we have more than book matches this condition.
                //var valueThree = books.SingleOrDefault(b => b.Title == "ASP.NET"); // Returns default value , because there is no book matches this condition.
                var valueThree = books.SingleOrDefault(b => b.Title == "C# Advanced Topics");
                if (valueThree != null)
                {
                    Console.WriteLine($"Title = {valueThree.Title} & Price = {valueThree.Price}");
                }
                else
                {
                    Console.WriteLine($"Result = null");
                }

            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine();
            try
            {
                //var valueFour = books.First(b => b.Title == "ASP.NET"); //Throws an exception , because there is no book matches this condition.
                var valueFour = books.First(b => b.Title == "ASP.NET MVC");
                Console.WriteLine($"Title = {valueFour.Title} & Price = {valueFour.Price}");
            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine();
            //var valueFive = books.FirstOrDefault(b => b.Title == "ASP.NET"); // Returns default value , because there is no book matches this condition.
            var valueFive = books.FirstOrDefault(b => b.Title == "ASP.NET MVC");
            if (valueFive != null)
            {
                Console.WriteLine($"Title = {valueFive.Title} & Price = {valueFive.Price}");
            }
            else
            {
                Console.WriteLine($"The result = null");
            }
            Console.WriteLine();
            try
            {
                //var valueSix = books.Last(b => b.Title == "ASP.NET MVC");
                var valueSix = books.Last(b => b.Title == "ASP.NET"); // Throws an Exception , because there is no book matches this condition.
                Console.WriteLine($"Title = {valueSix.Title} & Price = {valueSix.Price}");
            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.WriteLine();
            //var valueSeven = books.LastOrDefault(b => b.Title == "ASP.NET"); // Returns the default value , because there is no book matches this condition.
            var valueSeven = books.LastOrDefault(b => b.Title == "ASP.NET MVC");
            if (valueSeven != null)
            {
                Console.WriteLine($"Title = {valueSeven.Title} & Price = {valueSeven.Price}");
            }
            else
            {
                Console.WriteLine("The result = null");
            }
            Console.WriteLine();
            var pagedBooksOne = books.Skip(2);
            foreach (var item in pagedBooksOne)
            {
                Console.WriteLine($"Title = {item.Title} & Price = {item.Price}");
            }
            Console.WriteLine();
            var pagedBooksTwo = books.Take(3);
            foreach (var item in pagedBooksTwo)
            {
                Console.WriteLine($"Title = {item.Title} & Price = {item.Price}");
            }
            Console.WriteLine();
            var pagedBooksThree = books.Skip(2).Take(3);
            foreach (var item in pagedBooksThree)
            {
                Console.WriteLine($"Title = {item.Title} & Price = {item.Price}");
            }
            Console.WriteLine();

            var distinctTitles = books.Select(b => b.Title).Distinct();
            foreach (var title in distinctTitles)
            {
                Console.WriteLine($"Title = {title}");
            }
            Console.WriteLine();
            var groupedBooksOne = books.GroupBy(b => b.Title).Select(b => new {b.Key , BookCount = b.Count()  });
            foreach (var item in groupedBooksOne)
            {
                Console.WriteLine($"Title = {item.Key} & BookCount = {item.BookCount}");
            }
            Console.WriteLine();

            /*
             
            The following are the most commonly used aggregate functions:
                COUNT – counts rows in a specified table or view.
                SUM – calculates the sum of values.
                AVG – calculates the average of a set of values.
                MIN – gets the minimum value in a set of values.
                MAX – gets the maximum value in a set of values.
             
             */

            int numberOfBooks = books.Count();
            Console.WriteLine($"Number Of Books = {numberOfBooks} book(s)");
            double totalPrice = books.Sum(b => b.Price);
            Console.WriteLine($"Total Price = {totalPrice} $");
            double averagePrice = books.Average(b => b.Price);
            Console.WriteLine($"Average Price = {averagePrice} $");
            double maxPrice = books.Max(b => b.Price);
            Console.WriteLine($"Max Price = {maxPrice} $");
            double minPrice = books.Min(b => b.Price);
            Console.WriteLine($"Min Price = {minPrice} $");



        }
    }
}