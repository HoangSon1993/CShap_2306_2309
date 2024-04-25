using System.Collections.Generic;

namespace BT_Linq
{
    public class BookStore
    {
        private List<Book> books { get; set; }

        public BookStore()
        {
            books.Add(new Book() { Id = 1, Sku = "WT3WPG", Name = "Tuổi trẻ đáng giá bao nhiêu", Author = "Rosie Nguyễn", Price = 45000, Stock = 20 });
            books.Add(new Book() { Id = 2, Sku = "98IOWW", Name = "Luyện thi THPT Quốc gia − Hóa học", Author = "Nguyễn Đức Dũng", Price = 51000, Stock = 15 });
            books.Add(new Book() { Id = 3, Sku = "21RH48", Name = "Khéo ăn khéo nói sẽ có được thiên hạ", Author = "Trác Nhã", Price = 59000, Stock = 29 });
            books.Add(new Book() { Id = 4, Sku = "QOXYSD", Name = "Nhà giả kim", Author = "Paulo Coelho", Price = 53000, Stock = 3 });
            books.Add(new Book() { Id = 5, Sku = "6YI6TZ", Name = "Để yên cho bác sĩ 'Hiền'", Author = "BS. Ngô Đức Hùng", Price = 45000, Stock = 36 });
            books.Add(new Book() { Id = 6, Sku = "YHB5JT", Name = "Mình là cá, việc của mình là bơi", Author = "Takeshi Furukawa", Price = 51000, Stock = 9 });
            books.Add(new Book() { Id = 7, Sku = "LXL64L", Name = "Đời ngắn đừng ngủ dài", Author = "Robin Sharma", Price = 42000, Stock = 7 });
            books.Add(new Book() { Id = 8, Sku = "C5V645", Name = "Luyện thi THPT Quốc gia − Toán", Author = "ThS. Đỗ Đường Hiếu", Price = 51000, Stock = 0 });
            books.Add(new Book() { Id = 9, Sku = "4KLYT2", Name = "Cà phê cùng Tony", Author = "Tony Buổi Sáng", Price = 62000, Stock = 18 });
            books.Add(new Book() { Id = 10, Sku = "KBD67V", Name = "Em sẽ đến cùng cơn mưa", Author = "Ichikawa Takuji", Price = 56000, Stock = 64 });
            books.Add(new Book() { Id = 11, Sku = "3RISEF", Name = "Quẳng gánh lo đi mà vui sống", Author = "Dale Carnegie", Price = 45000, Stock = 120 });
            books.Add(new Book() { Id = 12, Sku = "VIAZXR", Name = "Mình nói gì khi nói về hạnh phúc?", Author = "Rosie Nguyễn", Price = 36000, Stock = 0 });
        }
    }
}