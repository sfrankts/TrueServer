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
    }
}
