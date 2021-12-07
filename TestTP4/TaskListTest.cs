using NUnit.Framework;
using System.Collections.Generic;
using TP4.Models;

namespace TP4
{
    [TestFixture]
    class TaskListTest
    {
        TaskList taskList;

        [SetUp]
        public void Setup()
        {
            taskList = new TaskList();
        }

        [Test]
        public void IsTaskInTasks()
        {
            Assert.AreEqual(new List<Task>(), taskList.Tasks);
        }

        [Test]
        public void AddTask()
        {
            Task task = new Task();
            taskList.add(task);
            Assert.AreEqual(new List<Task> { task }, taskList.Tasks);
        }

        [Test]
        public void RemoveTask()
        {
            Task task = new Task();
            taskList.add(task);
            taskList.remove(task);
            Assert.AreEqual(new List<Task>(), taskList.Tasks);
        }
    }
}
