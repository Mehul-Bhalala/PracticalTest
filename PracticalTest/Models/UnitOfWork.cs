using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalTest.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataAccess _DataAccessContext;
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Service> _serviceRepository;
        public UnitOfWork(DataAccess dataAccessContext)
        {
            _DataAccessContext = dataAccessContext;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                return _userRepository = _userRepository ?? new GenericRepository<User>();
            }
        }

        public IGenericRepository<Service> ServiceRepository
        {
            get
            {
                return _serviceRepository = _serviceRepository ?? new GenericRepository<Service>(_DataAccessContext);
            }
        }

        public void Save()
        {
            _DataAccessContext.SaveChanges();
        }
    }
}
