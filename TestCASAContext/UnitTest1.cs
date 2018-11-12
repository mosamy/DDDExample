using System;
using Xunit;
using CASAContext;
using System.Collections.Generic;

namespace TestCASAContext
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
            string result = lo[0].ToString();
            Assert.Equal("CASAContext.Client I am a client Object my name is Mohamed0 R Samy", result );
        }
    }
}