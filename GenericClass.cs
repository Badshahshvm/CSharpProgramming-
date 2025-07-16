//Generic Class

    class Example<T>
    {
        T b;
        public Example(T b)
        {

            this.b = b;
        }
        public  T getBox()
        {
            return this.b;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Example<int> e = new Example<int>(2);
            Console.WriteLine(e.getBox());
              Example<int> e2 = new Example<int>("shivam");
             Console.WriteLine(e2.getBox());
        }
    }
