using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class MyChiffre
    {
        string textToEncrypt;

        public string Encrypt(string text, string keyWord)
        {
            textToEncrypt = text;

            return EncryptDecryptXOR(text, keyWord);
        }

        public string Decrypt(string keyWord) => EncryptDecryptXOR(textToEncrypt, keyWord);

        string EncryptDecryptXOR(string encrypText, string keyWord)
        {
            var input = new StringBuilder(encrypText);
            var output = new StringBuilder(encrypText.Length);

            char tmp;

            for (int i = 0; i < encrypText.Length; )
            {
                for (var j = 0; j < keyWord.Length && i < encrypText.Length; j++, i++)
                {
                    tmp = input[i];
                    tmp = (char)(tmp ^ keyWord[j]);
                    output.Append(tmp);
                }
            }

            textToEncrypt = output.ToString();
            return textToEncrypt;
        }

    }
}
