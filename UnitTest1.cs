using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StackLibrary;

namespace StackTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushItem_Read_ReturnString()
        {
            IStack stack = new Stack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Read(), "WRONG");
        }

        [TestMethod]
        public void PushItem_Pop_ReturnString()
        {
            IStack stack = new Stack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Pop(), "WRONG");
        }

        [TestMethod]
        public void PushItem_Pop_ReturnString_PopReturnStringError()
        {
            IStack stack = new Stack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Pop(), "WRONG");
            Assert.AreEqual("Stack is empty", stack.Pop(), "WRONG");
        }
    }
}
