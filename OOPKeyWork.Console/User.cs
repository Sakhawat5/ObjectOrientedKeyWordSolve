using System;
using System.Collections.Generic;
using System.Text;

namespace OOPKeyWork.Console
{
    public abstract class User
    {
        private readonly string name = "Sakhawat";
        private const int id = 1234567;
        private const Month month = Month.January;
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public abstract string UserGenarated();

        public void userMailCheck(string a, string b)
        {
            string data =a + b;
            System.Console.WriteLine("abc"+data);
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Id = "Something";
        }

        public enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
