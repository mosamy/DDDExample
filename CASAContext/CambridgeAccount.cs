using System;
using System.Collections.Generic;

namespace CASAContext
{
    public class CambridgeAccount : Account, IObserver<DomainObject>
    {

        public Client client { get; set; }
        public  Suitability suitability { get; set; }
        public  Adviser adviser { get; set; }
        private List<CustodialAccount> _accounts;

        public void AddCustAccount(CustodialAccount a)
        {
            _accounts.Add(a);
            a.Subscribe(this);
        }

        public CambridgeAccount(Client c, Adviser a)
        {
            client = c;
            suitability = c.Suitablity;
            adviser = a;
            this.Identfier = int.Parse(client.Identfier.ToString() + suitability.Identfier.ToString() +
                                       adviser.Identfier.ToString());
            client.Subscribe(this);
            suitability.Subscribe(this);
            adviser.Subscribe(this);

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
            Status = ObjectStatus.Updated;
        }
    }
}