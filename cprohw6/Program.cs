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


Dictionary<string,int> ContactList = new();

int FindContact(string contactName)
{
    int Value = 0;
    bool success = ContactList.TryGetValue(contactName, out Value);
    return Value;
}

void AddContact(string contactName,int Number)
{
   ContactList.Add(contactName,Number);
}

bool RemoveContact(string contactName, CallbackEventHandler Callback = null)
{
    int Value;
    bool success = ContactList.TryGetValue(contactName,out Value);

    if (success)
    {
        Callback(contactName, Value);
        ContactList.Remove(contactName);
    }
    return success;
}

void OnRemovedContact(string contactName, int Number)
{
    Console.WriteLine("{0} removed from the list", contactName);
}

AddContact("petya", 123412344);
Console.WriteLine(FindContact("petya"));
PrintDict(ContactList);
RemoveContact("petya",new CallbackEventHandler(OnRemovedContact));
Console.WriteLine(FindContact("petya"));

//----------------------------------------------------------------------------------------------------
Console.WriteLine();

List<string> Students = new List<string>();

string FindStudent(string studentName)
{
    string origName = string.Empty;
    bool success = false;

    foreach (string student in Students)
    {
        bool contains = student.ToLower().Contains(studentName.ToLower());  
        if (contains)
        {
            origName = student;
            success = true;
        }
    }
    return origName;
}

void AddStudent(string studentName)
{
    Students.Add(studentName);
}

bool RemoveStudent(string contactName)
{
    string Student = FindStudent(contactName);
    if (Student != string.Empty)
        Students.Remove(Student);
    
    return Student != string.Empty;
}


AddStudent("Petya");

PrintList(Students);
Console.WriteLine();
Console.WriteLine(RemoveStudent("Pet"));
Console.WriteLine();
PrintList(Students);

//----------------------------------------------------------------------------------------------------
Console.WriteLine();

Queue<string> Queue = new Queue<string>();

void AddBuyer(string buyerName)
{
    Queue.Enqueue(buyerName);
}

void CheckCurentBuyer()
{
    string B;
    var Success = Queue.TryPeek(out B);
    if (Success)
        Console.WriteLine("{0} now on checkout, {1} more people behind!",B,Queue.Count-1);
}

void Checkout()
{
    string B = Queue.Dequeue();
    Console.WriteLine("{0} was served", B);
    CheckCurentBuyer();
}

AddBuyer("Petya");
AddBuyer("Vasya");
AddBuyer("Ivan");

CheckCurentBuyer();

Checkout();
Checkout();
Checkout();

//----------------------------------------------------------------------------------------------------
Console.WriteLine();

Hashtable BookStorage = new Hashtable();

int AddBook(string bookName)
{
    int key = BookStorage.Count;
    BookStorage.Add(key, bookName);
    return key;
}

void RemoveBook(int bookId)
{
    if (BookStorage.ContainsKey(bookId))
        BookStorage.Remove(bookId);
}

void ViewBooks()
{
    foreach (DictionaryEntry s in BookStorage)
    {
        Console.WriteLine("{0} : id:{1}",s.Value,s.Key);
    }
}

string findBook(int bookId)
{
    if (BookStorage.ContainsKey(bookId))
        return (string)BookStorage[bookId];
    return "book not found";
}

var key1 = AddBook("book1");
var key2 = AddBook("book2");
var key3 = AddBook("book3");
var key4 = AddBook("book4");
var key5 = AddBook("book5");

RemoveBook(key5);
ViewBooks();

Console.WriteLine();
Console.WriteLine(findBook(1));
Console.WriteLine(findBook(5));