using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.Tests
{
    [TestClass]
    public class MyChiffreTest
    {
        [TestMethod]
        public void MyChiffre_Encode()
        {
            var chiffre = new MyChiffre();
            var text = "Some text";
            var keyWord = "burry";

            Assert.AreNotEqual(text, chiffre.Encrypt(text, keyWord));
        }

        [TestMethod]
        public void MyChiffre_Decode()
        {
            var chiffre = new MyChiffre();
            var text = "Some text";
            var keyWord = "burry";

            chiffre.Encrypt(text, keyWord);

            Assert.AreEqual(text, chiffre.Decrypt(keyWord));
        }

        [TestMethod]
        public void MyChiffre_Encode_KeyWordLongerThenText()
        {
            var chiffre = new MyChiffre();
            var text = "Some text";
            var keyWord = "lackadaisical";

            chiffre.Encrypt(text, keyWord);

            Assert.AreEqual(text, chiffre.Decrypt(keyWord));
        }
    }
    
}
