//Find Duplicate Elment
namespace Day3
{
    internal class DuplicateElemnt
    {
        public static void findDuplicateElement(int[] a)
        {
            HashSet<int> h = new HashSet<int>();
            foreach (int i in a)
            {
                if(h.Contains(i))
                {
                    Console.WriteLine(i + " ");
                }
                h.Add(i);
            }
            
        }

      static void Main(string[] args)
      {
        DuplicateElemnt.findDuplicateElement();
        
      }
    }
}
