using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgorithmsDataStructures
{

    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CheckMetodPush()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(22);
            stack.Push(33);

            Assert.AreEqual(3, stack.Size());
        }

        [TestMethod]
        public void CheckMethodPop()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(22);
            stack.Push(33);
            stack.Push(44);

            int stackElement = stack.Pop();

            Assert.AreEqual(44, stackElement);
            Assert.AreEqual(3, stack.Size());
        }

        [TestMethod]
        public void CheckMethodPeek()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(22);
            stack.Push(33);
            stack.Push(44);

            int stackElement = stack.Peek();

            Assert.AreEqual(3, stackElement);
            Assert.AreEqual(3, stack.Size());
        }
    }
}
