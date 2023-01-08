namespace LINQ_Introduction_Part0
{
    public class Test
    {
        /*
         - LINQ : Stands for Language Integrated Query.
         - Using LINQ we can write quries on wide variety of data sources like,
            Arrays, Collections, Database Tables, DataSet's , XML Files.
         - We can write LINQ by using two syntax:
             - LINQ Query Operators : more efficient and readable
                    from <alias> in <coll | array> [<clauses> (where , groupby , having , orderby)] select <alias>;
                    from n in array where n >= 40 orderby n descending select n;
             - LINQ Extension Methods :
                    array.Where(n => n >= 40).OrderByDescending(n => n);
         - clauses : Where , GroupBy , Having , OrderBy we need to use them in this order mandatory.
         - 


         */
        // Methods
        static void Main(string[] args)
        {

            int[] array = new int[] { 12, 45, 67, 39, 8, 61, 74, 82, 97, 27, 56, 49, 58, 79, 86, 14, 3, 23, 37, 92 };

            // Without Using LINQ :
            Console.WriteLine("Without Using LINQ : ");
            int counter = 0;
            foreach (int value in array)
            {
                if (value >= 40)
                {
                    counter++;
                }
            }
            int[] newArray = new int[counter];
            int index = 0;
            foreach (int value in array)
            {
                if (value >= 40)
                {
                    newArray[index] = value;
                    index++;
                }
            }
            Array.Sort(newArray);
            Array.Reverse(newArray);
            foreach (int value in newArray)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            // LINQ Query Oparators :
            Console.WriteLine("LINQ Query Oparators : ");
            var newArrayTwo = from n in array where n >= 40 orderby n descending select n;
            foreach (int value in newArrayTwo)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            // LINQ Extension Methods :
            Console.WriteLine("LINQ Extension Methods : ");
            var newArrayThree = array.Where(n => n >= 40).OrderByDescending(n => n);
            foreach (int value in newArrayThree)
            {
                Console.Write($"{value} ");
            }

        }
    }
}
