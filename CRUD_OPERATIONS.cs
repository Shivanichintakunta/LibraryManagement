using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CRUD_OPERATIONS
    {
        //Inserting Data
        public static void Insert_Author()
        {
            Console.Write("Author Name: ");
            string? name = Console.ReadLine();

            Console.Write("Author Email ID: ");
            string? email = Console.ReadLine();
            //Create new Authors
            using (var context = new LMContext())
            {
                var auth = new Author()
                {
                    Name = name,
                    Email = email,
                };
                context.Authors.Add(auth);
                context.SaveChanges();
                Console.WriteLine("Author Data Inserted");
            }
        }
        //Adding books to authors
        public static void Insert_Book()
        {
            Console.Write("Book Title: ");
            string? title = (Console.ReadLine());

            Console.Write("Year Published: ");
            int pub_year = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Author Id: ");
            var authorId = Convert.ToInt32(Console.ReadLine());
         
            using (var context=new LMContext()) {
            var book = new Book()
            {
                Title = title,
                YearPublished = pub_year,
                AuthorId = authorId

            };
                context.Books.Add(book);
                context.SaveChanges();
                Console.WriteLine("Book added.");
        }

    }
        //To retrieve data(Listing All Books with Authors)
        public static void getdata()
        {
            using (var context = new LMContext())
            {
                var book = context.Books.Include(b => b.Author).ToList();
                foreach (var b in book)
                {
                    Console.WriteLine($"{b.BookId}: {b.Title} ({b.YearPublished}) by {b.Author.Name}");
                   
                }
            }
        }

        //To Update Data(Update a book's title)
        public static void updatedata()
        {
            Console.WriteLine("Enter the Id to change the Title: ");
                int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the New Title Name ");
            string? title = (Console.ReadLine());
            using (var context = new LMContext())
            {
                var books = context.Books.FirstOrDefault(b => b.BookId == id);
                if (books != null)
                {
                    books.Title = title;
                    context.SaveChanges();
                    Console.WriteLine("Updated Successfully");

                }
                
            }

        }

        //To Delete the Data
        public static void DeleteData()
        {
            Console.WriteLine("Enter book ID to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            using (var context = new LMContext())
            {
                var books = context.Books.FirstOrDefault(b => b.BookId == id);
                if (books != null)
                {
                    context.Books.Remove(books);
                    context.SaveChanges();
                    Console.WriteLine("Deleted Successfully");
                }
                Console.WriteLine("Book Not Found");
            }

        }
    }
    }

