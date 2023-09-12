using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    internal class TypeOfException
    {
        public static void TestArrayIndexOfBoundException()
        {
            try
            {
                int[] arr = { 10, 20, 30 };
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        public static void TestNullReferenceException()
        {
            try
            {
                Person p = null;
                Console.WriteLine(p.Id);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
