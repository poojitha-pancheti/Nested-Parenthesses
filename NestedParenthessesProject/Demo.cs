using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace NestedParenthessesProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            string expression;
            Console.WriteLine("Enter an expression with parenthesses:");
            expression = Console.ReadLine();
            if (IsValid(expression))
                Console.WriteLine("Valid expression");
            else
                Console.WriteLine("Invalid expression");
           static bool IsValid(string expr)
            {
                StackA st = new StackA();
                char ch;
                for (int i = 0; i < expr.Length; i++)
                {
                    if (expr[i] == '(' || expr[i] == '{' || expr[i] == '[')
                        st.Push(expr[i]);
                    if (expr[i] == ')' || expr[i] == '}' || expr[i] == ']')
                        if (st.IsEmpty())
                        {
                            Console.WriteLine("Right parenthesses are more than left parenthsses");
                            return false;
                        }

                        else
                        {
                            ch = st.Pop();
                            if (!MatchParenthesses(ch, expr[i]))
                            {
                                Console.WriteLine("Missed matched parameters are:");
                                Console.WriteLine(ch + "and" + expr[i]);
                                return false;
                            }
                        }
                }
                if (st.IsEmpty())
                {
                    Console.WriteLine("Balanced Parenthesses");
                    return true;
                }
                else
                {
                    Console.WriteLine("Left paranthesses are less than right paranthesses");
                    return false;
                }
           }     
        }
        static bool MatchParenthesses(char leftpar, char rightpar)
        {
            if (leftpar == '[' && rightpar == ']')
                return true;
            if (leftpar == '(' && rightpar == ')')
                return true;
            if (leftpar == '{' && rightpar =='}')
                return true;
            return false;

        }
    }
}
