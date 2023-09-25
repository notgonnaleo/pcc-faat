﻿using Backend.Domain.Entities.Authentication.Tenants;
using Backend.Domain.Entities.Authentication.Users.UserContext;
using Backend.Domain.Entities.Products;
using Backend.Infrastructure.Context;
using Backend.Infrastructure.Services.Authentication;
using Backend.Infrastructure.Services.Authorization;
using Backend.Infrastructure.Services.Tenants;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Services.Products
{
    public class ProductService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService (AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<Product>> Get(Guid tenantId)
        {
            try
            {
                return _appDbContext.Products
                    .Where(x => x.TenantId == tenantId && x.Active == true)
                    .ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Product> GetById(Guid tenantId, Guid productId)
        {
            try
            {
                return _appDbContext.Products
                    .Where(x => x.TenantId == tenantId && x.Id == productId && x.Active == true)
                    .First();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Product> Add(Product product)
        {
            try
            {
                product.Id = Guid.NewGuid();
                product.Created = DateTime.Now;
                product.CreatedBy = product.CreatedBy;
                product.Updated = null;
                product.UpdatedBy = null;

                _appDbContext.Products.Add(product);
                _appDbContext.SaveChanges();

                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Update(Product product)
        {
            try
            {
                product = new Product() // Updating the header info from the product.
                {
                    Id = product.Id,
                    Name = product.Name,
                    SKU = product.SKU,
                    Description = product.Description,
                    Updated = DateTime.Now,
                    UpdatedBy = Guid.NewGuid() // TODO: Get it from the user account id while it's log in.
                };
                _appDbContext.Update(product);
                var response = _appDbContext.SaveChanges();

                if (response <= 0)
                    throw new Exception("Failed while trying to update the item.");

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                Product product = _appDbContext.Products.Where(x => x.Id == Id).First();
                product.Active = false;

                _appDbContext.Update(product);
                var response = _appDbContext.SaveChanges();

                if (response <= 0)
                    throw new Exception("Failed while trying to delete the item.");

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}