﻿using LibrarySystem.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Service
{
    public interface IBorrowedBookService
    {
        List<Borrowedbook> GetAllBorrowedBooks();
        void CreateBorrowedBook(Borrowedbook borrowedBook);
        void DeleteBorrowedBook(int id);
        public void UpdateBorrowedBook(Borrowedbook borrowedBook);
        Borrowedbook GetBorrowedBookById(int id);
    }
}