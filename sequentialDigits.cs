
using System.Globalization;

namespace Sequential_Digits
{
    internal class sequentialDigits : IsequentialDigits
    {
        public List<int>? sequentiallist(int low, int high)
        {
            List<int>? sequentialList = new();
            for (int i = 1; i < 9; i++)
            {
                int num = i;
                for (int j = i+1; j <= 9; j++)
                {
                    num = (num * 10) + (j % 10);
                    if (num > high)
                        j = high + 1;
                    if (num>=low && num<=high)
                    {
                        sequentialList.Add(num);
                    }
                }
            }
            sequentialList?.Sort();
            return sequentialList;

        }
    }
}
