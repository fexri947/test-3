using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 2, 3, 4, 5, 6 };
            
            for (int i = 0; i < numbers.Length; i++)
                
            { if (numbers[12]== numbers[i])
                {
                    count++;
                }
            if (count != 1)
                {
                    Console.WriteLine(numbers[1]+" ededi "+count+"defe tekrarlanib");
                }
                

            }
          
        }
    }
}





  //foreach (int item in numbers)
  //          {
  //              if (numbers[0] == item)
  //              {
  //                  count++;
  //              }
  //              if (count != 1)
  //              {
  //                  Console.WriteLine(numbers[0]+"  ededi  "+count+"  denedir");
  //                  break;
  //              }
  //          }
