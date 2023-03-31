class Result
{
    public static List<int> rotLeft(List<int> numbers, int rotations)
    {
        int[] values = new int[rotations];
        int aEnd = numbers.Count;

        for (int i = 0; i < rotations; i++)
        {
            values[i] = numbers[i];
        }

        for (int j = rotations; j < aEnd; j++)
        {
            numbers[j - rotations] = numbers[j];
        }

        int currentRotatedValue = 0;
        for (int rotation = aEnd - rotations; rotation < aEnd; rotation++)
        {
            numbers[rotation] = values[currentRotatedValue];
            currentRotatedValue++;
        }

        return numbers;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int rotations = Convert.ToInt32(firstMultipleInput[1]);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> result = Result.rotLeft(a, rotations);

        Console.WriteLine(String.Join(" ", result));
    }
}
