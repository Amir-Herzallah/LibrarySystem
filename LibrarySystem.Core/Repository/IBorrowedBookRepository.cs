﻿using LibrarySystem.Core.Data;
using LibrarySystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Repository
{
    public interface IBorrowedBookRepository
    {
        List<Borrowedbook> GetAllBorrowedBooks();
        void CreateBorrowedBook(Borrowedbook borrowedBook);
        void DeleteBorrowedBook(int id);
        public void UpdateBorrowedBook(Borrowedbook borrowedBook);
        Borrowedbook GetBorrowedBookById(int id);
        List<BorrowedBooksDetails> GetBorrowedBooksDetails();
        List<GetBorrowedBooksDetailsByUserIdDTO> BorrowedbooksByIdUser(int id);
        GetBorrowedBooksDetailsByUserIdDTO GetBorrowedBooksDetailsByUserIdAndBookID(int userID, int bookID);
    }
}
