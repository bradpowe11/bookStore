using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Author = "";
            _Title = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle(string title)
        {
            return _Title;
        }
        public string GetAuthor(string author)
        {
            return _Author;
        }
        public void SetId(int id)
        {
            _Id = id;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book member30 = new book();
            member30.SetId(10);
            member30.SetTitle("In God We Trust");
            member30.SetAuthor("Jean Shepherd");
            Console.WriteLine($"ID = {member30.GetId()}, Title = {member30.GetTitle(" ")}, Name = {member30.GetAuthor(" ")}");

            book member20 = new book();
            Console.WriteLine("Please enter the book ID: ");
            member20.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the Title: ");
            member20.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the Author: ");
            member20.SetAuthor(Console.ReadLine());

            book member10 = new book(10, "Harry Potter", "J.K. Rowling");
            Console.WriteLine($"ID = {member10.GetId()}, Title = {member10.GetTitle(" ")}, Name = {member10.GetAuthor(" ")}");

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the Author: ");
            string tempAuthor = Console.ReadLine();
            book member40 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(member10);
            displayBooks(member20);
            displayBooks(member30);
            displayBooks(member40);
        }
        static void displayBooks(book member)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"ID: {member.GetId()}");
            Console.WriteLine($"Title: {member.GetTitle(" ")}");
            Console.WriteLine($"Author: {member.GetTitle(" ")}");

        }
    }
}