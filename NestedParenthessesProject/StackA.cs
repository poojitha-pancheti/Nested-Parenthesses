using System;

namespace NestedParenthessesProject
{
    class StackA
    {
        private char[] stackArray;
        private int top;
        public StackA()
        {
            stackArray = new char[10];
            top = -1;
        }
        public StackA(int maxSize)
        {
            stackArray = new char[maxSize];
            top = -1;

        }
        public int Size()
        {
            return top + 1;
        }
        public bool IsEmpty()
        {
            return (top == -1);
        }
        public bool IsFull()
        {
            return (top == stackArray.Length - 1);
        }
        public void Push(char x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }
        public char Pop()
        {
            char x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                throw new System.InvalidOperationException();

            }
            x = stackArray[top];
            top = top - 1;
            return x;

        }
    }
}
