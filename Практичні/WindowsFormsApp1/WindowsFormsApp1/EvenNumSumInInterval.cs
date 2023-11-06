using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class EvenNumSumInInterval
    {
        int[] nums;

        public EvenNumSumInInterval()
        {
            Random random = new Random();
            int i1 = random.Next(0, 51);
            int i2 = random.Next(51, 101);
            int size = i2 - i1 + 1;
            nums = new int[size];
            for (int i = 0; i < size; i++)
                nums[i] = i1 + i;
        }

        public EvenNumSumInInterval(int i1, int i2)
        {
            if (i1 > i2)
                throw new AverageOutOfRangeException("i1 не може бути більшим за i2!");
            else
            {
                int size = i2 - i1 + 1;
                nums = new int[size];
                for (int i = 0; i < size; i++)
                    nums[i] = i1 + i;
            }
        }

        public int GetSumOfEvenNums()
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
                if(nums[i] % 2 == 0)
                    sum += nums[i];
            return sum;
        }
    }
}
