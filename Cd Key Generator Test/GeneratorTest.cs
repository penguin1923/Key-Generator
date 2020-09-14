using CD_Key_Generator.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cd_Key_Generator_Test
{/*[TestClass]*/
    //public class GeneratorTest
    //{
    //    [TestMethod]
    //    public void OptionOne()
    //    {
    //        Generator letters = new Generator();
    //        int keyLength = 7;
    //        string answer = letters.ProgramKey("1", keyLength);
    //        Assert.AreEqual(keyLength, answer.Length);
    //    }
    //    test the length of the key to make sure it is correct




    //}

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
        {//No negative numbers
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
        {
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
        {//just a place holder
            Randomizer neg = new Randomizer();
            Assert.AreEqual(1,10);
            
        }
    }
}
