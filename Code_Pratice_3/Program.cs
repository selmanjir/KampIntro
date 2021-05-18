using System;
using System.Collections.Generic;

namespace Code_Pratice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product() { Id = 1, CategoryId = 1, ProductName = "Kulaklık", UnitPrice = 80, UnitsInStock = 8 };
            Product product2 = new Product() { Id = 2, CategoryId = 2, ProductName = "ssd", UnitPrice = 500, UnitsInStock = 56 };
            Product product3 = new Product() { Id = 3, CategoryId = 1, ProductName = "Bluetooth Kulaklık", UnitPrice = 180, UnitsInStock = 32 };

            IDiscountManager endOfSeasonSaleManager = new EndOfSeasonSaleManager();
            IDiscountManager getTwoPayOneDiscount = new GetTwoPayOneDiscount();
            IDiscountManager fiftyPercentDiscountWithTheCard = new FiftyPercentDiscountWithTheCard ();

            List<Product> products = new List<Product> { product1, product2};
            List<IDiscountManager> discounts = new List<IDiscountManager> {getTwoPayOneDiscount , fiftyPercentDiscountWithTheCard };

            ProductManager productManager = new ProductManager();
            productManager.Add(product3,endOfSeasonSaleManager);
            //Çoklu..
            productManager.Add2(products,discounts);
        }
    }
}
