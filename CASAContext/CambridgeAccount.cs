using System;
using System.Collections.Generic;

namespace CASAContext
{
    public class CambridgeAccount : Account, IObserver<DomainObject>
    {

        //public Client client { get; set; }
        public  Suitability suitability { get; set; }
        //public  Adviser adviser { get; set; }
        private List<CustodialAccount> _accounts = new List<CustodialAccount>();

        public void AddCustAccount(CustodialAccount a)
        {
            _accounts.Add(a);
            a.Subscribe(this);
        }

        public CambridgeAccount(Client c, Adviser a)
        {
            this.PrimaryClient = c;
            suitability = c.Suitablity;
            this.PrimaryAdviser = a;
            this.Identfier = int.Parse(c.Identfier.ToString() + suitability.Identfier.ToString() +
                                       a.Identfier.ToString());
            this.PrimaryClient.Subscribe(this);
            suitability.Subscribe(this);
            this.PrimaryAdviser.Subscribe(this);

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