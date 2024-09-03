using cprohw6;
using System.Collections;

void PrintList<T>(List<T> list)
{
    if (list.Count > 0)
    {
        foreach (T item in list)
        {
            Console.WriteLine(item?.ToString());
        }
    }
    else
        Console.WriteLine("List is Empty");
}

void PrintDict<T,T2>(Dictionary<T, T2> list)
{
    if (list.Count > 0)
    {
        foreach (KeyValuePair<T, T2> entry in list)
        {
            Console.WriteLine("{0} : {1}",entry.Key,entry.Value);
        }
    }
    else
        Console.WriteLine("List is Empty");
}
void OnRemovedContact(string contactName, int Number)
{
    Console.WriteLine("{0} removed from the list", contactName);
}

Contact.AddContact("petya", 123412344);
Console.WriteLine(Contact.FindContact("petya"));
PrintDict(Contact.ContactList);
Contact.RemoveContact("petya",new CallbackEventHandler(OnRemovedContact));
Console.WriteLine(Contact.FindContact("petya"));

//----------------------------------------------------------------------------------------------------
Console.WriteLine();

Students.AddStudent("Petya");

PrintList(Students.students);
Console.WriteLine();
Console.WriteLine(Students.RemoveStudent("Pet"));
Console.WriteLine();
PrintList(Students.students);

//----------------------------------------------------------------------------------------------------
Console.WriteLine();

Shop.AddBuyer("Petya");
Shop.AddBuyer("Vasya");
Shop.AddBuyer("Ivan");

Shop.CheckCurentBuyer();

Shop.Checkout();
Shop.Checkout();
Shop.Checkout();

//----------------------------------------------------------------------------------------------------
Console.WriteLine();


var key1 = Library.AddBook("book1");
var key2 = Library.AddBook("book2");
var key3 = Library.AddBook("book3");
var key4 = Library.AddBook("book4");
var key5 = Library.AddBook("book5");

Library.RemoveBook(key5);
Library.ViewBooks();

Console.WriteLine();
Console.WriteLine(Library.findBook(1));
Console.WriteLine(Library.findBook(5));