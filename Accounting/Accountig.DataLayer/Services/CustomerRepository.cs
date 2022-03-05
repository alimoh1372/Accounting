using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountig.DataLayer.Repositories;
using System.Data.Entity;

namespace Accountig.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accountig_DBEntities db;
        public CustomerRepository(Accountig_DBEntities contex)
        {
            db =contex;
        }
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                Customers customerTodelete= GetCustomerById(customerId);
                DeleteCustomer(customerTodelete);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public IEnumerable<Customers> GetCustomerByFilter(string filterText)
        {
            return db.Customers.Where(p => p.FullName.Contains(filterText) || p.Email.Contains(filterText) || p.Mobile.Contains(filterText)).ToList();

        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
