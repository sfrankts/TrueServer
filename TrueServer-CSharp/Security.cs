using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueServer_CSharp
{
    class Security
    {
        public String Encrypt(String inputStr, String salt)
        {
            //"";
            AES aes_obj = new AES();
            byte[] passwordBytes = aes_obj.GetPasswordBytes(salt);
            String OutText = AES.Encrypt(inputStr, passwordBytes);

            String returnStr = OutText;
            return returnStr;
        }

        public String Decrypt(String inputStr, String salt)
        {
            AES aes_obj = new AES();
            byte[] passwordBytes = aes_obj.GetPasswordBytes(salt);
            //Console.WriteLine(OutText);
            String OutText = AES.Decrypt(inputStr, passwordBytes);
            String returnStr = OutText;
            return returnStr;
        }


        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
