﻿using System;
using Storee;
using System.Linq;
namespace StoreMemory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new Book[]
        {
            new Book(1, "Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
