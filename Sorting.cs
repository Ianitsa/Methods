using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class Sorting
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(6);
            list.Add(1);
            list.Add(7);
            list.Add(4);
            list.Add(9);

            Bubble(list);

        }

        //Method for BUBBLE sorting

        //compare each value with the following value,
        //if greater then swap, else continue to next consecutive pair
        public static void Bubble(List<int> sort)
        {
            int tempvar;
            for (int i = 1; i <= sort.Count; i++)
            {
                for (int j = 0; j < sort.Count - i; j++)
                {                    
                    if (sort[j] > sort[j + 1])
                    {
                        tempvar = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = tempvar;
                    }
                }
            }

            //display sort         
            foreach (var item in sort)
            {
                Console.WriteLine(item);
            }
        }

        //Input array: {3,2,4,1,5}

    }
}
