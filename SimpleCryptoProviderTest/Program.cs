using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCryptoProviderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCryptoProvider.ISimpleCryptoProvider md = new SimpleCryptoProvider.SimpleCryptoProvider();

            Console.WriteLine(md.Encrypt<MD5CryptoServiceProvider>(@"Hello World", true));

            Console.WriteLine(md.Encrypt<MD5CryptoServiceProvider>(@"Hello World", false));

            Console.WriteLine(md.Encrypt<SHA1CryptoServiceProvider>(@"Hello World", true));

            Console.WriteLine(md.Encrypt<SHA1CryptoServiceProvider>(@"Hello World",false));
            
            Console.ReadKey();
        }
    }
}
