﻿using WebAppNetCore6.Data;
using WebAppNetCore6.Models;

namespace WebAppNetCore6.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBookAsync(int id);
        public Task<int> AddBookAsync(BookModel model);
        public Task UpdateBookAsync(int id, BookModel model);
        public Task DeleteBookAsync(int id);
    }
}
