using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entities
{
    public class Client
    {
        public Client(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;

            CreatedAt = DateTime.Now;
            Active = true;
            Products = new List<Product>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual List<Product> Products { get; set; }

        public bool EspecialClient(Client client)
        {
            return
                client.Active && DateTime.Now.Year - client.CreatedAt.Year >= 5;
        }
    }
}
