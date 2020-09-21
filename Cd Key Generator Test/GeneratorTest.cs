using CD_Key_Generator.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cd_Key_Generator_Test
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void OptionOne()
        {//test the length of the key to make sure it is correct
            Generator letters = new Generator();
            int keyLength = 7;
            string answer = letters.ProgramKey("1", keyLength);
            Assert.AreEqual(keyLength, answer.Length);
        }
        [TestMethod]
        public void OptionTwo()
        {//test the length of the key to make sure it is correct
            Generator numbers = new Generator();
            int keyLength = 18;
            string answer = numbers.ProgramKey("1", keyLength);
            Assert.AreEqual(keyLength, answer.Length);
        }
        [TestMethod]
        public void OptionThree()
        {//test the length of the key to make sure it is correct
            Generator mixed = new Generator();
            int keyLength = 52;
            string answer = mixed.ProgramKey("1", keyLength);
            Assert.AreEqual(keyLength, answer.Length);
        }

        [TestMethod]
        public void EncryptedOptionOne()
        {//test the length of the key to make sure it is correct
            Generator letters = new Generator();
            string key = "ABC";
            string answer = letters.EncryptKey(key, "1");
            Assert.AreEqual(3, answer.Length);
        }
        [TestMethod]
        public void EncryptedOptionTwo()
        {//test the length of the key to make sure it is correct
            Generator numbers = new Generator();
            string key = "123456";
            string answer = numbers.EncryptKey(key, "2");
            Assert.AreEqual(6, answer.Length);
        }
        [TestMethod]
        public void EncryptedOptionThree()
        {//test the length of the key to make sure it is correct
            Generator mixed = new Generator();
            string key = "ABCD123";
            string answer = mixed.EncryptKey(key, "3");
            Assert.AreEqual(7, answer.Length);
        }

        [TestMethod]
        public void DecryptOptionOne()
        {//test the length of the key to make sure it is correct
            Generator letters = new Generator();
            string key = "ABCEFG";
            string answer = letters.DecryptKey(key);
            Assert.AreEqual(key.Length, answer.Length);
        }
        [TestMethod]
        public void DecryptOptionTwo()
        {//test the length of the key to make sure it is correct
            Generator numbers = new Generator();
            string key = "987654";
            string answer = numbers.DecryptKey(key);
            Assert.AreEqual(key.Length, answer.Length);
        }
        [TestMethod]
        public void DecryptOptionThree()
        {//test the length of the key to make sure it is correct
            Generator mixed = new Generator();
            string key = "A1B2C3E4F5G6";
            string answer = mixed.DecryptKey(key);
            Assert.AreEqual(key.Length, answer.Length);
        }


    }

    [TestClass]
    public class RandomizerTest
    {
        [TestMethod]
        public void Option1()
        {//ensure that the proper length is there
            Randomizer letters = new Randomizer();
            int keyLength = 7;
            string answer = letters.Letters(7);
            Assert.AreEqual(keyLength, answer.Length);
            Assert.AreEqual(1, letters.Letters(1).Length);
            Assert.AreEqual(10, letters.Letters(10).Length);
            Assert.AreEqual(100, letters.Letters(100).Length);
            Assert.AreEqual(1000, letters.Letters(1000).Length);

        }
        [TestMethod]
        public void Option1Negative()
        {//No negative numbers kind of useless because negatives will never reach Randomizer.cs
            Randomizer negLetters = new Randomizer();
            string answer = negLetters.Letters(-10);
            Assert.AreEqual(0, answer.Length);
        }

        [TestMethod]
        public void Option2()
        {
            Randomizer numbers = new Randomizer();
            Assert.AreEqual(1, numbers.Numbers(1).Length);
            Assert.AreEqual(10, numbers.Numbers(10).Length);
            Assert.AreEqual(100, numbers.Numbers(100).Length);
            Assert.AreEqual(1000, numbers.Numbers(1000).Length);
            Assert.AreEqual(10000, numbers.Numbers(10000).Length);
        }

        [TestMethod]
        public void Option2Negative()
        {//No negative numbers kind of useless because negatives will never reach Randomizer.cs
            Randomizer negNumbers = new Randomizer();
            string answer = negNumbers.Numbers(-10);
            Assert.AreEqual(0, answer.Length);
        }

        [TestMethod]
        public void Option3()
        {
            Randomizer mixed = new Randomizer();
            Assert.AreEqual(1, mixed.Mixed(1).Length);
            Assert.AreEqual(10, mixed.Mixed(10).Length);
            Assert.AreEqual(100, mixed.Mixed(100).Length);
            Assert.AreEqual(1000, mixed.Mixed(1000).Length);
            Assert.AreEqual(10000, mixed.Mixed(10000).Length);
        }

        [TestMethod]
        public void Option3Negative()
        {//No negative numbers kind of useless because negatives will never reach Randomizer.cs
            Randomizer negMixed = new Randomizer();
            string answer = negMixed.Mixed(-10);
            Assert.AreEqual(0, answer.Length);

        }
    }
    [TestClass]
    public class EncryptionTest
    {
        [TestMethod]
        public void EncryptLetters()
        {
            Encryption letters = new Encryption();
            string key = "ABCEFG";
            string answer = letters.EncryptLetters(key);
            Assert.AreEqual("BCDFGH", answer);
        }
        [TestMethod]
        public void EncryptLetters2()
        {
            Encryption letters = new Encryption();
            string key = "AEIOU";
            string answer = letters.EncryptLetters(key);
            Assert.AreEqual("BFJPV", answer);
        }
        [TestMethod]
        public void EncryptLetters3()
        {
            Encryption letters = new Encryption();
            string key = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string answer = letters.EncryptLetters(key);
            Assert.AreEqual("BCDEFGHIJKLMNOPQRSTUVWXYZA", answer);
        }
        [TestMethod]
        public void EncryptNumbers()
        {
            Encryption numbers = new Encryption();
            string key = "13579";
            string answer = numbers.EncryptNumbers(key);
            Assert.AreEqual("24680", answer);
        }
        [TestMethod]
        public void EncryptNumbers2()
        {
            Encryption numbers = new Encryption();
            string key = "2468";
            string answer = numbers.EncryptNumbers(key);
            Assert.AreEqual("3579", answer);
        }
        [TestMethod]
        public void EncryptNumbers3()
        {
            Encryption numbers = new Encryption();
            string key = "12345678901234567899876543210";
            string answer = numbers.EncryptNumbers(key);
            Assert.AreEqual("23456789012345678900987654321", answer);
        }
        [TestMethod]
        public void EncryptMixed()
        {
            Encryption mixed = new Encryption();
            string key = "ABC123";
            string answer = mixed.EncryptAlphaNumeric(key);
            Assert.AreEqual("BCD234", answer);
        }
        [TestMethod]
        public void EncryptMixed2()
        {
            Encryption mixed = new Encryption();
            string key = "ABCDEFGFEDCBA";
            string answer = mixed.EncryptAlphaNumeric(key);
            Assert.AreEqual("BCDEFGHGFEDCB", answer);
        }
        [TestMethod]
        public void EncryptMixed3()
        {
            Encryption mixed = new Encryption();
            string key = "2468WHODOWEAPPRECIATE";
            string answer = mixed.EncryptAlphaNumeric(key);
            Assert.AreEqual("3579XIPEPXFBQQSFDJBUF", answer);
        }
    }
    [TestClass]
    public class DecryptionTest
    {
        [TestMethod]
        public void DecryptLetters()
        {
            Decryption letters = new Decryption();
            char[] key = "BCDFGH".ToCharArray();
            string answer = letters.DecryptLetters(key);
            Assert.AreEqual("ABCEFG", answer);
        }
        [TestMethod]
        public void DecryptLetters2()
        {
            Decryption letters = new Decryption();
            char[] key = "BFJPV".ToCharArray();
            string answer = letters.DecryptLetters(key);
            Assert.AreEqual("AEIOU", answer);
        }
        [TestMethod]
        public void DecryptLetters3()
        {
            Decryption letters = new Decryption();
            char[] key = "BCDEFGHIJKLMNOPQRSTUVWXYZA".ToCharArray();
            string answer = letters.DecryptLetters(key);
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", answer);
        }
        [TestMethod]
        public void DecryptNumbers()
        {
            Decryption numbers = new Decryption();
            char[] key = "24680".ToCharArray();
            string answer = numbers.DecryptNumbers(key);
            Assert.AreEqual("13579", answer);
        }
        [TestMethod]
        public void DecryptNumbers2()
        {
            Decryption numbers = new Decryption();
            char[] key = "3579".ToCharArray();
            string answer = numbers.DecryptNumbers(key);
            Assert.AreEqual("2468", answer);
        }
        [TestMethod]
        public void DecryptNumbers3()
        {
            Decryption numbers = new Decryption();
            char[] key = "23456789012345678900987654321".ToCharArray();
            string answer = numbers.DecryptNumbers(key);
            Assert.AreEqual("12345678901234567899876543210", answer);
        }
        [TestMethod]
        public void DecryptMixed()
        {
            Decryption mixed = new Decryption();
            char[] key = "BCD234".ToCharArray();
            string answer = mixed.DecryptAlphaNumeric(key);
            Assert.AreEqual("ABC123", answer);
        }
        [TestMethod]
        public void DecryptMixed2()
        {
            Decryption mixed = new Decryption();
            char[] key = "BCDEFGHGFEDCB".ToCharArray();
            string answer = mixed.DecryptAlphaNumeric(key);
            Assert.AreEqual("ABCDEFGFEDCBA", answer);
        }
        [TestMethod]
        public void DecryptMixed3()
        {
            Decryption mixed = new Decryption();
            char[] key = "3579XIPEPXFBQQSFDJBUF".ToCharArray();
            string answer = mixed.DecryptAlphaNumeric(key);
            Assert.AreEqual("2468WHODOWEAPPRECIATE", answer);
        }
    }
}
