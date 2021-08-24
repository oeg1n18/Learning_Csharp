using System;
using System.IO;

// When a file is opened for reading or writing i becomes a stream.
// The stream is a sequence of bytes passing through the communication path. 
// There are two main streams the input and output. 


//There are a number of objects in the System.IO namespace that can help you handle files

/*

-- BinaryReader = Reads primitive data from a binary stream.
-- BinaryWriter = ~" "
-- Directory = Helps in manipulating a directory strucure
-- DirectoryInfo = Used for performing operations on directories
-- DriveInfo = Provides information for the drives
-- File = Helps manipulating files
-- FileInfo = used for performing operations on files
-- File Stream = Used to read from and write to any location in a file
-- Memory Stream = Used for random access to streamed data stored in memory. 
-- Path = Performs operations on path information 
-- StreamReader = Used for reading characters from a byte stream.
-- StreamWriter = Used for writing characters to a stream. 
-- StringReader = is used for reading from a string buffer
-- StringWrtier = is used from writing a string into a buffer.


*/

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++) {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for(int i = 0; i <= 20; i++) {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();
        }
    }
}
