

class Result
{
    public static List<int> rotLeft(List<int> a, int d)
    {
        int val0 = a[0];

        for (int i = 1; i < a.Count; i++)
        {
            a[i - 1] = a[i];
        }

        a[a.Count - 1] = val0;

        return a;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = new();
        for (int i = 0; i < d; i++)
        {
            result = Result.rotLeft(a, d);
        }

        Console.WriteLine(String.Join(" ", result));
    }
}
