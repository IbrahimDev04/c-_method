namespace Methods_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çevrənin sahəsi 
            Console.WriteLine(Area(3));

            //Düzbucaqlının sahəsi
            Console.WriteLine(Area(4, 5));

            //Düzbucaqlı paralelpipedin tam səthinin sahəsi
            Console.WriteLine(Area(2, 5, 7));

            //Düzbucaqlı paralelpipedin tam səthinin sahəsi
            Console.WriteLine(Area(5, 2, 4, 6));

        }


        //Çevrənin sahəsi 
        public static int Area(int r)
        {
            int area = 3 * r * r;
            return area;

        }



        //Düzbucaqlının sahəsi
        public static int Area(int a, int b)
        {
            int area = a * b;
            return area;

        }



        //Düzbucaqlı paralelpipedin tam səthinin sahəsi
        public static int Area(int a, int b, int c)
        {
            int area = 2 * (a * b + b * c + a * c);
            return area;

        }



        //Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi
        public static int Area(int r, int a, int b, int c)
        {
            int area = (a+b+c)/2*r;
            return area;

        }
    }
}
