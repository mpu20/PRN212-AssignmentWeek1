Console.WriteLine(Check("PHP")); 
Console.WriteLine(Check("python")); 
Console.WriteLine(Check("JavaScript"));
return;

bool Check(string str1)
{
    return str1.Equals(str1.ToUpper()) || str1.Equals(str1.ToLower());
}