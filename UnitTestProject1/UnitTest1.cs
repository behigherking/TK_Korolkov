using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TK_Korolkov;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WithCorrectMarks()
        {

            Assert.AreEqual(Program.GetMark("10", "50", "30", "10"), "Баллов-100, оценка 5!! Молодец");
            Assert.AreEqual(Program.GetMark("4", "50", "11", "4"), "Баллов-69, оценка 4! Хорошая работа");
            Assert.AreEqual(Program.GetMark("10", "10", "10", "9"), "Баллов-39, оценка 3! Старайся лучше");
            Assert.AreEqual(Program.GetMark("3", "3", "3", "1"), "Баллов-10, оценка 2! В любви повезёт");
        }

        [TestMethod]
        public void WithIncorrectMarks()
        {
            Assert.AreEqual(Program.GetMark("11", "100", "2", "52"), "Максимально количество баллов для 1 задания 10!!!");
            Assert.AreEqual(Program.GetMark("11", "80", "33", "25"), "Максимально количество баллов для 2 задания 50!!!");
            Assert.AreEqual(Program.GetMark("10", "50", "100", "10"), "Максимально количество баллов для 3 задания 30!!!");
            Assert.AreEqual(Program.GetMark("10", "50", "5", "11000"), "Максимально количество баллов для 4 задания 10!!!");
        }

        [TestMethod]
        public void WithWhitespaceMarks()
        {
            Assert.AreEqual(Program.GetMark("", "50", "30", "10"), "Одно из полей пропущено");
            Assert.AreEqual(Program.GetMark("10", "", "30", "10"), "Одно из полей пропущено");
            Assert.AreEqual(Program.GetMark("10", "50", "", "10"), "Одно из полей пропущено");
            Assert.AreEqual(Program.GetMark("10", "50", "30", ""), "Одно из полей пропущено");
        }

        [TestMethod]
        public void WithLetterMarks()
        {
            Assert.AreEqual(Program.GetMark("@@@", "50", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("10", "!!!", "30", "10"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("(((", "50", "###", "%%"), "Некорректные значения!");
            Assert.AreEqual(Program.GetMark("**", "&&", "30", "%%%"), "Некорректные значения!");
        }
    }
}
