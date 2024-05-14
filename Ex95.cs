var text = "<>";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + Test(text));

text = "<>()[]{}";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + Test(text));

text = "(<>";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + Test(text));

text = "[<>()[]{}]";
Console.WriteLine("Original string: " + text);
Console.WriteLine("Verify the said string contains valid parentheses: " + Test(text));
return;

bool Test(string str)
{
    var stack = new Stack<char>();

    foreach (var ch in str)
    {
        switch (ch)
        {
            case '(':
            case '[':
            case '{':
            case '<':
                stack.Push(ch);
                break;
            case ')':
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
                break;
            case ']':
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
                break;
            case '}':
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
                break;
            case '>':
                if (stack.Count == 0 || stack.Pop() != '<')
                    return false;
                break;
        }
    }

    return stack.Count == 0;
}