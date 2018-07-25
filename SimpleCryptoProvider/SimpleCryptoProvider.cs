using System;
using System.Text;
using System.Security.Cryptography;

namespace SimpleCryptoProvider
{

    public interface ISimpleCryptoProvider
    {
        byte[] Encrypt<T>(string plainText) where T : HashAlgorithm, new();

        string Encrypt<T>(string plainText, bool shouldReturnBase64String) where T : HashAlgorithm, new();        
    }

    public class SimpleCryptoProvider : ISimpleCryptoProvider
    {
        public byte[] Encrypt<T>(string plainText) where T : HashAlgorithm, new()
        {
            if (!string.IsNullOrWhiteSpace(plainText))
            {
                using (var provider = new T())
                {
                    byte[] plainData = Encoding.UTF8.GetBytes(plainText);

                    byte[] decipheredData = provider.ComputeHash(plainData);

                    if (decipheredData != null && decipheredData.Length > 0)
                        return decipheredData;
                }
            }
            return default(byte[]);
        }

        public string Encrypt<T>(string plainText, bool shouldReturnBase64String) where T : HashAlgorithm, new()
        {

            byte[] decipheredData = Encrypt<T>(plainText);

            if (decipheredData != default(byte[]))
            {
                if (shouldReturnBase64String)
                    return Convert.ToBase64String(decipheredData);
                else
                    return BitConverter.ToString(decipheredData).Replace(@"-", string.Empty);
            }
            
            return string.Empty;
        }

        
    }

}
