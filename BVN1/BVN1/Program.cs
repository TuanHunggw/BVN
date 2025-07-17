using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVN1
{
    internal class Program
    {
        static void PrintDirection(Direction dir)
        {
            switch (dir)
            {
                case Direction.Forward:
                    Console.WriteLine("di truoc");
                    break;
                case Direction.Backward:
                    Console.WriteLine("di sau");
                    break;
                case Direction.Left: Console.WriteLine("di trai"); break;
                case Direction.Right: Console.WriteLine("di phai"); break;
                default:
                    Console.WriteLine("k xac dinh duoc huong");
                    break;
            }

        }
        enum Direction
        {
            Forward,
            Backward,
            Left,
            Right
        }
        static int[] RandomArray(int n)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();

            for (int i = 0; i <= n; i++)
            {
                numbers.Add(i);
                
            }
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                int j = random.Next(i+1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
            return numbers.ToArray();
        }

        static void Main(string[] args)
        {


            //// BTNV1
            //int[] list = { 1, 12, 43, 24, 85, 26,17, 98, 19, 102, 131, 129 };
            //Array.Sort(list);
            //Console.WriteLine(string.Join(", ",list));

            ////BTVN2
            //List<int> inList = new List<int> { 1, 12, 43, 24, 1, 26, 17, 98, 1, 102, 1, 129 };
            //int toRemove = 1;
            //List<int> outList = inList.Where(x => x != toRemove).ToList();
            //Console.WriteLine(string.Join(", ", outList));

            ////BTVN3
            //int[] array = { 1, 2, 6, 9, 1, 1, 9, 6, 1, 9 };
            //var dic = new Dictionary<int, int>();
            //foreach (var num in array)
            //{
            //    dic[num] = dic.ContainsKey(num) ? dic[num] +1 : 1;
            //}
            //foreach (var kv in dic)
            //{
            //    Console.WriteLine($"dic[{kv.Key}] = {kv.Value}");
            //}

            ////BTVN4
            //PrintDirection(Direction.Forward);
            //PrintDirection(Direction.Backward);

            /////BTVN5
            //int i = 10;
            //int[] result = RandomArray(i);
            //Console.WriteLine(string.Join(", ", result));

            ////BTVN6
            



    }  }   
}
    
    

    
    

