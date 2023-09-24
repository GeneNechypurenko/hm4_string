using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hm4_task3_string
{
    internal class Cryptographer
    {
        private const int _cyclicShift = 26;
        public int CryptKey { get; set; }
        public string CryptText { get; set; }

        public void Encrypt(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in input)
            {
                if (char.IsLetter(symbol))
                {

                    char encripted = (char)(symbol + CryptKey);

                    if (char.IsUpper(symbol))
                    {
                        if (encripted > 'Z')
                        {
                            encripted -= (char)_cyclicShift;
                        }
                        else if (encripted < 'A')
                        {
                            encripted += (char)_cyclicShift;
                        }
                    }

                    else if (char.IsLower(symbol))
                    {
                        if (encripted > 'z')
                        {
                            encripted -= (char)_cyclicShift;
                        }
                        else if (encripted < 'a')
                        {
                            encripted += (char)_cyclicShift;
                        }
                    }

                    sb.Append(encripted);
                }

                else
                {
                    sb.Append(symbol);
                }

                CryptText = sb.ToString();
            }
        }
        public void Decrypt()
        {
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in CryptText)
            {
                if (char.IsLetter(symbol))
                {

                    char decryption = (char)(symbol - CryptKey);

                    if (char.IsUpper(symbol))
                    {
                        if (decryption < 'A')
                        {
                            decryption += (char)_cyclicShift;
                        }
                    }

                    else if (char.IsLower(symbol))
                    {
                        if (decryption < 'a')
                        {
                            decryption += (char)_cyclicShift;
                        }
                    }

                    sb.Append(decryption);
                }

                else
                {
                    sb.Append(symbol);
                }
            }

            CryptText = sb.ToString();
        }
    }
}
