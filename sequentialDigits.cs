
namespace Sequential_Digits
{
    internal class sequentialDigits : IsequentialDigits
    {
        public List<int>? sequentiallist(int low, int high)
        {
            List<int>? sequentiallist = new();
            for (int i = low; i <= high; i++)
            {
                int sequentialDigits = ((i * 10) + ((i % 10) + 1));
                if (sequentialDigits <= high)
                    sequentiallist.Add(sequentialDigits);
            }
            return sequentiallist;
        }
    }
}
