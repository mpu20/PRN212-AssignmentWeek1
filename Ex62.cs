Console.WriteLine(ReverseRemoveParentheses("p(rq)st"));       
Console.WriteLine(ReverseRemoveParentheses("(p(rq)st)"));     
Console.WriteLine(ReverseRemoveParentheses("ab(cd(ef)gh)ij"));
return;

string ReverseRemoveParentheses(string str)
{
    var lid = str.LastIndexOf('(');

    if (lid == -1)
    {
        return str;
    }

    var rid = str.IndexOf(')', lid);

    return ReverseRemoveParentheses(
        str.Substring(0, lid) +
        new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
        str.Substring(rid + 1)
    );
}