using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;

namespace CASAContext
{
    public  class Account : DomainObject
    {
        public Adviser PrimaryAdviser { get; set; }
        
        public Client PrimaryClient
        {
            get { return this.PrimaryClient; }
            set
            {
                this.PrimaryClient = value;
                Clients.Add(this.PrimaryClient);
            } 
        }
        private List<Client> Clients = new List<Client>();
        private List<Asset> Assets = new List<Asset>();


        public List<Client> getClients()
        {
            return Clients;
        }

        public Client getClient(int identifier)
        {
            var clt = Clients.Find(c => c.Identfier == identifier);
           // Client c = from clt in Clients where clt.Identifier = identifier sele
            return clt;
        }

        public List<Asset> getAssets()
        {
            return Assets;
        }

        public decimal TotalValue()
        {
            decimal total = Assets.Sum(a => a.Value);
            return total;
        }
        
    }

   
}