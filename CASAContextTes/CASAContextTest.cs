using System.Collections.Generic;
using System.Linq;
using CASAContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CASAContextTes
{
    [TestClass]
    public class CASAContextTest
    {

        public List<Client> Clients = new List<Client>();
        public List<CustodialAccount> CustodialAccounts = new  List<CustodialAccount>();
        public  List<Asset> Assets = new List<Asset>();
        public List<Suitability> Suitabilities = new  List<Suitability>();
        public  List<Adviser> Advisers = new List<Adviser>();


        public void LoadClients()
        {
            Client c0 = new Client{ FirstName = "Mohamed0", LastName = "Samy", MiddleName = "R"};
            Client c1 = new Client{ FirstName = "Mohamed1", LastName = "Samy", MiddleName = "R"};
            Client c2 = new Client{ FirstName = "Mohamed2", LastName = "Samy", MiddleName = "R"};
            Client c3 = new Client{ FirstName = "Mohamed3", LastName = "Samy", MiddleName = "R"};
            Client c4 = new Client{ FirstName = "Mohamed4", LastName = "Samy", MiddleName = "R"};
            Client c5 = new Client{ FirstName = "Mohamed5", LastName = "Samy", MiddleName = "R"};
            
            Clients.Add(c0);
            Clients.Add(c1);
            Clients.Add(c2);
            Clients.Add(c3);
            Clients.Add(c4);
            Clients.Add(c5);
        }

        public void LoadAssets()
        {
            Asset a0 = new Asset{Identfier = 0, AssetName = "IRA", Value = 100};
            Asset a1 = new Asset{Identfier = 1, AssetName = "Stock", Value = 200};
            Asset a2 = new Asset{Identfier = 2, AssetName = "Bonds", Value = 300};
            Asset a3 = new Asset{Identfier = 3, AssetName = "Cash", Value = 400};
            Asset a4 = new Asset{Identfier = 4, AssetName = "IRA", Value = 500};
            Asset a5 = new Asset{Identfier = 5, AssetName = "Stock", Value = 600};//2100
            Asset a6 = new Asset{Identfier = 6, AssetName = "Bonds", Value = 700};//2800
            Asset a7 = new Asset{Identfier = 7, AssetName = "Cash", Value = 800};//3600
            Asset a8 = new Asset{Identfier = 8, AssetName = "IRA", Value = 1000};//4600
            Asset a9 = new Asset{Identfier = 9, AssetName = "Stock", Value = 900};//5500
            Asset a10 = new Asset{Identfier = 10, AssetName = "Bonds", Value = 400};//5900
            Asset a11 = new Asset{Identfier = 11, AssetName = "Cash", Value = 200};//6100
            Asset a12= new Asset{Identfier = 12, AssetName = "IRA", Value = 100};//6200
            Asset a13 = new Asset{Identfier = 13, AssetName = "Stock", Value = 100};//6300
            Asset a14 = new Asset{Identfier = 14, AssetName = "Bonds", Value = 3000};//9300
            Asset a15 = new Asset{Identfier = 15, AssetName = "Cash", Value = 4000};//13300
            Assets.Add(a0);
            Assets.Add(a1);
            Assets.Add(a2);
            Assets.Add(a3);
            Assets.Add(a4);
            Assets.Add(a5);
            Assets.Add(a6);
            Assets.Add(a7);
            Assets.Add(a8);
            Assets.Add(a9);
            Assets.Add(a10);
            Assets.Add(a11);
            Assets.Add(a12);
            Assets.Add(a13);
            Assets.Add(a14);
            Assets.Add(a15);
        }

        public void LoadAdvisers()
        {
            Adviser A0 = new Adviser{Identfier = 0, AdviserCode = "769", FirstName = "Robert", MiddleName = "", LastName = "Puglise"};
            Adviser A1 = new Adviser{Identfier = 1, AdviserCode = "123", FirstName = "Mohamed", MiddleName = "", LastName = "Samy"};
            Adviser A2 = new Adviser{Identfier = 2, AdviserCode = "7692", FirstName = "Monte", MiddleName = "", LastName = "Python"};
            Adviser A3 = new Adviser{Identfier = 3, AdviserCode = "7693", FirstName = "Bat", MiddleName = "", LastName = "Man"};
            Adviser A4 = new Adviser{Identfier = 4, AdviserCode = "7694", FirstName = "Robin", MiddleName = "", LastName = "Batman"};
            Advisers.Add(A0);
            Advisers.Add(A1);
            Advisers.Add(A2);
            Advisers.Add(A3);
            Advisers.Add(A4);
        }

        public void LoadSuitabilities()
        {
            Suitability s0 = new Suitability{Identfier = 0, InvestmentObjective = " Aggressive Growth" , RiskTolerance = "High", Description = "Aggressive growth with high risk"};
            Suitability s1 = new Suitability{Identfier = 1, InvestmentObjective = " Stable income" , RiskTolerance = "Low", Description = "Low growth in favour of stability"};
            Suitability s2 = new Suitability{Identfier = 2, InvestmentObjective = " Moderate Growth" , RiskTolerance = "Meduim", Description = "Meduim growth with Meduim risk"};
            Suitabilities.Add(s0);
            Suitabilities.Add(s1);
            Suitabilities.Add(s2);
            Clients[0].Suitablity = s0;
            Clients[1].Suitablity = s1;
            Clients[2].Suitablity = s2;
            Clients[3].Suitablity = s1;
            Clients[4].Suitablity = s0;
            Clients[5].Suitablity = s2;
            
        }

        public void loadCustAccounts()
        {
            //Client, Adviser
            CustodialAccount CA0 = new CustodialAccount{Identfier = 0, PrimaryClient = Clients[0], PrimaryAdviser = Advisers[0], Custodian = "FCCS"};//CASA1
            CustodialAccount CA1 = new CustodialAccount{Identfier = 1, PrimaryClient = Clients[1], PrimaryAdviser = Advisers[1], Custodian = "FCCS"};//Casa2
            CustodialAccount CA2 = new CustodialAccount{Identfier = 2, PrimaryClient = Clients[2], PrimaryAdviser = Advisers[2], Custodian = "FCCS"};//Casa3
            CustodialAccount CA3 = new CustodialAccount{Identfier = 3, PrimaryClient = Clients[5], PrimaryAdviser = Advisers[3], Custodian = "FCCS"};//Casa4
            CustodialAccount CA4 = new CustodialAccount{Identfier = 4, PrimaryClient = Clients[4], PrimaryAdviser = Advisers[4], Custodian = "FCCS"};//Casa5
            CustodialAccount CA5 = new CustodialAccount{Identfier = 5, PrimaryClient = Clients[5], PrimaryAdviser = Advisers[3], Custodian = "FCCS"};//
            CustodialAccount CA6 = new CustodialAccount{Identfier = 6, PrimaryClient = Clients[2], PrimaryAdviser = Advisers[4], Custodian = "FCCS"};//Casa6
            CustodialAccount CA7 = new CustodialAccount{Identfier = 7, PrimaryClient = Clients[3], PrimaryAdviser = Advisers[3], Custodian = "FCCS"};//CASA7
            CustodialAccount CA8 = new CustodialAccount{Identfier = 8, PrimaryClient = Clients[3], PrimaryAdviser = Advisers[3], Custodian = "FCCS"};//
            CustodialAccount CA9 = new CustodialAccount{Identfier = 9, PrimaryClient = Clients[0], PrimaryAdviser = Advisers[0], Custodian = "FCCS"};//
            // add assets
            
            Assets.ForEach(a => CA0.AddAsset(a));
            Assets.FindAll(a=> a.Identfier > 0).ForEach(b=> CA1.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 3).ForEach(b=> CA2.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 4).ForEach(b=> CA3.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 5).ForEach(b=> CA4.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 8).ForEach(b=> CA5.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 2).ForEach(b=> CA6.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 6).ForEach(b=> CA7.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 1).ForEach(b=> CA8.AddAsset(b));
            Assets.FindAll(a=> a.Identfier > 0).ForEach(b=> CA9.AddAsset(b));
            
            CustodialAccounts.Add(CA0);
            CustodialAccounts.Add(CA1);
            CustodialAccounts.Add(CA2);
            CustodialAccounts.Add(CA3);
            CustodialAccounts.Add(CA4);
            CustodialAccounts.Add(CA5);
            CustodialAccounts.Add(CA6);
            CustodialAccounts.Add(CA7);
            CustodialAccounts.Add(CA8);
            CustodialAccounts.Add(CA9);
           
        }
        
        [TestInitialize]
        public void LoadTestData()
        {
           
            LoadClients();
            LoadAssets();
            LoadAdvisers();
            LoadSuitabilities();
            loadCustAccounts();
        }
        
        public  CASAContextTest()
        {
            //LoadTestData();
        }
        
        [TestMethod]
        public void TestClientTostring()
        {
            Client c0 = new Client{ FirstName = "Mohamed0", LastName = "Samy", MiddleName = "R"};
            Client c1 = new Client{ FirstName = "Mohamed1", LastName = "Samy", MiddleName = "R"};
            Client c2 = new Client{ FirstName = "Mohamed2", LastName = "Samy", MiddleName = "R"};
            Client c3 = new Client{ FirstName = "Mohamed3", LastName = "Samy", MiddleName = "R"};
            
            List<DomainObject> lo = new List<DomainObject>();
            lo.Add(c0);
            
            string result = lo[0].ToString();
            Assert.AreEqual("CASAContext.Client I am a client Object my name is Mohamed0 R Samy", result );

        }

        [TestMethod]
        public void TestCASAManagerAddCustAccount()
        {
            
            CASAManager cm = new CASAManager(CustodialAccounts);

            List<CambridgeAccount> ca = cm.getCambridgeAccounts();
            
            Assert.AreEqual(7,ca.Count);
            Assert.AreEqual(13300, ca[0].TotalValue() );

        }
    }
}