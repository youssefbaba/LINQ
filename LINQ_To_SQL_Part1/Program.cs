namespace LINQ_To_SQL_Part1
{
    public class Program
    {
        /*
         - LINQ to Objects : we can write queries on Collections, Arrays, etc...
         - LINQ to Databases : we can write queries on DataTables (ADO.NET DataTables), Relational Database Tables.
            - LINQ to ADO.NET : we can write queries on DataTables.            
            - LINQ to SQL : we can write queries on Relational Database only Sql Server. 
            - LINQ to Entities : we can write queries on Relational Database all types like Sql Server , Oracle, etc... 
         - LINQ to XML : we can write queries on XML Files.


         - LINQ to SQL : it's a query language that is introduced in .Net 3.5 framework for working with relational database i.e Sql Server (Only Sql Server).
         - LINQ to SQL : is not only about querying the data but also allows us to perform CRUD Operations , Create(Insert), Read(Select), Update, Delete.
         - LINQ to SQL : we can also call stored procedureS by using LINQ to SQL.
         - Already thare is a language known as SQL using which we can interact with Sql Server with the help of ADO.Net.


         - SQL => Sql Server (ADO.Net) 
            - Runtime Syntax Checking of Sql Statements.
            - Not Type Safe.
            - No Intellisense Support.
            - Debugging of SQL Statements is not possible.
            - Code is a combination of Object Oriented and Relational.
                "INSERT INTO Student VALUES(" +textBox1.Text+ ",'" +textBox1.Text+"')";
         - LINQ => Sql Server (LINQ to SQL) 
            - Complie-time Syntax Checking.
            - Type Safe.
            - Intellisense Support is Available.
            - Debugging of LINQ SQL is possible.
            - Pure Object Oriented Code.

         - SQL                      - LINQ
           Table           =>           Class
           Column          =>           Property
           Row or Record   =>           Instance
           Stored Procedure   =>        Method


         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Youssef");
        }
    }
}