using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CreatingAFarm;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sheep terry = new Sheep();
            terry.Name = "Terry";
            Assert.AreEqual("Terry", terry.Name);

            Horses seabiscuit = new Horses();
            seabiscuit.Name = "Seabiscuit";
            Assert.AreEqual("Seabiscuit", seabiscuit.Name);

            Chicken albertEggstein = new Chicken();
            albertEggstein.Name = "Albert Eggstein";
            Assert.AreEqual("Albert Eggstein", albertEggstein.Name);

            Cow bessie = new Cow();
            bessie.Name = "Bessie";
            Assert.AreEqual("Bessie", bessie.Name);
        }
    }
}
