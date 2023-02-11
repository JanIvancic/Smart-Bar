﻿using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new ProductRepository().GetProducts();
        }

        public void CreateProduct(Product product)
        {
            new ProductRepository().CreateProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            new ProductRepository().UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            new ProductRepository().DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return new ProductRepository().GetProductById(id);
        }


        public bool ValidateData(Product product)
        {
            double test1;
            int test2, test3, test4;
            try
            {
                if (!string.IsNullOrEmpty(product.Name)
                                && double.TryParse(product.Price.ToString(), out test1)
                                && int.TryParse(product.Amount.ToString(), out test2)
                                && int.TryParse(product.Minimum.ToString(), out test3)
                                && int.TryParse(product.Optimal.ToString(), out test4)
                                && !string.IsNullOrEmpty(product.MeasurementUnit)
                                )// za pravi string bit ce true
                {
                    return true;
                }
                else//za validaciju netocno unesenih
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }



        }

    }
}
