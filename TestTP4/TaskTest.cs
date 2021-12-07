using NUnit.Framework;
using TP4.Models;

namespace TP4
{
    [TestFixture]
    class TaskTest
    {
        private Task task;

        [SetUp]
        public void Setup()
        {
            task = new Task();
        }

        [Test]
        public void IsDescription()
        {
            task.description = "ceci est une description";
            Assert.AreEqual("ceci est une description",task.description);

        }
        [Test]
        public void IsID()
        {
            task.id = 0;
            Assert.AreEqual(0, task.id);
        }
    }
}
