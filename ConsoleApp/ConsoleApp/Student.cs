using System;
namespace ConsoleApp
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }    
    }
}
