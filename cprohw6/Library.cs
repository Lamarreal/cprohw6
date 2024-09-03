using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cprohw6
{
    static class Library
    {
        public static Hashtable BookStorage = new Hashtable();

        public static int AddBook(string bookName)
        {
            int key = BookStorage.Count;
            BookStorage.Add(key, bookName);
            return key;
        }

        public static void RemoveBook(int bookId)
        {
            if (BookStorage.ContainsKey(bookId))
                BookStorage.Remove(bookId);
        }

        public static void ViewBooks()
        {
            foreach (DictionaryEntry s in BookStorage)
            {
                Console.WriteLine("{0} : id:{1}", s.Value, s.Key);
            }
        }

        public static string findBook(int bookId)
        {
            if (BookStorage.ContainsKey(bookId))
                return (string)BookStorage[bookId];
            return "book not found";
        }

    }
}
