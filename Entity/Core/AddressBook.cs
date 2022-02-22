using System;
using Entity.Shared;

namespace Entity.Core
{
    public class AddressBook : EntityId
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
    }
}