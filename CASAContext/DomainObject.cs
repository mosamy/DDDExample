using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace CASAContext
{
    public class DomainObject : IObservable<DomainObject>, IDisposable
    {
        public  int Identfier { get; set; }
        private ObjectStatus _status;
        public ObjectStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                //this.Status = value;
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

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}