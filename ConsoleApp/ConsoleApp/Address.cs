using System;
namespace ConsoleApp
{
    public class Address
    {
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual Student Student { get; set; }
    }
}