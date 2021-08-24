using System;

namespace Structures
{

    struct Books {
                public string title;
                public string author; 
                public string subject; 
                public int book_id;
            }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

 

            Books book1; 
            book1.author = "Oliver Grainge";
            book1.title = "Learning C#";
            book1.subject = "programming";
            book1.book_id = 42;
        }
    }
}
