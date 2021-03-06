using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Context;


namespace Accounting.DataLayer.Context
{
    public class UnitOfWorkPattern : IDisposable
    {
        private Accountig_DBEntities db=new Accountig_DBEntities();

        private ICustomerRepository _customRepository;
        private GenricRepository<Accounting> _accountigRepository;
        private GenricRepository<Login> _loginRepository;

        public ICustomerRepository customRepository
        {
            get
            {
                if (_customRepository==null)
                {
                    _customRepository = new CustomerRepository(db);
                }
                return _customRepository; 
            }
            
        }

        public GenricRepository<Accounting> AccountigRepository
        {
            get
            {
                if (_accountigRepository==null)
                {
                    _accountigRepository = new GenricRepository<Accounting>(db);
                    return _accountigRepository;
                }
                return _accountigRepository;
            }
        }
       public GenricRepository<Login> LoginRepository
        {
            get
            {
                if (_loginRepository==null)
                {
                    _loginRepository = new GenricRepository<Login>(db);
                    return _loginRepository;
                }
                return _loginRepository;
            }
        }
        public int Save()
        {
          return  db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
