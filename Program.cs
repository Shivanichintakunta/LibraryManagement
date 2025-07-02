// See https://aka.ms/new-console-template for more information
using LibraryManagement;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");

while (true)
{
    Console.WriteLine("Choose the Option to perform operation:");
    Console.WriteLine(" 1.Create new authors \n 2.Add books to authors \n 3.List all books with authors \n 4.Update a book's title \n 5.Delete a book");

    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:CRUD_OPERATIONS.Insert_Author();
            break;
        case 2:CRUD_OPERATIONS.Insert_Book();
            break;
        case 3:
            CRUD_OPERATIONS.getdata();
            break;
        case 4:CRUD_OPERATIONS.updatedata();
            break;
        case 5:CRUD_OPERATIONS.DeleteData();
            break;
        default:
            return;
            


    }
}
