using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entities
{
    public class Product
    {
        public Product(string productName, string description, decimal productValue, int clientId)
        {
            ProductName = productName;
            Description = description;
            ProductValue = productValue;
            ClientId = clientId;

            Available = true;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal ProductValue { get; set; }
        public int ClientId { get; set; }
        public bool Available { get; set; }
        public virtual Client Client { get; set; }
    }
}
