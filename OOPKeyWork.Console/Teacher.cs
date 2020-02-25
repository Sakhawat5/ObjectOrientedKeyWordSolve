using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPKeyWork.Console
{
    public class Teacher: UserTest, IMember 
    {
        public Teacher(string fastName, string lastName, string username, string password, string teacherId, string a, string b, string memberId): base(fastName, lastName, username, password)
        {
            TeacherId = teacherId;
            Ia = a;
            Ib = b;
            MemberId = memberId;
        }

        public string TeacherId { get; set; }
        public string Ia { get; set; }
        public string Ib { get; set; }
        public string MemberId { get; set; }
        

        public string MemberDemo()
        {
            return "Hello";
        }

        

        public string Create()
        { 
            string data = "abv";
            return data;
        }

        public int Get()
        {
            Ia = "123";
            Ib = "456";
            int test = Int32.Parse(Ia + Ib);
            return test;
        }
    }
}
