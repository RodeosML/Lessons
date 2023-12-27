using System;
using System.Collections.Generic;


namespace AlgorithmsDataStructures
{

    public class Stack<T>
    {
        List<T> stack;
        int count;

        public Stack()
        {
            stack = new List<T>();
            count = 0;
        }

        public int Size()
        {
            if (count != 0) return count;

            return 0;
        }

        public T Pop()
        {
            if (count != 0)
            {
                T stackElement = stack[count - 1];
                stack.RemoveAt(count - 1);
                count--;

                return stackElement;
            }
            return default(T);
        }

        public void Push(T val)
        {
            stack.Add(val);
            count++;
        }

        public string CheckBalanceBrackets(string _valueString)
        {
            if (Check(_valueString) == false) return "Not balanced";
                return "Balanced";

            bool Check(string _valueString)
            {
            if (_valueString[0].ToString() == ")" || _valueString[_valueString.Length - 1].ToString() == "(")
                return false;

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < _valueString.Length; i++)
            {
                if (_valueString[i] == '(') stack.Push(_valueString[i].ToString());
                else if (_valueString[i] == ')' && stack.Size() != 0) stack.Pop();
                else return false;
            }
            if (stack.Size() == 0) return true;
            else
                return false;
            }
        }

        public int EvaluatePostfixExpression(string _expression)
        {
            Stack<string> operators = new Stack<string>();
            Stack<int> numbers = new Stack<int>();

            var arrayString = _expression.Split(' ');

            for (int i = arrayString.Length - 1; i >= 0; i--)
            {
                operators.Push(arrayString[i]);
            }

            int result = 0;
            string cache;
            int length = operators.Size();

            for (int i = 0; i < length; i++)
            {
                switch (cache = operators.Pop())
                {
                    case "+":
                        {
                            result = numbers.Pop() + numbers.Pop();
                            numbers.Push(result);
                            break;
                        }
                    case "-":
                        {
                            var a = numbers.Pop();
                            var b = numbers.Pop();
                            result = b-a;
                            numbers.Push(result);
                            break;
                        }
                    case "*":
                        {
                            result = numbers.Pop() * numbers.Pop();
                            numbers.Push(result);
                            break;
                        }
                    case "/":
                        {
                            var a = numbers.Pop();
                            var b = numbers.Pop();
                            result = b / a;
                            numbers.Push(result);
                            break;
                        }
                    case "=":
                        {
                            return result;
                        }
                    default:
                        {
                            numbers.Push(Convert.ToInt32(cache.ToString()));
                            break;
                        }
                }
            }
            return result;
        }

    }
}