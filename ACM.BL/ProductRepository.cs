﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product= new Product(productId);
            if (productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Some description";
                product.CurrentPrice = 15.76M;
            }
            object myObj= new object();
            return product;
        }
    }
}
