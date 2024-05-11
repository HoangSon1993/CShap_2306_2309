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
            // Arrange
            int a = 10;
            int b = 2;
            double expected = 5;

            // Act
            double result;
            Program.PhepChia2So(a, b, out result);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestPhepChia2So_ChiaChoKhong()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => Program.PhepChia2So(a, b, out _));
        }

        [TestMethod]
        public void TestNhap_A()
        {
            // Arrange
            string input = "1";
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