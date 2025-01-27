
using System.Collections;
using System.Runtime.CompilerServices;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vedio 2
            ArrayList num = new ArrayList();

            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            //if array_list is empty count = capacity so  it make new array with double size
            num.Add(1);
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            num.Add(2);
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            num.AddRange(new int [] {6,7});
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            num.Add(5);
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            //count =capacity  allocate ne array with double size of old

            //to deallocate not need memory
            num.TrimToSize(); //free dlete
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");

            //problem of array list
            //1-boxing and un boxing which kead to low berformance
            //2-un save custing 





            #endregion
        }
    }
}
