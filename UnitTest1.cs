using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackLibrary;

namespace StackTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PushItem_Read_ReturnString()
        {
            IStack stack = new MyStack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Read(), "WRONG");
        }

        [TestMethod]
        public void PushItem_Pop_ReturnString()
        {
            IStack stack = new MyStack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Pop(), "WRONG");
        }

        [TestMethod]
        public void PushItem_Pop_ReturnString_PopReturnStringError()
        {
            IStack stack = new MyStack();
            const string group = "ІТШІ-23-1";

            stack.Push(group);

            Assert.AreEqual(group, stack.Pop(), "WRONG");
            Assert.AreEqual("Stack is empty", stack.Pop(), "WRONG");
        }

        [TestMethod]
        public void Create_Two_Identical_Stacks_isEqual_ReturnTrue()
        {
            const string group = "ІТШІ-23-1";
            IStack stack = new MyStack();
            IStack stack2 = new MyStack();

            stack.Push(group);
            stack2.Push(group);

            Assert.AreEqual(true, stack.isEqual(stack2), "WRONG");
        }
        [TestMethod]
        public void Create_Two_Different_Stacks_isEqual_ReturnFalse()
        {
            const string group = "ІТШІ-23-1";
            const string group2 = "ІТШІ-23-2";
            IStack stack = new MyStack();
            IStack stack2 = new MyStack();

            stack.Push(group);
            stack2.Push(group2);

            Assert.AreEqual(false, stack.isEqual(stack2), "WRONG");
        }
    }
}
