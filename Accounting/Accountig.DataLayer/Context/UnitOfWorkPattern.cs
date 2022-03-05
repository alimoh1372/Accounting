using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountig.DataLayer.Repositories;
using Accountig.DataLayer.Services;


namespace Accountig.DataLayer.Context
{
    public class UnitOfWorkPattern : IDisposable
    {
        private Accountig_DBEntities db=new Accountig_DBEntities();

        private ICustomerRepository _customRepository;

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
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
