using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using static System.Convert;


namespace Packt.Shared
{
    public static class Protector {
        //salt size must be at least 8 bytes
        // a salt is a random data used as additional input to a one-way function
        // that hashes data, a password or phrase
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");

        //iterations must be at least 1000
        private static readonly int iterations = 2000;
        
        public static string Encrypt(string plainText, string password) {
            byte[] encryptedBytes; 
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);

            var aes = Aes.Create(); // abstract class factory method

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations); 

            aes.Key = pbkdf2.GetBytes(32); // set a 256-bit key
            aes.IV = pbkdf2.GetBytes(16); //set a 128-bit IV

            using (var ms = new MemoryStream()) {
                using (var cs = new CryptoStream(
                ms, aes.CreateEncryptor(), CryptoStreamMode.Write)) {
                    cs.Write(plainBytes, 0, plainBytes.Length);
                }
                encryptedBytes = ms.ToArray();
            }
            return Convert.ToBase64String(encryptedBytes);
            }

        
        public static string Decrypt(
            string cryptoText, string password)
            {
                byte[] plainBytes;
                byte[] cryptoBytes = Convert.FromBase64String(cryptoText); 

                var aes = Aes.Create();

                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);

                aes.Key = pbkdf2.GetBytes(32); 
                aes.IV = pbkdf2.GetBytes(16);

                using (var ms = new MemoryStream()) {
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write)) {
                        cs.Write(cryptoBytes, 0, cryptoBytes.Length);
                    }
                    plainBytes = ms.ToArray();
                }
                return Encoding.Unicode.GetString(plainBytes);
            }
    

        static void Main(string[] args) {
            Console.WriteLine("Enter a message that you want to encrypt: ");
            String message = Console.ReadLine();

            Console.WriteLine("Enter a Password: ");
            string password = Console.ReadLine();

           string cryptoText = Protector.Encrypt(message, password); 
           Console.WriteLine($"Encrypted Text: {cryptoText}");

           Console.WriteLine("Enter the Password: ");
           string password2 = Console.ReadLine();

           try
           {
               string clearText =  Protector.Decrypt(cryptoText, password2); 
               Console.WriteLine($"Decrypted text: {clearText}");
           } catch (CryptographicException ex) {
               Console.WriteLine("{0}/nMore details: {1}", 
               arg0: "You entered the wrong password!",
               arg1: ex.Message);
           } catch (Exception ex) {
               Console.WriteLine("Non-Cryptographic exception: {0}, {1}",
               arg0: ex.GetType().Name, 
               arg1: ex.Message);
           }
        }

           
            
        

    }
}