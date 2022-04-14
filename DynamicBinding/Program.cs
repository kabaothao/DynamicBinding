using System;

namespace DynamicBinding // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            //obj.GethashCode()

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);
        }
    }
}