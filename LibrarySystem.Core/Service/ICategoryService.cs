﻿using LibrarySystem.Core.Data;
using LibrarySystem.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Service
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        void UpdateCategory(int id, Category category);
        void DeleteCategory(int id);
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        List<Category> GetCategoriesByLibraryId(int id);
        List<Book> GetBooksByCategoryId(int id);
        List<CategoryLibrary> GetAllCategoryLibraries();
    }
}
