using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Exercise1
{
    public class Reader
    {
        private static int readerIDCounter = 9999;
        private int readerID;
        private string readerName;
        private string readerAddr;
        private string readerType;
        // Constructor
        public Reader(string name, string addr, string type)
        {
            readerID = ++readerIDCounter;
            readerName = name;
            readerAddr = addr;
            readerType = type;
        }
        // getter
        public int GetID()
        {
            return readerID;
        }
        // setter
        public void SetName(string name)
        {
            readerName = name;
        }
        public void SetAddr(string addr)
        {
            readerAddr = addr;
        }
        public void SetType(string type)
        {
            readerType = type;
        }

        public void Input()
        {
            Console.WriteLine("\nEnter Name of Reader: ");
            SetName(Console.ReadLine());
            Console.WriteLine("Enter Addrees of Reader: ");
            SetAddr(Console.ReadLine());
            Console.WriteLine("Enter Type of Reader: ");
            SetType(Console.ReadLine());
        }

        public void Ouput()
        {
            Console.WriteLine("ID: {0} \tName: {1} \tAddr: {2} \tType: {3}", readerID, readerName, readerAddr, readerType);
        }
    }

    public class Book
    {
        private static int bookIDCounter = 9999;
        private int bookID;
        private string bookName;
        private string bookAuthor;
        private string bookMajor;
        private int publishingYear; // nam xuat ban
        // Constructor
        public Book(string name, string author, string major, int year)
        {
            bookID = ++bookIDCounter;
            bookName = name;
            bookAuthor = author;
            bookMajor = major;
            publishingYear = year;
        }
        // getter
        public int GetID()
        {
            return bookID;
        }
        // setter
        public void SetName(string name)
        {
            bookName = name;
        }
        public void SetAuhtor(string author)
        {
            bookAuthor = author;
        }
        public void SetMajor(string major)
        {
            bookMajor = major;
        }
        public void SetYear(int year)
        {
            publishingYear = year;
        }
        // Input, Output
        public void Input()
        {
            Console.WriteLine("\nEnter Name of Book: ");
            SetName(Console.ReadLine());
            Console.WriteLine("Enter Author of Book: ");
            SetAuhtor(Console.ReadLine());
            Console.WriteLine("Enter Major of Book: ");
            SetMajor(Console.ReadLine());
            Console.WriteLine("Enter Publishing Year: ");
            SetYear(Convert.ToInt32(Console.ReadLine()));
        }

        public void Output()
        {
            Console.WriteLine("ID: {0} \tName: {1} \tAuthor: {2} \tMajor: {3} \tYear: {4}", bookID, bookName, bookAuthor, bookMajor, publishingYear);
        }
    }

    public class BookBorrowingManager
    {
        private List<Book> listBorrowedBook;
        private Reader reader;
        // Constructor
        public BookBorrowingManager(Reader reader)
        {
            this.reader = reader;
            listBorrowedBook = new List<Book>();
        }
        // getter
        public List<Book> GetListBook()
        {
            return listBorrowedBook;
        }

        public Reader GetReader()
        {
            return reader;
        }
        public void Input(List<Book> listBook, int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool checkExist = false;
                Console.WriteLine("Enter the Book ID you want to borrow: ");
                int idBook = Convert.ToInt32(Console.ReadLine());
                if (idBook >= 10000)
                {
                    int countBook = 0;
                    foreach (var book in listBook)
                    {
                        if (idBook == book.GetID())
                        {
                            checkExist = true;
                            foreach (var borrowedBook in listBorrowedBook)
                            {
                                if (idBook == borrowedBook.GetID())
                                {
                                    countBook++;
                                }
                            }
                            if (countBook < 3)
                            {
                                listBorrowedBook.Add(book);
                            }
                            else
                            {
                                Console.WriteLine("Exceeding 3 books/titles. Enter Other Book ID: ");
                                --i;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ID Book Is Invalid. Enter other Book ID: ");
                    --i;
                }

                if (checkExist == false)
                {
                    Console.WriteLine("ID Book Is Invalid. Enter other Book ID: ");
                    --i;
                }
            }
        }

        public void Output()
        {
            reader.Ouput();
            Console.WriteLine("List Borrowed Books: ");
            int size = listBorrowedBook.Count;
            for (int i = 0; i < size; i++)
            {
                bool checkExist = false;
                for (int j = i + 1; j < size; j++)
                {
                    if (listBorrowedBook[i].GetID() == listBorrowedBook[j].GetID())
                    {
                        checkExist = true;
                        break;
                    }
                }
                if (!checkExist)
                {
                    listBorrowedBook[i].Output();
                }
            }
        }

        public int CountBook()
        {
            return listBorrowedBook.Count();
        }
    }
    internal class Ex1
    {
        public static void SortManagement(List<BookBorrowingManager> listManagers)
        {
            var listSize = listManagers.Count;
            for (int i = 0; i < listSize - 1; i++)
            {
                var max = i;
                for (int j = i + 1; j < listSize; j++)
                {
                    if (listManagers[j].CountBook() > listManagers[max].CountBook())
                    {
                        max = j;
                    }
                }

                if (max != i)
                {
                    BookBorrowingManager temp = listManagers[i];
                    listManagers[i] = listManagers[max];
                    listManagers[max] = temp;

                }
            }
        }
        public static void Main(string[] args)
        {
            List<Reader> listReader = new List<Reader>();
            List<Book> listBook = new List<Book>();
            List<BookBorrowingManager> listManagers = new List<BookBorrowingManager>();
            
            // Input
            Console.WriteLine("Enter the number of Book: ");
            int numberBook = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i  < numberBook; i++)
            {
                Book temp = new Book("name","author","major",2000);
                temp.Input();
                listBook.Add(temp);
            }
            Console.WriteLine("Enter the number of Reader: ");
            int numberReader = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberReader; i++)
            {
                Reader temp = new Reader("name", "addr", "type");
                temp.Input();
                listReader.Add(temp);
            }
            
            // Output
            Console.WriteLine("\nInformation of books in Library: ");
            foreach (var temp in listBook)
            {
                temp.Output();
            }
            Console.WriteLine("\nInformation of readers: ");
            foreach (var reader in listReader)
            {
                reader.Ouput();
            }
            Console.WriteLine("\nEnter Management information");
            foreach (var reader in listReader)
            {
                int number;
                do
                {
                    Console.WriteLine("\nEnter the number of books you want to borrow: (<= 5)");
                    number = Convert.ToInt32(Console.ReadLine());
                } while (number > 5);
                BookBorrowingManager temp = new BookBorrowingManager(reader);
                temp.Input(listBook, number);
                listManagers.Add(temp);
            }

            // Sort List Management By The Number Borrowed Books
            SortManagement(listManagers);
            Console.WriteLine("\nDisplay Management Information: ");
            foreach (var borrowingManager in listManagers)
            {
                borrowingManager.Output();
                Console.WriteLine("\n");
            }
        }
    }
}
