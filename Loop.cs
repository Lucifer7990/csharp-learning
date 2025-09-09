using Constants;
class Program
{
    static void Main()
    {
        Console.Write("How many numbers do you want to enter? ");
        int count;
        if (!int.TryParse(Console.ReadLine(), out count))
            Console.WriteLine("Invalid input. Please enter a valid integer.");

        var nums = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out nums[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                i--;
            }
        }

        Console.Write("You entered: ");
        foreach (int n in nums)
        {
            Console.Write(n);
            Console.Write(" ");
        }

        Console.WriteLine($"Sum = {nums.Sum()}");
        Console.WriteLine($"Largest = {nums.Max()}");
        Console.WriteLine($"Smallest = {nums.Min()}");

    }
}




// How many numbers do you want to enter? 5
// Enter number 1: 10
// Enter number 2: 25
// Enter number 3: 7
// Enter number 4: 40
// Enter number 5: 15

// You entered: 10 25 7 40 15
// Sum = 97
// Largest = 40
// Smallest = 7