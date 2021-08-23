using System;
using System.IO;
using System.Text;




namespace streams

{


// Output and read a text stream to a new file.
    class TextToStream {
        string dir = Directory.GetCurrentDirectory();
       
        public TextToStream() {
            

            string[] callsigns = new string[] {
                "Husker", "Starbuck", "Apollo", "Boomer", "Bulldog", "Athena", "Helo", "Racetrack" };
            string textFile = Path.Combine(dir, "Streams.txt");
                

            StreamWriter text = File.CreateText(textFile);

            foreach (string item in callsigns) 
                {
                    text.WriteLine(item);
                }
                text.Close();

                //output the contents of the file
                Console.WriteLine("{0} contains {1:N0} bytes", 
                                arg0: textFile, 
                                arg1: new FileInfo(textFile).Length);
                Console.WriteLine(File.ReadAllText(textFile));
            }
        }



// Encode a string into different types of encoding 
    class ByteArrays {
        public ByteArrays() {
            Console.WriteLine("Encodings");
            Console.WriteLine("[1] ASCII");
            Console.WriteLine("[2] UTF-7");
            Console.WriteLine("[3] UTF-8");
            Console.WriteLine("[4] UTF-16 (unicode)");
            Console.WriteLine("[5] UTF-32");
            Console.WriteLine("Any other key is defualt");

            Console.WriteLine("");
            Console.WriteLine("Press a number to choose an encoding: ");
            ConsoleKey number = Console.ReadKey(intercept: false).Key;
            Console.WriteLine();
            Console.WriteLine();


            Encoding encoder = number switch
            {
                ConsoleKey.D1 => Encoding.ASCII,
                ConsoleKey.D2 => Encoding.UTF7,
                ConsoleKey.D3 => Encoding.UTF8,
                ConsoleKey.D4 => Encoding.Unicode,
                ConsoleKey.D5 => Encoding.UTF32, 
                _         => Encoding.Default
            };


            string message = "A pint of milk is £1.99";

            byte[] encoded = encoder.GetBytes(message);

            Console.WriteLine("{0} uses {1:N0} bytes", encoder.GetType().Name, encoded.Length);
        }
    }
    

// using a Stream Writer or StreamReader will help you. the Writers and readers will automatically use 
// the specified encoding. 
    class Stream_Writer_Reader {

        public Stream_Writer_Reader() {
            // This is a Stream Reader using UTF-7
            var reader = new StreamReader("Streams.tst", Encoding.UTF7);

            // This is a Stream Writer using UTF-7
            FileStream fs = new FileStream("NewStream", FileMode.CreateNew);
            var writer = new StreamWriter(fs, Encoding.UTF7);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TextToStream T = new TextToStream();  

            ByteArrays Q = new ByteArrays();      
        }
    }
}
