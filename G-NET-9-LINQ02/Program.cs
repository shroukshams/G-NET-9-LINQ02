using LINQ.DataSources;
using LINQ.Helpers;
using LINQ.Models;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Numerics;
using System.Xml.Linq;
using static LINQ.DataSources.Source;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1. Get top 3 most expensive products
            ////var result = ProductList.OrderByDescending(P => P.UnitPrice).Take(3);
            #endregion
            #region Q2 show page 2 of products, with page size = 5
            //// var result = ProductList.Skip(5).Take(5);
            #endregion
            #region Q3 Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //// var result =ProductList.OrderBy(P =>P.UnitPrice).TakeWhile(P=>P.UnitPrice<25);
            #endregion
            #region Q4  Check if ALL products in the "Seafood" category are in stock
            ////var result = ProductList.Where(P => P.Category == "Seafood").All(P => P.UnitsInStock > 0);
            ////Console.WriteLine(result);
            #endregion
            #region Q5 5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion
            #region Q6 Group all products by Category and print each group with its  product count.
            //var result = ProductList.GroupBy(P => P.Category)
            //    .Select(g => new { Category = g.Key, Count = g.Count() });
            #endregion
            #region  Q7. Group products by Category and project only product names per group

            //        var result = ProductList.GroupBy(P => P.Category)
            //.SelectMany(g => g.Select(p => new { Category = g.Key, ProductName = p.ProductName }));


            #endregion
            #region Q8 Find all categories that have MORE THAN 3 products
            //var result = ProductList.GroupBy(P => P.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            #endregion
            #region Q9 9. Using QUERY SYNTAX, group customers by Country, and for each  group select { Country, Count, TotalOrderValue }.
            //var result = from  c in CustomerList
            //             group c by c.Country into g
            //             select new 
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            #endregion
            #region  10 10. Calculate the total number of units in stock across all products
            //var result = ProductList.Sum(P => P.UnitsInStock);
            //Console.WriteLine(result);

            #endregion
            #region  Q11 Find the CHEAPEST and MOST EXPENSIVE product prices
            //var minPrice = ProductList.Min(P => P.UnitPrice);
            //var maxPrice = ProductList.Max(P => P.UnitPrice);
            //Console.WriteLine($"Cheapest: {minPrice}, Most Expensive: {maxPrice}");
            #endregion
            #region  Q12 Get a distinct list of all product categories
            //var result = ProductList.Select(P => P.Category).Distinct();
            #endregion
            # region Q13 find product IDs that are in setA but NOT in setB
            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);

            #endregion
            #region 14. Find countries that appear in list1 but NOT in list2    (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region Q15 Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //var productDict = ProductList.ToDictionary(p => p.ProductID);
            //if (productDict.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine($"Product found: {product.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            #endregion
            #region  Q16 Get the first product whose price is greater than $50.
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 50);
            //if (result != null)
            //{
            //    Console.WriteLine($"First product over $50: {result.ProductName} at ${result.UnitPrice}");
            //}

            #endregion
            #region Q17 Try to get the first product with a price > $500. it returns null   instead of throwing.
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 500);
            //if (result != null)
            //{
            //    Console.WriteLine($"First product over $500: {result.ProductName} at ${result.UnitPrice}");
            //}

            #endregion
            #region Q18 Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}");

            #endregion
            #region Q19 Generate even numbers between 1 and 30.
            //var result = Enumerable.Range(1, 30).Where(i => i % 2 == 0);

            #endregion
            #region Q20 Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var result = ProductList.Select(p => p.ProductName).Take(3)
            //    .Concat(CustomerList.Select(c => c.CompanyName).Take(3));

            #endregion
            #region Q21 Pair each product with a customer (by position) and produce  a string "ProductName sold to CompanyName".
            //var result = ProductList.Zip(CustomerList, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            #endregion


            // For Print
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
