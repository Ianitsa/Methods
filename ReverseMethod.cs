using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_methods
{
    class ReverseMethod
    {
        static void Main(string[] args)
        {
            //	Метод който обръща изречение:
            // Пример input: „C# is not C++, not PHP and not Delphi“  


            string inputText = Console.ReadLine();

             Console.WriteLine(ReverceOrderInSecuence(inputText));
            //output "Delphi is not C++, not PHP and not Delphi"

            Console.WriteLine(ReverceOrderInSecuenceVar2(inputText));
            // output:       „Delphi not and PHP, not C++ not is C#“
            // var v = Environment.MachineName;
            //Console.WriteLine(v);
        }

        private static string ReverceOrderInSecuenceVar2(string inputText)
        {
            string[] listArr = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> count = new List<int>();
            List<string> list = new List<string>();
            StringBuilder sb = new StringBuilder();

            List<string> oldItems = new List<string>();
            string oldItem = string.Empty;

            foreach (var item in listArr.Select((Value, Index) => new { Value, Index }))
            {
                if (item.Value.Contains(','))
                {
                    count.Add(item.Index);
                    oldItem = item.Value;
                    var v = oldItem.Split(',');
                    oldItem = v[0];
                    list.Add(oldItem);
                }
                else
                {
                    list.Add(item.Value);
                }

            }

            list.Reverse();

            foreach (var item in list.Select((Value, Index) => new { Value, Index }))
            {
                sb.Append(item.Value.Trim());
                if (item.Index == count.FirstOrDefault())
                {
                    sb.Append(", ");
                    count.RemoveAt(0);
                }

                sb.Append(" ");
            }

            return sb.ToString();
        }
        private static string ReverceOrderInSecuence(string inputText)
        {

            List<string> list = new List<string>();
            List<int> ListCountOfElement = new List<int>();
            StringBuilder sb = new StringBuilder();


            string[] listArr = inputText.Split(new[] { ' ' });
            List<int> count = new List<int>();

            List<string> oldItems = new List<string>();
            string oldItem = string.Empty;

            foreach (var item in listArr.Select((Value, Index) => new { Value, Index }))
            {
                if (item.Value.Contains(','))
                {
                    count.Add(item.Index);
                    oldItem = item.Value;
                }

                for (int j = 0; j < 1; j++)
                {
                    if (item.Value.Any(c => char.IsUpper(c)))
                    {
                        if (item.Value.Contains((',')))
                        {
                            var v = oldItem.Split(',');
                            oldItem = v[0];

                            list.Add(oldItem);
                            ListCountOfElement.Add(item.Index);
                            // Console.WriteLine(oldItem);
                        }
                        else
                        {
                            list.Add(item.Value);
                            ListCountOfElement.Add(item.Index);
                        }


                    }
                }
                // Console.WriteLine("Value=" + item.Value + ", Index=" + item.Index);
            }
            list.Reverse();
            foreach (var item in listArr.Select((Value, Index) => new { Value, Index }))
            {
                if (item.Index == ListCountOfElement.FirstOrDefault())
                {

                    sb.Append(list.FirstOrDefault());

                    if (item.Index == count.FirstOrDefault())
                    {
                        sb.Append(", ");
                        count.RemoveAt(0);
                    }
                    else
                    {
                        continue;
                    }
                    sb.Append(" ");
                    list.RemoveAt(0);
                    ListCountOfElement.RemoveAt(0);
                }
                else
                {
                    sb.Append(item.Value);
                    sb.Append(" ");
                }
            }

            return sb.ToString();

            //foreach (var item in list )
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in ListCountOfElement)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in count)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
