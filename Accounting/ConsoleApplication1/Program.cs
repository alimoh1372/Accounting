using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountig.DataLayer;
using Accountig.DataLayer.Services;
using Accountig.DataLayer.Repositories;

using Accountig.DataLayer.Context;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////******use Context without Dependency injection and unitOfWork Pattern ****


            //List<Customers> customerList = customerRepository.GetAllCustomers();

            //Customers customer = new Customers()
            //{
            //    FullName = "علی محمدزاده",
            //    Mobile="09383738757",
            //    CustomerImage="NoPhoto"
            //};

            //customerRepository.InsertCustomer(customer);
            //customerRepository.Save();

            //   //*****use contex with dependency injection (Constructor dependency injection)*****
            //Accountig_DBEntities db = new Accountig_DBEntities();
            //ICustomerRepository customerRepository = new CustomerRepository(db);


            //Customers customer = new Customers()
            //{
            //    FullName = "علی محمدزاده",
            //    Mobile = "09383738757",
            //    CustomerImage = "NoPhoto"
            //};

            //customerRepository.InsertCustomer(customer);
            //customerRepository.Save();

            // Use Unit Of Work Pattern Instance

            UnitOfWorkPattern db = new UnitOfWorkPattern();

             List<Customers> customers= db.customRepository.GetAllCustomers();

            db.Dispose();

            List<Customers> csts = db.customRepository.GetAllCustomers();





          }
    }
}
