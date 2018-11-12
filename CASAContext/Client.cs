using System;

namespace CASAContext
{
    public class Client :DomainObject
    {
        
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String PreferredName { get; set; }
        public String Address { get; set; }
        public Suitability Suitablity { get; set; }

        public override string ToString()
        {
            string ret = base.ToString();
            ret = ret + " I am a client Object my name is " + FirstName + " " + MiddleName + " " + LastName;
            return ret;
        }

        public Client()
        {
            
        }
    }
}