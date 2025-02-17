using System.Collections;

namespace HomeWork_Collections.Task1;

public  class Library
{
    private ArrayList _books;
    public Library()
    {
        _books = new ArrayList();
    }

    public void AddTheBook()
    {

            Book book = new Book();
            bool successfullyAddedBook = false;
            try
            {
                Console.WriteLine("Введите название книги:");
                book.BookName = Console.ReadLine();
                if (string.IsNullOrEmpty(book.BookName) || string.IsNullOrWhiteSpace(book.BookName))
                {
                    throw new WrongBookNameException(book);
                }

                Console.WriteLine("Введите автора:");
                book.AuthorName = Console.ReadLine();
                if (string.IsNullOrEmpty(book.AuthorName) || string.IsNullOrWhiteSpace(book.AuthorName))
                {
                    throw new WrongAuthorException(book);
                }

                Console.WriteLine("Введите год издания (четырехзначное число):");
                book.ProdYear = int.Parse(Console.ReadLine());
                successfullyAddedBook = true;
            }
            catch (WrongBookNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongAuthorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод года издания. Попробуйте снова");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                if (successfullyAddedBook)
                {
            Console.WriteLine("========= Успешное добавление! ==========");
            Console.WriteLine($"Книга: '{book.BookName}'\nАвтор: {book.AuthorName}\nГод издания: {book.ProdYear}\n");
            _books.Add(book);
                }
            }

    }
            public void ShowAllBooks()
            {
                foreach (Book book in _books)
                {
                    Console.WriteLine($"Книга: '{book.BookName}' Автор: {book.AuthorName} Год издания: {book.ProdYear}");
                }
            }
            

}