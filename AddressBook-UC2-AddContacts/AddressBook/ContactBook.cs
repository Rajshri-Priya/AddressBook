﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactBook
    {
        public class Contact
        {

            List<Contact> addressList = new List<Contact>();
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string MobileNumber { get; set; }
            public string Email { get; set; }
        }
    }
}
