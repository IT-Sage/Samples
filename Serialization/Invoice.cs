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
    class Invoice
    {
        [DataMember]
        private int pages;
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public double Price { get; private set; }
        public Invoice(int pages,double price)
        {
            this.pages = pages;
            ID = Guid.NewGuid();
            Price = price;
        }
    }
}
