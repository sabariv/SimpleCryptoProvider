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

            Console.WriteLine(@"MD5 which returns base 64 string.,");
            Console.WriteLine(md.Encrypt<MD5CryptoServiceProvider>(@"Hello World", true));
            Console.Write(Environment.NewLine);

            Console.WriteLine(md.Encrypt<MD5CryptoServiceProvider>(@"Hello World", false));
            Console.Write(Environment.NewLine);

            Console.WriteLine(@"SHA1 which returns base 64 string.,");
            Console.WriteLine(md.Encrypt<SHA1CryptoServiceProvider>(@"Hello World", true));
            Console.Write(Environment.NewLine);

            Console.WriteLine(md.Encrypt<SHA1CryptoServiceProvider>(@"Hello World",false));
            Console.Write(Environment.NewLine);

            Console.ReadKey();
        }
    }
}
