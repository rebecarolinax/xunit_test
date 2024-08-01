namespace book_management
{
    public class BookManagement
    {
        private List<Book> _bookList;

        public BookManagement()
        {
            _bookList = new List<Book>();
        }

        public void BookAdd(Book book)
        {
            _bookList.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return _bookList;
        }
    }
}
