public class Practice
{
    static void Main()
    {
        Student std = new Student();

        Console.WriteLine(std.GetGrade());
        

    }
    static void WordCounter()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine() ?? "";
        input = input.ToLower();
        string[] strArr = input.Split(" ");
        Dictionary<string, int> dict = new Dictionary<string, int>();

        foreach (var str in strArr)
        {
            if (dict.ContainsKey(str))
            {
                dict[str] = dict[str] + 1;
            }
            else
            {
                dict.Add(str, 1);
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} --> {item.Value}");
        }
    }
    static void Game()
    {
        Console.WriteLine("Guess the number between 1 and 100");
        int num = new Random().Next(100) + 1;

        for (var i = 0; i < 10; i++)
        {
            Console.Write($"Guess {i + 1} :");
            int.TryParse(Console.ReadLine(), out int guss);

            if (guss == num)
            {
                Console.WriteLine("You Win!");
                break;
            }
            else
            {
                Console.WriteLine((guss < num) ? "Too Low!" : "Too High!");
            }
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }

    public char GetGrade()
    {
        return (Marks>20) ? 'A':'Z';
    }
    
}