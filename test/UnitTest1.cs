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
        public void CheckBalancedMethodBrackets()
        {
            Stack<string> stack = new Stack<string>();

            var dataSet = "()()()()()()()";

            Assert.AreEqual("Balanced", stack.CheckBalanceBrackets(dataSet));
        }

        [TestMethod]
        public void CheckNotBalancedMethodBrackets()
        {
            Stack<string> stack = new Stack<string>();

            var dataSet = "(()()()()()(";

            Assert.AreEqual("Not balanced", stack.CheckBalanceBrackets(dataSet));
        }

        [TestMethod]
        public void CheckEvaluatePostfixExpression()
        {
            Stack<string> stack = new Stack<string>();

            string result = ("8 2 + 5 * 9 + =");
            string result2 = ("8 12 - 4 / 5 + =");
            
            Assert.AreEqual(59, stack.EvaluatePostfixExpression(result));
            Assert.AreEqual(4, stack.EvaluatePostfixExpression(result2));
        }
    }
}
