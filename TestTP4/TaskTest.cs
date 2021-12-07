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
            task.Description = "ceci est une description";
            Assert.AreEqual("ceci est une description",task.Description);

        }
        [Test]
        public void IsID()
        {
            task.Id = 0;
            Assert.AreEqual(0, task.Id);
        }
    }
}
