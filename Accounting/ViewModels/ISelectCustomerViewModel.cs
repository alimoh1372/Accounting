using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountig.ViewModels
{
    public interface ISelectCustomerViewModel
    {
        int CustomerID { get; set; }
        string FuLLName { get; set; }
    }
}
