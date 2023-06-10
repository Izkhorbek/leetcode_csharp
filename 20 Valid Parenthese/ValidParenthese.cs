using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCTopInterviewQuestiona
{
    public class ValidParenthese
    {
         public bool isValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            Dictionary<char, char> parenthese = new Dictionary<char, char>()
            {
                { '(',')' },
                { '[',']' },
                { '{','}' },
            };

            Stack<char> Parentheses = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
               if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    Parentheses.Push(s[i]);
                }
                else if(s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    if (Parentheses.Count == 0) return false;

                    if(parenthese[Parentheses.Pop()] != s[i])
                    {
                        return false;
                    }
                }
            }

            return Parentheses.Count == 0;
        }
    }
}
