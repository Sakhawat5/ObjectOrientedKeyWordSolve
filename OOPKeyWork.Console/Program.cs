using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace OOPKeyWork.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IMember member = new Teacher("", "", "", "", "", "", "", "");

            Teacher aTeacher = member as Teacher;

            aTeacher.userMailCheck("", "");

            var sum = Sum(new int[] { 1, 2, 3 });
            sum = Sum(2, 5, 6, 7);
            sum = Sum(4, 5, 4, 5, 6, 7);

            UserParam(1, 2, 3, 4);

        }

        public static int Sum(params int[] items)
        {
            var sum = 0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }

        public static void UserParam(params int[] lits)
        {
            for (int i = 0; i < lits.Length; i++)
            {
                System.Console.WriteLine(lits[i]);
            }
        }
    }
    }
}
