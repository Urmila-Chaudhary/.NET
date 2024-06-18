using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Books
    {
        private string title;
        private string author;

        public Books(string title, string author) 
        {
            this.title = title;
            this.author = author;
        }

        public void PrintDetails() 
        {
            Console.WriteLine("Book Title : " + title + "\nAuthor : " + author);
        }
    }

    public partial class Books
    {
        private int bookNo;
        private string publisher;

        public Books(int bookNo, string publisher)
        {
            this.bookNo = bookNo;
            this.publisher = publisher;
        }
        public void PrintPubDetails()
        {
            Console.WriteLine("Book No : " + bookNo + "\nPublisher: " + publisher);
        }
    }
}
