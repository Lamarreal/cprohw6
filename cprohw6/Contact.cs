using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw6
{
    static class Contact
    {
        public static Dictionary<string, int> ContactList = new();

        public static int FindContact(string contactName)
        {
            int Value = 0;
            bool success = ContactList.TryGetValue(contactName, out Value);
            return Value;
        }

        public static void AddContact(string contactName, int Number)
        {
            ContactList.Add(contactName, Number);
        }

        public static bool RemoveContact(string contactName, CallbackEventHandler Callback = null)
        {
            int Value;
            bool success = ContactList.TryGetValue(contactName, out Value);

            if (success)
            {
                Callback(contactName, Value);
                ContactList.Remove(contactName);
            }
            return success;
        }

    }
}
