


using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace Assignment_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //1. Find all products that are out of stock.
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var unit in result)
            //    Console.WriteLine(unit);

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ListGenerator.ProductsList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3.00m);
            //foreach (var unit in result)
            //    Console.WriteLine(unit);

            //3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortNamedDigitsLinq = Arr.Where((n, index) => n.Length < index);

            //foreach (var n in shortNamedDigitsLinq)
            //    Console.WriteLine(n);

            #endregion


            #region Element Operators
            //1. Get first Product out of Stock 
            //var result=ListGenerator.ProductsList.FirstOrDefault(p=>p.UnitsInStock==0);
            //    Console.WriteLine(result);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000m);
            //Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var num=Arr.Where(n=>n>5)
            //            .Skip(1)
            //            .FirstOrDefault();
            //Console.WriteLine(num);

            #endregion

            #region Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Count(n=>n%2!=0);
            //Console.WriteLine(result);

            //2. Return a list of customers and how many orders each has.
            //var result = ListGenerator.CustomersList.Select(c => new { CustomerName= c.CustomerName,NumberofOrders= c.Orders.Count() });
            //foreach (var item in result)
            //    Console.WriteLine(item);

            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Sum();
            //Console.WriteLine(result);

            //5. Get the total number of characters of all words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //string[] dict = File.ReadAllLines("dictionary_english.txt");
            //int count = 0;
            //foreach (string line in dict) 
            //{
            //    int cline=line.Count();
            //    count += cline;
            //}
            //Console.WriteLine(count);//3494688

            //6. Get the length of the shortest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //string[] dict = File.ReadAllLines("dictionary_english.txt");
            //var result = dict.Min(d => d.Length);
            //Console.WriteLine(result);

            //7. Get the length of the longest word in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //string[] dict = File.ReadAllLines("dictionary_english.txt");
            //var result = dict.Max(d => d.Length);
            //Console.WriteLine(result);

            //8. Get the average length of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First).
            //string[] dict = File.ReadAllLines("dictionary_english.txt");
            //var result = dict.Average(d => d.Length);
            //Console.WriteLine(result);
            #endregion

            #region Ordering Operators
            //1. Sort a list of products by name
            //var result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);
            //foreach (var item in result) 
            //    Console.WriteLine (item);

            //3. Sort a list of products by units in stock from highest to lowest.
            //var result = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var unit in result)
            //    Console.WriteLine(unit);

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.OrderBy(n => n.Length)
            //                .ThenBy(n=>n);

            //foreach (string str in result)
            //    Console.WriteLine(str);

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ListGenerator.ProductsList.OrderByDescending(p => p.Category)
            //                                      .ThenByDescending(p => p.UnitPrice);
            //foreach (var product in result)
            //    Console.WriteLine(product);

            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result=Arr.OrderByDescending(w=>w.Length)
            //               .ThenByDescending(w=>w,StringComparer.OrdinalIgnoreCase);

            //foreach (var s in result)
            //    Console.WriteLine(s);


            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(w=> w[1] == 'i')
            //                .Reverse()
            //                .ToArray();

            //foreach (string s in result) 
            //        Console.WriteLine(s);

            #endregion

            #region Transformation Operators

            //1. Return a sequence of just the names of a list of products

            //var result = from p in ListGenerator.ProductsList
            //             select p.ProductName;



            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = from p in words
            //             select new
            //             {
            //                 uppercase = p.ToUpper(),
            //                 lowercase = p.ToLower(),
            //             };

            //foreach (var word in result)
            //    Console.WriteLine(word);



            //3. Produce a sequence containing some properties of Products,
            //including UnitPrice which is renamed to Price in the resulting type.
            //var result = from p in ListGenerator.ProductsList
            //             select new
            //             {
            //                 name = p.ProductName,
            //                 price = p.UnitPrice
            //    };



            // 4.Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((n, i) =>  n == i  ).ToArray();

            //for (int i = 0; i < Arr.Length; i++)
            //    Console.WriteLine($"{Arr[i]} : {result[i]}");


            //5. Returns all pairs of numbers from both arrays
            //such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from A in numbersA
            //             from B in numbersB
            //             where A < B
            //             select new { A = A, B = B };

            //foreach (var x in result) Console.WriteLine(x);


            //6. Select all orders where the order total is less than 500.00.
            //var result = from c in ListGenerator.CustomersList
            //             from o in c.Orders
            //             where o.Total < 500.00m
            //             select o;
            //foreach (var x in result) Console.WriteLine(x);


            //7. Select all orders where the order was made in 1998 or later.
            //var result = from c in ListGenerator.CustomersList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1998
            //             select o;
            //foreach (var x in result) Console.WriteLine(x);
            #endregion
        }
    }
}
