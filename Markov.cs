using System.Text;
class Markov
{
    static void Main()
    {

        string all1 = File.ReadAllText(@".\datafiles\indian_history.txt", Encoding.UTF8);
        string all2 = File.ReadAllText(@".\datafiles\New Text Document.txt", Encoding.UTF8);
        string all3 = File.ReadAllText(@".\datafiles\New Text Document (2).txt", Encoding.UTF8);
        //string str = "abcdefghijklmnopqrstuvwxyz";
        string str = all1+all3;


        int Count = 0;
        int vovlCount = 0;
        str = str.ToLower();

        //Console.WriteLine(str);


        Console.WriteLine();
        foreach (var a in str)
        {
            int b = a;
            if (b >= 97 && b <= 122)
            {
                Console.Write(a);
                Count++;
                if (b == 97 || b == 101 || b == 105 || b == 111 || b == 117)
                {
                    vovlCount++;
                }
            }

        }
        Console.WriteLine();
        float per = (float)vovlCount / (float)Count;
        Console.WriteLine(per);
        Console.WriteLine(vovlCount);
        Console.WriteLine(Count);




    }
}