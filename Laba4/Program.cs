using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionType<Round> myCollection = new CollectionType<Round>();
            myCollection.Add(new Round(21));
            myCollection.Add(new Round(12));
            myCollection.Add(new Round(1));
            myCollection.Add(new Round(3));
            myCollection.Add(new Round(9));
            foreach (Round i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            myCollection.Remove(new Round(1));
            foreach (Round i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            myCollection.RemoveAt(3);
            foreach (Round i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            myCollection.Add(new Round(9));
            myCollection.Add(new Round(1));
            foreach (Round i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            Console.WriteLine(myCollection.IndexOf(new Round(9)));
            Console.WriteLine(new String('-', 10));

            myCollection.WriteToFile(@"array.txt");

            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 1, "Anna" },
                { 2, "Aleksandra" },
                { 3, "Liza" },
                { 4, "Lena" }
            };

            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            Console.WriteLine("Введите длину строки");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            foreach (var i in dictionary)
            {
                if (i.Value.Length == n)
                {
                    Console.WriteLine(i);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Строки заданной длины нет");
            }
           
            Console.WriteLine(new String('-', 10));

            dictionary = dictionary.OrderBy(pair => pair.Value.Length).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var i in dictionary)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            var query_1 = from i in myCollection
                          where i.Rad > 3  
                          select i;
            foreach (var i in query_1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            var query_2 = (from i in myCollection
                               select i).Take(3);
            foreach (var i in query_2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            var query_3 = from i in myCollection
                          where i.Rad < 2
                          select i;
            foreach (var i in query_3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new String('-', 10));

            Console.ReadKey();
        }
    }
}
