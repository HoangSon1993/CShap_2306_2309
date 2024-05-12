using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_exception.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestPhepChia2So()
        {
            // Arrange - Định cấu trúc
            // bằng cách khởi tạo các giá trị đầu vào và giá trị mong đợi cho kết quả trả về.
            
            // Giá trị đầu vào
            int a = 10;
            int b = 2;
            
            // Mong đợi kết quả trả về
            double expected = 5;

            // Act - Hành động
            // Gọi phương thức PhepChia2So với các giá trị đầu vo được chuẩn bị ở phần Arrange.
            double result;
            Program.PhepChia2So(a, b, out result);

            // Assert - Khẳng định
            // Kiểm tra kết quả của Action được được thực hiện có khớp với giá trị mong đợi hay không.
            // Sử dụng Assert.AreEqual để so sánh kết quả trả về từ phương thức "Chia2So"
            Assert.AreEqual(expected, result);
            
            // Nếu giá trị trả về khớp với giá trị mong đợi, unit test sẽ được coi là thành công.
        }

        [TestMethod]
        public void TestPhepChia2So_ChiaChoKhong()
        {
            // Arrange
            int a = 10;
            int b = 0;
            double result;

            // cú pháp sort hand
            // // Act & Assert
            // Assert.ThrowsException<DivideByZeroException>(() => Program.PhepChia2So(a, b, out _));
            
            // cú pháp long hand
            // Act
            Action act = () => Program.PhepChia2So(a, b, out result);
            
            // Assert
            Assert.ThrowsException<DivideByZeroException>(act);
        }

        [TestMethod]
        public void TestNhap_A()
        {
            // Arrange
            string input = "10";
            int expected = 10;
            
            // Act
            using (var consoleInput = new ConsoleInput(input))
            {
                Program.nhap_A(out int result);
                
                // Assert
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void TestNhap_A_SaiDinhDang()
        {
            // Arrange
            string input = "abc";
            
            // Act & Assert
            using (var consoleInput = new ConsoleInput(input))
            {
                Assert.ThrowsException<FormatException>(() => Program.nhap_A(out int result));
            }
        }

        [TestMethod]
        public void TestNhap_B()
        {
            // Arrange
            string input = "5";
            int expected = 5;
            
            // Act
            using (var cosoleInput = new ConsoleInput(input))
            {
                Program.nhap_B(out int result);
                
                // Assert
                Assert.AreEqual(expected,result);
            }
        }
        
        [TestMethod]
        public void TestNhap_B_SaiDinhDang()
        {
            // Arrange
            string input = "xyz";

            // Act & Assert
            using (var consoleInput = new ConsoleInput(input))
            {
                Assert.ThrowsException<FormatException>(() => Program.nhap_B(out int result));
            }
        }
    }

    public class ConsoleInput : IDisposable
    {
        private readonly System.IO.TextReader originalInput;
        private readonly System.IO.TextWriter originalOutput;
        private readonly System.IO.StringReader stringReader;
        private readonly System.IO.StringWriter stringWriter;
        
        public ConsoleInput(string input)
        {
            originalInput = Console.In;
            originalOutput = Console.Out;
            stringReader = new System.IO.StringReader(input);
            stringWriter = new System.IO.StringWriter();
            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);
        }
        
        public void Dispose()
        {
            stringReader.Dispose();
            stringWriter.Dispose();
            Console.SetIn(originalInput);
            Console.SetOut(originalOutput);
        }
    }
}