namespace Semana6
{
    public class ForTest
    {
        public int Soma(params int[] list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum+= i;
            }

            return sum;
        }
    }
}
