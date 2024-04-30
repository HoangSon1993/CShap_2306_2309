using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;

namespace BT_Linq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BookStore bookStore = new BookStore();


            // Cú pháp LinQ To Query
            var result = from book in bookStore.Books
                where book.Price > 50000
                select book;

            // Liệt kê danh sách tất cả các cuốn sách trong cửa hàng, sắp xếp theo giá tiền tăng dần.
            // Nếu giá tiền bằng nhau thì sắp xếp theo số lượng tồn kho giảm dần.

            result = bookStore.Books
                .OrderBy(b => b.Price) // Sắp xếp giá tiền tăng dần
                .ThenByDescending(b => b.Stock); // Sắp xếp số lượng tồn kho gỉam dần

            result = from book in bookStore.Books
                orderby book.Price ascending, book.Stock descending
                select book;

            // Liệt kê danh sách các cuốn sách gần hết hàng (có số lượng tồn kho < 10).
            result = bookStore.Books
                .Where(b => b.Stock <= 10);

            result = from book in bookStore.Books
                where book.Stock <= 10
                select book;

            // Liệt kê danh sách các cuốn sách đã hết hàng.
            result = bookStore.Books
                .Where(b => b.Stock == 0);

            result = from book in bookStore.Books
                where book.Stock == 0
                select book;

            // Liệt kê danh sách các cuốn sách của tác giả Rosie Nguyễn và còn hàng.
            result = bookStore.Books
                .Where(b => b.Author.Contains("Rosie Nguyễn") && b.Stock > 0);

            result = from book in bookStore.Books
                where book.Author.Contains("Rosie Nguyễn") && book.Stock > 0
                select book;

            //Liệt kê top 5 cuốn sách có giá cao nhất.
            result = bookStore.Books
                .OrderByDescending(b => b.Price)
                .Take(5);

            result = (from book in bookStore.Books
                orderby book.Price descending
                select book).Take(5);

            // Liệt kê tất cả cuốn sách có giá cao hơn 50000.
            result = bookStore.Books
                .Where(b => b.Price > 50000);

            result = from book in bookStore.Books
                where book.Price > 50000
                select book;

            //  Tính giá tiền trung bình của 1 cuốn sách.
            var avg = bookStore.Books
                .Average(b=>b.Price);

            avg = (from book in bookStore.Books
                select book.Price).Average();

            Console.WriteLine(avg);
            // Tính tổng tiền hàng còn tồn kho.
            avg = bookStore.Books
                .Sum(b => b.Price * b.Stock);

            avg = (from book in bookStore.Books
                select book.Price * book.Stock).Sum();

            // foreach (var book in result)
            // {
            //     Console.WriteLine(book.ToString());
            // }
        }
    }
}