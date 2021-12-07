using NUnit.Framework;
using TP4.Models;

namespace TP4
{
    [TestFixture]
    class ParserTest
    {
        private Parser parser;

        [SetUp]
        public void Setup()
        {
            parser = new Parser();
        }

        [Test]
        public void InputPlus()
        {
            Assert.AreEqual((Operator.add, "Se faire couper les cheveux"), parser.readInput("+ Se faire couper les cheveux"));
        }

        [Test]
        public void InputMoins()
        {
            Assert.AreEqual((Operator.remove, "Se faire couper les cheveux"), parser.readInput("- Se faire couper les cheveux"));
        }
    }
}
