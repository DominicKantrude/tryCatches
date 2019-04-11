using System;
using System.Collections.Generic;

namespace tryCatches
{

    class AddressBook
    {
        // Dictionary<string, string> stocks = new Dictionary<string, string>();
        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();



        public void AddContact(Contact contact)
        {

            try
            {
                contacts.Add(contact.Email, contact);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Contact GetByEmail(string email)
        {
            return contacts[email];
        }
    }
}