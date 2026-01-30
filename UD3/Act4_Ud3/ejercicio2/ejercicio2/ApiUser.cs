using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    internal class ApiUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public ApiAddress Address { get; set; }
        public string Phone { get; set; }
        public ApiCompany Company { get; set; }
    }
    public class ApiAddress
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
    public class ApiCompany
    {
        public string Name { get; set; }
    }
}
