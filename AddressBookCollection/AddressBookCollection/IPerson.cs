﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollection
{
    interface  IPerson
    {
        void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber);
        void EditContact(string name);
    }
}
