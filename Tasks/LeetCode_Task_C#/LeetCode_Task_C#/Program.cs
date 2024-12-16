using Task_3264;

namespace Program
{
    class Prog
    {
        static void Main(string[] args)
        {
            int[] Myarr = { 2, 1, 3, 5, 6 };
            Solution anal = new Solution();


            int[] arr = anal.GetFinalState(Myarr, 5, 2);


            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
        }
    }
}