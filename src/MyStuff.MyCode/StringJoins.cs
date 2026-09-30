using System;
using System.Collections.Generic;
using System.Text;

namespace MyStuff.MyClasses;

public static class StringJoins
{
    public static string JoinWithPlusOperator(IEnumerable<string> strings)
    {
        string result = string.Empty;

        foreach (var s in strings)
        {
            result += s;
        }

        return result;
    }

    public static string JoinWithStringJoin(IEnumerable<string> strings)
    {
        return string.Join(string.Empty, strings);
    }

    public static string JoinWithStringBuilder(IEnumerable<string> strings)
    {
        var stringBuilder = new StringBuilder();
        foreach (var s in strings)
        {
            stringBuilder.Append(s);
        }
        return stringBuilder.ToString();
    }
}
