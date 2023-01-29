using System.Diagnostics;

namespace Task13._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //создали список text, присвоили строку из файла
            List<string> text = new List<string>() { File.ReadAllText("C:\\Users\\Alex\\Desktop\\Text.txt") };
            // запустили таймер
            var watchTwo = Stopwatch.StartNew();
            // добавили новый элемент из файла
            text.Add("Tom");
            // удалили новый элемент из файла
            text.Remove("Tom");
            //Выведем результат
            Console.WriteLine($"Вставка в коллекцию List<T>: {watchTwo.Elapsed.TotalMilliseconds}  мс");

            //------------------------------------------------
            var text1 = new LinkedList<string> (text);
           // var watchTwo = Stopwatch.StartNew();
            text1.AddLast("Tom");
            text1.RemoveLast();
            Console.WriteLine($"Вставка в коллекцию LinkedList<T>: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
    }
}