using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgorithmsDataStructures
{

    [TestClass]
    public class StackTests
    {
        
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
