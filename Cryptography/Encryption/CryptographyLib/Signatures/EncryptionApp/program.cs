using System.Security.Cryptography;
using static System.Console;
using CyrptographyLib;
using System;


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