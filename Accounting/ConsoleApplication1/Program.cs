using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accountig.DataLayer;
using Accountig.DataLayer.Services;
using Accountig.DataLayer.Repositories;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////******use Context without Dependency injection and unitOfWork Pattern ****

            //ICustomerRepository customerRepository = new CustomerRepository();
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
            //List<Customers> customerList = customerRepository.GetAllCustomers();
            




        }
    }
}
