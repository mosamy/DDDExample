using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;

namespace CASAContext
{
    public class CASAManager : IObserver<DomainObject>
    {
        private List<CustodialAccount> CustAccounts;
        private List<Client> Clients;
        private List<Suitability> Suitabilities;
        private List<Adviser> Advisers;
        private List<CambridgeAccount> CaAccounts;
        private List<string> log = new List<string>();
        public CASAManager( List<CustodialAccount> custAccounts)
        {
            CustAccounts = custAccounts;
            Clients = CustAccounts.SelectMany(a => a.getClients()).Distinct().ToList();
            Suitabilities = Clients.Select(c => c.Suitablity).Distinct().ToList();
            Advisers = CustAccounts.Select(c => c.PrimaryAdviser).Distinct().ToList();
            CustodialAccount acc = new CustodialAccount();

            CaAccounts = CustAccounts.GroupBy(c => new {c.PrimaryClient, c.PrimaryAdviser, c.PrimaryClient.Suitablity})
                //.Select(a=> a.ToList().ForEach())    

                .Select(a => 
                {
                    CambridgeAccount ca = new CambridgeAccount(a.Key.PrimaryClient, a.Key.PrimaryAdviser);
                    a.ToList().ForEach(account => ca.AddCustAccount(account));
                    return ca;
                }).ToList();
            
       



            //.Select(ca => CustAccounts.FindAll(cua => cua.PrimaryClient ==  ca.PrimaryClient && cua.PrimaryAdviser == ca.PrimaryAdviser ).ForEach(resacc => ca.AddCustAccount(resacc)))).getCambridgeAccounts();

            //.Select(new CambridgeAccount(CAAcct.PrilmaryClient, CAAcct.PrimaryAdviser)).ToList();
        }

        public List<CambridgeAccount> getCambridgeAccounts()
        {
            return CaAccounts;
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(DomainObject value)
        {
            log.Add("Object ID :" + value.Identfier + " Changed to:" + value.ToString() );
        }

        public List<string> getLog()
        {
            return log;
        }
    }
}