using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OOPKeyWork.Console
{
    public interface IMember
    {
        public string Ia { get; set; }
        public string Ib { get; set; }
        public string MemberId { get; set; }

        public string MemberDemo(string a, string b)
        {
            Ia = a;
            Ib = b;
            return Ia+Ib;
        }

        public int Get();
        public string Create();
    }
}
