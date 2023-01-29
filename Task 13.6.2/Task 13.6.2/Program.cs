using static System.Net.Mime.MediaTypeNames;
using System.Linq;

namespace Task_13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\Alex\\Desktop\\Text1.txt");
            var a = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] words = a.Split(new char[] { ' ' });
            var words1 = new Dictionary<string, int>();

            foreach (var i in Distinct(words))
            words1.Add(i, DigitCount(words, i));

            List<KeyValuePair<string, int>> mappings = words1.ToList();
            mappings.Sort((x, y) => x.Value.CompareTo(y.Value));

            int j = words.Length;
            for (int i= j; i == j - 10; i=i-1)
            { Console.WriteLine(mappings);}
            

           
        }
        static string[] Distinct(string[] a)
            {
                HashSet<string> list = new HashSet<string>(a);
                string[] b = new string[list.Count];
                list.CopyTo(b);
                return b;
            }
        static int DigitCount(string[] a, string b)
        {
            int count = 0;

            foreach (var i in a)
                if (i == b) count++;

            return count;
        }
    }
}