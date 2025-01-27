
using System.Collections;
using System.Globalization;
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

            #region vedio 3
            List<int> num1 = new List<int>();

            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");
            //if array_list is empty count = capacity so  it make new array with double size
            num1.Add(1);
            Console.WriteLine($"nubers ={num1.Count} sizeof ={num1.Capacity}");
            num1.Add(2);
            Console.WriteLine($"nubers ={num.Count} sizeof ={num1.Capacity}");
            num1.AddRange(new int[] { 6, 7 });
            Console.WriteLine($"nubers ={num1.Count} sizeof ={num1.Capacity}");
            num1.Add(5);
            Console.WriteLine($"nubers ={num1.Count} sizeof ={num1.Capacity}");
            //count =capacity  allocate ne array with double size of old

            //to deallocate not need memory
            num1.TrimExcess(); //free dlete
            Console.WriteLine($"nubers ={num.Count} sizeof ={num.Capacity}");


            num1.EnsureCapacity(/*num*/);//set capacity with limit num 



            #region method
            List<int> number = new List<int>(){ 1,2,3,4,5};

            number.BinarySearch(5);//search in list

            IReadOnlyList<int> list = number.AsReadOnly();// copy list to refrence andnot allow access


            int even_num =number.FindLast(n =>n%2==0);
            int even_index = number.FindLastIndex(n => n % 2 == 0);

            #endregion,
            #endregion
        }
    }
}
