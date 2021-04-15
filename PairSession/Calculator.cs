using System;

namespace PairSession
{
    public class calculator
    {
        public static int Add(string numbers) 
        {
         
            if(int.TryParse(numbers, out int number)) 
            {
                return number;
            }
            return 0;
        }
    }
}
