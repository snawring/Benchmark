using System.Text;

namespace MyStuff.MyCode;

// The class to be benchmarked.
// Notice that this class and the project itself is completely separate from the benchmarks.
public static class StringThings
{
    public static string JoinWithStringConcatenation(IEnumerable<string> strings)
    {
        string result = string.Empty;

        foreach (var s in strings)
        {
            result += s;
        }

        return result;
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
