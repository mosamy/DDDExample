using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace CASAContext
{
    public class DomainObject : IObservable<DomainObject>
    {
        public  int Identfier { get; set; }
        public ObjectStatus Status
        {
            get { return this.Status;}
            set
            {
                this.Status = value;
                myobservers.ForEach( o=> o.OnNext(this));
            }
        }
        public List<IObserver<DomainObject>> myobservers= new List<IObserver<DomainObject>>() ;
        public DomainObject()
        {
            Status  = ObjectStatus.Existing;
        }

        public IDisposable Subscribe(IObserver<DomainObject> observer)
        {
            myobservers.Add(observer);
            return this;
        }
    }
}