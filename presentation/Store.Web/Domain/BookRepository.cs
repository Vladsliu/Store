﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.Новая_папка
{
    internal class BookRepository : IBookRepository
    {

        private readonly Book[] books = new[]
        {
            new Book (1, "ISBN 12312-31231", "D. Knuth", "Art Of Programming"),
            new Book (2, "ISBN 12312-31232", "M. Fowler", "Refactoring"),
            new Book (3, "ISBN 12312-31232", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray(); 
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }
    }
}