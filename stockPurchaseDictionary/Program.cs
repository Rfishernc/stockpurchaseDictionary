using System;
using System.Collections.Generic;

namespace stockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("ABC", "ABCompany");
            stocks.Add("DEF", "Mos Def Inc.");
            stocks.Add("GHI", "Something that begins with Ghi Inc.");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));
            purchases.Add((ticker: "ABC", shares: 10, price: 50.00));
            purchases.Add((ticker: "DEF", shares: 100, price: 42.42));
            purchases.Add((ticker: "GHI", shares: 75, price: 29.25));
            purchases.Add((ticker: "GHI", shares: 80, price: 32.32));
            purchases.Add((ticker: "ABC", shares: 400, price: 39.39));

            Dictionary<string, double> companyValue = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
               if (companyValue.ContainsKey(stocks[purchase.ticker]))
                {
                    companyValue[stocks[purchase.ticker]] += purchase.shares * purchase.price;
                } else
                {
                    companyValue.Add(stocks[purchase.ticker], purchase.shares * purchase.price);
                }
            }

            foreach (KeyValuePair<string, double> company in companyValue)
            {
                Console.WriteLine($"{company.Key}: {company.Value}");
            }

            Console.ReadLine();
        }
    }
}
