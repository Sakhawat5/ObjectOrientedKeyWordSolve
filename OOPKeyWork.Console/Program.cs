using System;
using System.Security.Cryptography.X509Certificates;

namespace OOPKeyWork.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IMember member = new Teacher("", "", "", "", "", "", "", "");


            Teacher aTeacher = member as Teacher;

            aTeacher.userMailCheck();


        }
    }
}
