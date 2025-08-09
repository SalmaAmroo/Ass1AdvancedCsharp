namespace Ass1AdvancedCsharp
{
    #region Q1 
    //public class BubbleSorter
    //{
    //    public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
    //    {


    //        for (int i = 0; i < Arr.Length - 1; i++)
    //        {
    //            bool swapped = false;

    //            for (int j = 0; j < Arr.Length - i - 1; j++)
    //            {
    //                if (Arr[j].CompareTo(Arr[j + 1]) > 0)
    //                {
    //                    T temp = Arr[j];
    //                    Arr[j] = Arr[j + 1];
    //                    Arr[j + 1] = temp;

    //                    swapped = true;
    //                }
    //            }

    //            if (!swapped)
    //            {
    //                break;
    //            }
    //        }
    //    }
    //}


    #endregion

    #region Q2
    //public class Range<T> where T : IComparable<T>
    //{
    //    public T Min { get; set; }
    //    public T Max { get; set; }

    //    public Range(T min, T max)
    //    {
    //        if (min.CompareTo(max) > 0)
    //        {
    //            T temp = min;
    //            min = max;
    //            max = temp;
    //        }

    //        Min = min;
    //        Max = max;
    //    }

    //    public bool IsInRange(T value)
    //    {
    //        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    //    }

    //    public double Length()
    //    {
    //        return Convert.ToDouble(Max) - Convert.ToDouble(Min);
    //    }
    //}


    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region UsingQ1
            //int[] numbers = { 5, 1, 4, 2, 8 };
            //Console.WriteLine("Before Swapping");
            //foreach(var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //BubbleSorter.BubbleSort(numbers);
            //Console.WriteLine("\nAfter Swapping");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine("\n=================================");
            //string[] names = { "Salma", "Ahmed", "Karim", "Ziad" };
            //Console.WriteLine("\nBefore Swapping");
            //foreach (var name in names)
            //{
            //    Console.Write(name + " ");
            //}
            //BubbleSorter.BubbleSort(names);
            //Console.WriteLine("\nAfter Swapping");
            //foreach (var name in names)
            //{
            //    Console.Write(name + " ");
            //}
            #endregion

            #region UsingQ2

            //Range<int> R1 = new Range<int>(10, 20);
            //Console.WriteLine("Is 15 in range? " + R1.IsInRange(15)); 
            //Console.WriteLine("Length: " + R1.Length());

            //Range<double> R2 = new Range<double>(5.5, 10.8);
            //Console.WriteLine("Is 9.2 in range? " + R2.IsInRange(9.2)); 
            //Console.WriteLine("Length: " + R2.Length());
            #endregion
        }
    }
}

