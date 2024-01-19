﻿using Backend.Domain.Entities.Categories;
using Frontend.Web.Repository.Categories;

namespace Frontend.Web.Services.Categories
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> GetCategories(string tenantId)
        {
            return await _categoryRepository.GetCategories(tenantId);
        }
        public async Task<IEnumerable<Category>> GetCategoriesAndSubCategories(string tenantId)
        {
            return await _categoryRepository.GetCategoriesAndSubCategories(tenantId);
        }
        public async Task<Category> CreateCategory(Category category)
        {
            return await _categoryRepository.CreateCategory(category);
        }
    }
}