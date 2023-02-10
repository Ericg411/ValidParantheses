using System.Collections;
namespace ValidParantheses;
public class Class1
{
    public bool IsValid(string s)
    {

        Stack openers = new Stack();

        if (s.Length <= 1)
        {
            return false;
        }

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                openers.Push(c);
            }
            else
            {
                if (openers.Count == 0 && (c == ')' || c == '}' || c == ']'))
                {
                    return false;
                }
                else if (openers.Count == 0)
                {
                    break;
                }
                char poppedOpener = (char)openers.Pop();
                switch (c)
                {
                    case ')':
                        if (poppedOpener != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (poppedOpener != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (poppedOpener != '[')
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        if (openers.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
