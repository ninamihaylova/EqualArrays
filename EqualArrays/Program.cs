class EqualArrays
{
    static void Main()
    {
        
        int[] numbers1 = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
        int[] numbers2 = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

        if (numbers1.Length != numbers2.Length)
        {
            Console.WriteLine("Arrays are not identical.");
            return;
        }

        bool areIdentical = true;
        for (int i = 0; i < numbers1.Length; i++)
        {
            if (numbers1[i] != numbers2[i])
            {
                areIdentical = false;
                break;
            }
        }

        if (areIdentical)
        {
            Console.WriteLine("Arrays are identical.");
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
    }
}