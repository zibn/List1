using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._19
{
    static class BracketTestClass
    {
        static bool isBracket(char[] bracked, char ch)
        {
            int L = bracked.Length;
            bool ok = false;
            int i = -1;
            while ((i < L - 1) && !ok)
                ok = ch == bracked[++i];
            return ok;
        }
        static public int BracketTest(string a)
        {
            MyStack st = new MyStack();
            char[] begBracket = { '(', '[', '{' };
            char[] endBracket = { ')', ']', '}' };
            int lenA = a.Length;
            bool error = false;
            int result = -1;
            int i = -1;
            do
            {
                char ch = a[++i];
                if (isBracket(begBracket, ch))
                    st.AddElem(a[i]);
                else
                    if (isBracket(endBracket, ch))
                        if (!st.StackIsEmpty())
                        {
                            char ch1 = Convert.ToChar(st.StackOut());
                            switch (ch1)
                            {
                                case '(':
                                    if (ch != ')')
                                    {
                                        result = i; error = true;
                                    }
                                    break;

                                case '[':
                                    if (ch != ']')
                                    {
                                        result = i; error = true;
                                    }
                                    break;

                                case '{':
                                    if (ch != '}')
                                    {
                                        result = i; error = true;
                                    }
                                    break;
                            }
                        }
                        else
                        { error = true; result = i; }
            }
            while (!error && (i != lenA - 1));

            if (!st.StackIsEmpty() || error)
                result = i;
            return result;
        }
    }
}