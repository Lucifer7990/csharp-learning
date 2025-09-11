using System.Text;
class Markov
{
    static void Main()
    {
        Console.WriteLine(GenrateString(500));
    }


    static string GenrateString(int? c=20, string? abc="the")
    {
        var dict = GetStructuredData();
        Random rnd = new Random();
        string str = "";
        int count = c ?? 20;
        string Word = abc ?? "the";
        for (var i = 0; i < count; i++)
        {

            int pos = rnd.Next(dict[Word].Count);
            str += Word + " ";
            Word = dict[Word][pos];

        }
        return str;
    }
    static Dictionary<string, List<string>> GetStructuredData()
    {

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        string[] arr = GetStringArr();
        string pointer = "";
        foreach (var word in arr)
        {
            if (!dict.ContainsKey(word) && word!="")
            {
                dict.Add(word, []);
            }

            if (pointer != "")
            {
                dict[pointer].Add(word);
            }

            pointer = word;
        }

        return dict;

    }
    static string[] GetStringArr()
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

        return arr;


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