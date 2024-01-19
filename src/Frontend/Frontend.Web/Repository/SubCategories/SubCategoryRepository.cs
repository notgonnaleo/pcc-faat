﻿using Backend.Domain.Entities.Categories;
using Backend.Domain.Entities.Products;
using Backend.Domain.Entities.SubCategories;
using Backend.Infrastructure.Enums.Modules;
using Frontend.Web.Models.Route;
using Frontend.Web.Repository.Client;
using System.Net.Http.Json;

namespace Frontend.Web.Repository.SubCategories
{
    public class SubCategoryRepository
    {
        private readonly HttpClientRepository _httpClientRepository;
        public SubCategoryRepository(HttpClientRepository httpClientRepository)
        {
            _httpClientRepository = httpClientRepository;
        }
        public async Task<IEnumerable<SubCategory>> GetSubCategoriesByCategory(string tenantId, string categoryId)
        {
            var parameters = new List<RouteParameterRequest>()
            {
                new RouteParameterRequest()
                {
                    ParameterName = Methods.SubCategories.GetSubCategoriesByCategoryParameters.tenantId,
                    ParameterValue = tenantId,
                },
                new RouteParameterRequest()
                {
                    ParameterName = Methods.SubCategories.GetSubCategoriesByCategoryParameters.categoryId,
                    ParameterValue = categoryId,
                }
            };
            var request = new RouteBuilder<SubCategory>().SendMultiple(Endpoints.SubCategory, Methods.SubCategories.GetSubCategoriesByCategory, parameters);
            return await _httpClientRepository.Get(request);
        }
        public async Task<SubCategory> CreateSubCategory(SubCategory category)
        {
            var model = new RouteBuilder<SubCategory>().Send(Endpoints.SubCategory, Methods.Default.POST, category);
            var response = await _httpClientRepository.Post(model);
            return await response.Content.ReadFromJsonAsync<SubCategory>();
        }
    }
}
