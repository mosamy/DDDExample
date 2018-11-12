using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;

namespace CASAContext
{
    public  class Account : DomainObject
    {
        private Client _primaryClient;
        public Adviser PrimaryAdviser { get; set; }
        
        public Client PrimaryClient
        {
            get { return _primaryClient; }
            set
            {
                _primaryClient = value;
                Clients.Add(_primaryClient);
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

        public void AddAsset(Asset a)
        {
            if (!Assets.Contains(a)){
                Assets.Add(a);
            }
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