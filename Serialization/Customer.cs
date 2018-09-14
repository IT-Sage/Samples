using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    [DataContract]
    class Customer
    {
        [DataMember]
        private List<Invoice> invoices;
        [DataMember]
        public int Age { get; private set; }

        public Customer()
        {
            invoices = new List<Invoice>();
            Age = 25;
            for (int i = 0; i < 5; i++)
            {
                invoices.Add(new Invoice(5, 258.60 * i));
            }
        }

    }
}
