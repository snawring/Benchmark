namespace ClosureCapturing.Core;

public class NumberFilter
{
    public IReadOnlyList<int> Numbers => [1, 2, 3, 4, 5];

    public IEnumerable<int> A()
    {
        return Numbers.Where(n => n > 2);
    }

    public IEnumerable<int> B()
    {
        int threshold = 2;
        return Numbers.Where(n => n > threshold);
    }
}


