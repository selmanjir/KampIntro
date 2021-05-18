using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Pratice_3
{
    class ProductManager
    {
        public void Add(Product product ,IDiscountManager discount)
        {
           
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);

            discount.Calculate();
        }
        public void Add1(Product product)
        {
            Console.WriteLine("Ürün Eklendi : " + product.ProductName);
        }
        public void Add2(List<Product> products,List<IDiscountManager>discounts)
        {
            foreach (var product in products)
            {
                Add1(product);
            }

            foreach (var discount in discounts)
            {
                discount.Calculate();
            }

        }
    }
}
