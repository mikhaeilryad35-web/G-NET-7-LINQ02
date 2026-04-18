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

        }
    }
}
