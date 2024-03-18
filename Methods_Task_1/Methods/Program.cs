//Method Task: Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.



namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 42, 112, 65, 856, 234, 5433, 3234};
            Console.WriteLine(CalLower(arr));
        }

        public static int CalLower(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
