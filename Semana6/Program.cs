namespace Semana6
{
    internal class Program
    {
        static void Main()
        {
            //ForTest forTest = new ForTest();
            //int result = forTest.Soma(5, 6, 7, 8);
            //Console.WriteLine(result);

            Ex6 ex6 = new Ex6();
            List<int> list = new List<int>() { 10, 1, 2, 4, 6, 3, 5, 9, 8, 9, 7 };
            List<int> resultado = ex6.Sort(list);
            foreach (int i in resultado)
            {
                Console.WriteLine(i);
            }
        }
    }
}