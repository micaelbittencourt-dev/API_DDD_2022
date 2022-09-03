using Domain.Interfaces;
using Entities.Entities;
using Infrastruture.Configuration;
using Infrastruture.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruture.Repository.Repositories
{
    public class RepositoryMessage : RepositoryGenerics<Message>, IMessage
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositoryMessage()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
