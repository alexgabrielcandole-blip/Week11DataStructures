
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Week11DataStructures
{
    // Stores one product's information
    public class ProductInfo
    {
        public string Name { get; }
        public decimal Price { get; }

        public ProductInfo(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    // Custom collection based on DictionaryBase
    public class ProductCatalog : DictionaryBase
    {
        // =====================================
        // VALIDATE PRODUCT CODE
        // =====================================
        public static bool IsValidProductCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return false;
            }

            code = code.Trim().ToUpperInvariant();

            // Format: PRD-001, PRD-002, etc.
            return Regex.IsMatch(code, @"^PRD-[0-9]{3}$");
        }

        // =====================================
        // CUSTOM DICTIONARY VALIDATION
        // =====================================
        protected override void OnValidate(
            object key, object value)
        {
            if (key is not string code ||
                !IsValidProductCode(code) ||
                code != code.Trim().ToUpperInvariant())
            {
                throw new ArgumentException(
                    "Invalid product code. Use PRD-001 format.");
            }

            if (value is not ProductInfo product)
            {
                throw new ArgumentException(
                    "Invalid product information.");
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ArgumentException(
                    "Product name cannot be empty.");
            }

            if (product.Price < 0)
            {
                throw new ArgumentException(
                    "Product price cannot be negative.");
            }

            if (decimal.Round(product.Price, 2)
                != product.Price)
            {
                throw new ArgumentException(
                    "Price must have at most two decimal places.");
            }

            base.OnValidate(key, value);
        }

        // =====================================
        // ADD PRODUCT
        // =====================================
        public bool AddProduct(
            string code, string name, decimal price)
        {
            code = code.Trim().ToUpperInvariant();
            name = name.Trim();

            if (!IsValidProductCode(code) ||
                name == "" ||
                price < 0 ||
                decimal.Round(price, 2) != price)
            {
                return false;
            }

            // Prevent duplicate product codes
            if (Dictionary.Contains(code))
            {
                return false;
            }

            ProductInfo product =
                new ProductInfo(name, price);

            Dictionary.Add(code, product);

            return true;
        }

        // =====================================
        // SEARCH PRODUCT
        // =====================================
        public bool SearchProduct(
            string code, out ProductInfo? product)
        {
            code = code.Trim().ToUpperInvariant();

            product = null;

            if (Dictionary.Contains(code))
            {
                product = (ProductInfo)Dictionary[code]!;
                return true;
            }

            return false;
        }

        // =====================================
        // REMOVE PRODUCT
        // =====================================
        public bool RemoveProduct(string code)
        {
            code = code.Trim().ToUpperInvariant();

            if (!Dictionary.Contains(code))
            {
                return false;
            }

            Dictionary.Remove(code);

            return true;
        }

        // =====================================
        // GET ALL PRODUCT RECORDS
        // =====================================
        public DictionaryEntry[] GetProducts()
        {
            DictionaryEntry[] products =
                new DictionaryEntry[Count];

            int index = 0;

            foreach (DictionaryEntry entry in Dictionary)
            {
                products[index] = entry;
                index++;
            }

            return products;
        }

        // =====================================
        // GET TOTAL PRODUCTS
        // =====================================
        public int GetProductCount()
        {
            return Count;
        }
    }
}
