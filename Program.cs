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

        }
    }
}
