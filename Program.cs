namespace G_NET_7_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var products = ListGenerator.ProductList;
            //var customers = ListGenerator.CustomerList;
            #region Q1
            //var q1 = products.OrderByDescending(p => p.UnitPrice).Take(3);
            #endregion

            #region Q2
            //var q2 = products.Skip(5).Take(5);
            #endregion

            #region Q3
            //var q3 = products.OrderBy(p => p.UnitPrice)
            //                 .TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Q4
            //var q4 = products.Where(p => p.Category == "Seafood")
            //                .All(p => p.UnitsInStock > 0);
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };
            //var q5 = ids.Contains(9);
            #endregion

            #region Q6
            //var q6 = products.GroupBy(p => p.Category)
            //                .Select(g => new
            //                {
            //                    Category = g.Key,
            //                    Count = g.Count()
            //                });
            #endregion

            #region Q7
            //var q7 = products.GroupBy(p => p.Category)
            //                 .Select(g => new
            //                 {
            //                     Category = g.Key,
            //                     Names = g.Select(p => p.ProductName)
            //                 });
            #endregion

            #region Q8
            //var q8 = products.GroupBy(p => p.Category)
            //                  .Where(g => g.Count() > 3)
            //                  .Select(g => g.Key);
            #endregion

            #region Q9
            //var q9 = from c in customers
            //         group c by c.Country into g
            //         select new
            //         {
            //             Country = g.Key,
            //             Count = g.Count(),
            //             TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //         };

            #endregion

            #region Q10
            //var q10 = products.Sum(p => p.UnitsInStock);

            #endregion

            #region Q11
            //var q11Min = products.Min(p => p.UnitPrice);
            //var q11Max = products.Max(p => p.UnitPrice);
            #endregion

            #region Q12
            //var q12 = products.Select(p => p.Category).Distinct();
            #endregion

            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var q13 = setA.Except(setB);
            #endregion

            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var q14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Q15
            //var dict = products.ToDictionary(p => p.ProductID);
            //var q15 = dict[18];
            #endregion

            #region Q16
            //var q16 = products.First(p => p.UnitPrice > 50);
            #endregion

            #region Q17
            //var q17 = products.FirstOrDefault(p => p.UnitPrice > 500);
            #endregion

            #region Q18
            //var q18 = Enumerable.Range(1, 10)
            //                   .Select(x => $"7 x {x} = {7 * x}");
            #endregion

            #region Q19
            //var q19 = Enumerable.Range(1, 30)
            //                     .Where(x => x % 2 == 0);

            #endregion

            #region Q20
            //var q20 = products.Select(p => p.ProductName).Take(3)
            //         .Concat(customers.Select(c => c.CompanyName).Take(3));


            #endregion

            #region Q21
            //var q21 = products.Zip(customers,
            //        (p, c) => $"{p.ProductName} sold to {c.CompanyName}");


            #endregion
        }
    }
}
