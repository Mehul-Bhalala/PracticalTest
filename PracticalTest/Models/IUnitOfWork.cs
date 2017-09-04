using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public interface IUnitOfWork
    {

        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Service> ServiceRepository { get; }
        void Save();
    }
}
