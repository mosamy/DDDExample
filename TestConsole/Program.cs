using System;
using CASAContext;
using System.Collections.Generic;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c0 = new Client{ FirstName = "Mohamed0", LastName = "Samy", MiddleName = "R"};
            Client c1 = new Client{ FirstName = "Mohamed1", LastName = "Samy", MiddleName = "R"};
            Client c2 = new Client{ FirstName = "Mohamed2", LastName = "Samy", MiddleName = "R"};
            Client c3 = new Client{ FirstName = "Mohamed3", LastName = "Samy", MiddleName = "R"};
            
            List<DomainObject> lo = new List<DomainObject>();
            lo.Add(c0);
            lo.Add(c1);
            lo.Add(c2);
            lo.Add(c3);
            //string result = c0.ToString();//lo[0].ToString();
            lo.ForEach(a => Console.WriteLine(a.ToString()));
            Console.ReadLine();
        }
    }
}