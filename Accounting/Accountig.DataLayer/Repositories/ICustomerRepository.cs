﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountig.DataLayer.Repositories
{
    public interface ICustomerRepository
    {

        List<Customers> GetAllCustomers();
        Customers GetCustomerById(int customerId);
        IEnumerable<Customers> GetCustomerByFilter(string filterText);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);

        bool DeleteCustomer(int customerId);
        void Save();
    }
}