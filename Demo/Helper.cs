using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T> where T : IComparable  
    {
        #region Swap
        public static void Swap(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }
        //public static void Swap (ref int x , ref int y )
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion

        #region Search Array
        //public static int SearchArray<T>(T[] Arr, T value)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i].Equals(value))
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region BubbleSort
        public static void BubbleSort(T[] Arr)
        {
            if (Arr is not null)
            {
                for(int i = 0; i<Arr.Length; i++)
                {
                    for(int k = 0; k< Arr.Length-i-1;k++)
                    {
                        if (Arr[k].CompareTo(Arr[k + 1]) ==1)
                            Helper<T>.Swap(ref Arr[k], ref Arr[k + 1]);
                    }
                }
            }
        }
        #endregion
    }
}
