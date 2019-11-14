using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    public class MyCipherTest
    {
        [TestMethod]
        public void MyCipher_Encode()
        {
            var chiffre = new MyCipher();
            var text = "Some text";
            var keyWord = "burry";

            Assert.AreNotEqual(text, chiffre.Encrypt(text, keyWord));
        }

        [TestMethod]
        public void MyCipher_Decode()
        {
            var chiffre = new MyCipher();
            var text = "Some text";
            var keyWord = "burry";

            chiffre.Encrypt(text, keyWord);

            Assert.AreEqual(text, chiffre.Decrypt(keyWord));
        }

        [TestMethod]
        public void MyCipher_Encode_KeyWordLongerThenText()
        {
            var chiffre = new MyCipher();
            var text = "Some text";
            var keyWord = "lackadaisical";

            chiffre.Encrypt(text, keyWord);

            Assert.AreEqual(text, chiffre.Decrypt(keyWord));
        }
    }
    
}
