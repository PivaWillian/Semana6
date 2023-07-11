namespace Semana6
{
    internal class Ex6
    {
        public List<int> Reverse(List<int> list)
        {
            List<int> toReturn = new List<int>();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                toReturn.Add(list[i]);
            }
            return toReturn;
        }

        public List<int> Sort(List<int> list)
        {
            List<int> toReturn = new List<int>();
            for(int i = 0; i < list.Count; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[i])
                    {
                        int temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }
    }
}
