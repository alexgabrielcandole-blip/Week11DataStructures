
using System;
using System.Collections.Generic;

namespace Week11DataStructures
{
    public class ProductPairManager
    {
        // Stores product ID and name pairs
        private List<KeyValuePair<int, string>> products =
            new List<KeyValuePair<int, string>>();

        // =====================================
        // ADD PRODUCT PAIR
        // =====================================
        public bool AddProduct(int id, string name)
        {
            name = name.Trim();

            // Validate ID and name
            if (id <= 0 || name == "")
            {
                return false;
            }

            // Prevent duplicate product IDs
            foreach (KeyValuePair<int, string> product
                in products)
            {
                if (product.Key == id)
                {
                    return false;
                }
            }

            // Create a new KeyValuePair
            KeyValuePair<int, string> newProduct =
                new KeyValuePair<int, string>(id, name);

            products.Add(newProduct);

            return true;
        }

        // =====================================
        // SEARCH PRODUCT
        // =====================================
        public bool SearchProduct(
            int id, out KeyValuePair<int, string> foundProduct)
        {
            foreach (KeyValuePair<int, string> product
                in products)
            {
                if (product.Key == id)
                {
                    foundProduct = product;
                    return true;
                }
            }

            foundProduct = default;
            return false;
        }

        // =====================================
        // REMOVE PRODUCT PAIR
        // =====================================
        public bool RemoveProduct(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Key == id)
                {
                    products.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        // =====================================
        // GET ALL PRODUCT PAIRS
        // =====================================
        public List<KeyValuePair<int, string>> GetProducts()
        {
            return new List<KeyValuePair<int, string>>(
                products);
        }

        // =====================================
        // GET TOTAL PRODUCT PAIRS
        // =====================================
        public int GetProductCount()
        {
            return products.Count;
        }
    }
}
