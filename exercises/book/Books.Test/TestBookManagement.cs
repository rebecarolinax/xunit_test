using book_management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Test
{
    public class TestBookManagement
    {
        [Fact]
        public void ManagementTest()
        {
            var manegement = new BookManagement();
            var book = new Book("Coraline");

            manegement.BookAdd(book);

            var allBooks = manegement.GetAllBooks();
            Assert.Contains(book, allBooks);
        }
    }
}
