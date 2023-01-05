using MyManagementApp.Data.Repositories;
using System;
using System.Data;
using MyManagementApp.Domain.Core;
using MyManagementApp.Domain;
using MyManagementApp.Domain.Enums;

namespace MyManagementApp.Application.Services
{
    public class ProductAppService
    {
        #region fields
        private readonly ProductRepository _productRepository;
        #endregion

        #region constructor
        public ProductAppService()
        {
            _productRepository = new ProductRepository();
        }
        #endregion


        #region methods

        public DataTable LoadFromDatabase()
        {
            return _productRepository.LoadFromDatabase();
        }

        public Result NewProduct(string productCode, string productName, string brand, decimal price, ProductStatusEnum productStatus)
        {

            var product = new Product()
            {
                Id = Guid.NewGuid(),
                ProductCode = productCode,
                ProductName = productName,
                Brand = brand,
                Price = price,
                Active = productStatus == ProductStatusEnum.Active

            };

            var r = product.IsValid();
            if (!r.Success)
                return r;

            _productRepository.InsertDatabase(product);

            return Result.Factory.True();
        }

        public Result UpdateProduct(string productCode, string productName, string brand, decimal price, ProductStatusEnum productStatus, Guid id)
        {

            // Read
            var product = _productRepository.GetProductById(id);

            if (product == null)
                return Result.Factory.False("Product not found");

            // Alter
            product.ProductCode = productCode;
            product.ProductName = productName;
            product.Brand = brand;
            product.Price = price;
            product.Active = productStatus == ProductStatusEnum.Active;

            var r = product.IsValid();
            if (!r.Success)
                return r;

            // Persist

            _productRepository.UpdateDatabase(product);

            return Result.Factory.True();

        }
        public Result DeleteProduct(Guid id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                throw new Exception("Product not found");

            _productRepository.DeleteDatabase(product);


            return Result.Factory.True();
        }

        #endregion

    }
}
