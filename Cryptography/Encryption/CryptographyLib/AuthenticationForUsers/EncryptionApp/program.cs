using System;
using System.Collections.Generic;
using System.IO; 
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using static System.Convert;
using static System.Console;
using CyrptographyLib;


namespace prog {

    class program {
        static void Main(string[] args) {
            Write("Enter some text to sign: ");
            string data = ReadLine();

            var signature = Protector.GenerateSignature(data);

            WriteLine($"Signature: {signature}");
            WriteLine("Public key used to check signature:"); 
            WriteLine(Protector.PublicKey);

            if(Protector.ValidateSignature(data,signature))
            {
                WriteLine("Correct! Signature is valid"); 
            } else 
            {WriteLine("Invalid Signature");}
        }

    }
}