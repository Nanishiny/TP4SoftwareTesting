﻿using NUnit.Framework;
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


    }
}
