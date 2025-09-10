using System.Text;
class Markov
{

    static void Main()
    {
        string all1 = File.ReadAllText(@".\datafiles\indian_history.txt", Encoding.UTF8);
        string all2 = File.ReadAllText(@".\datafiles\New Text Document.txt", Encoding.UTF8);
        string all3 = File.ReadAllText(@".\datafiles\New Text Document (2).txt", Encoding.UTF8);
        //string str = "abcdefghijklmnopqrstuvwxyz";

        string str = all1 + all3 + all2;
        str = str.ToLower();
        str = str.Replace("–", " ");
        str = str.Replace("-", " ");
        str = str.Replace("#", " ");
        str = str.Replace("*", " ");
        str = str.Replace(";", " ");
        str = str.Replace("\"", " ");
        str = str.Replace("=", " ");
        str = str.Replace("\n", " ");
        str = str.Replace("\r", " ");
        str = str.Replace("\t", " ");
        str = str.Replace("  ", " ");
        str = str.Replace("  ", " ");
        str = str.Replace("  ", " ");
        str = str.Replace("  ", " ");

        foreach (var a in str)
        {
            int b = a;
            if ((b >= 97 && b <= 122) || a == ' ')
            {

            }
            else
            {
                str = str.Replace(a.ToString(), "");
            }

        }
        str = str.Replace("  ", " "); str = str.Replace("  ", " "); str = str.Replace("  ", " ");

        string[] arr = str.Split(" ");

        foreach (var a in arr)
        {
            if(a.Length==2)
                Console.Write(a + " ");
        }


    }
    static void VoWCount()
    {

        string all1 = File.ReadAllText(@".\datafiles\indian_history.txt", Encoding.UTF8);
        string all2 = File.ReadAllText(@".\datafiles\New Text Document.txt", Encoding.UTF8);
        string all3 = File.ReadAllText(@".\datafiles\New Text Document (2).txt", Encoding.UTF8);
        //string str = "abcdefghijklmnopqrstuvwxyz";
        string str = all1 + all3 + all2;


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
                //Console.Write(a);
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