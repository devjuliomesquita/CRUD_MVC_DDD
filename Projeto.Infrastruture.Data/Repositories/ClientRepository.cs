using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces;
using Projeto.Infrastruture.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infrastruture.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(ProjetoContext context) : base(context)
        {
        }
    }
}
