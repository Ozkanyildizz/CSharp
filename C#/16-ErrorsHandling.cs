using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ErrorsHandling
    {
        public void studentPull()
        {
            int[] responses = { 1, 2, 3, 3, 4, 5, 4, 4, 5, 5, 5, 2, 1, 2, 3, 4, 5, 3, 2, 5, 4, 1, 1, 1, 1, 3, 4, 5, 14 };

            int[] frequency = new int[6];

            for (int response = 0; response < responses.Length; ++response)
            {
                try
                {
                    ++frequency[responses[response]];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"responses[{response}] = {responses[response]}");


                }
            }
            foreach (int freq in frequency) Console.WriteLine(freq);
        }
    }
}