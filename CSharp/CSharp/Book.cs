using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Book : Product
    {
        public string authorName;
        public int pageCount;
        public float discountPercent = 5;

        public void GetInfo()
        {
            Console.WriteLine("AuthorName: " + authorName);
            Console.WriteLine("pageCount: " + pageCount);
            Console.WriteLine("discountPercent: " + discountPercent);

        }

        public void GetDiscountedPrice()
        {
            float endirimliQiymet = saledPrice - (saledPrice * discountPercent) / 100;
            Console.WriteLine("Endirimli qiymet: " + endirimliQiymet);
        }

    }
}
