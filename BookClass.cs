using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class BookItem
    {
        // Encapsulation: private fields
        private string bookName;
        private string author;
        private string publisher;
        private decimal price;
        private int quantity;

        // Encapsulation: public properties for access to private fields
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }

}
