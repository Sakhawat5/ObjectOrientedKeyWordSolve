using System;
using System.Collections.Generic;
using System.Text;

namespace OOPKeyWork.Console
{
    public class UserTest: User
    {
        public string UserTestId { get; set; }
        public string UserFastName { get; set; }
        public string UserLastName { get; set; }

        public UserTest(string fastName, string lastName, string username, string password) : base(username, password)
        {
            UserFastName = fastName;
            UserLastName = lastName;
            Id = "Something";
        }

        public override string UserGenarated()
        {
            return "abcv";
        }

    }
}
