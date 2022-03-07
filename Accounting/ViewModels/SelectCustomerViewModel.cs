using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SelectCustomerViewModel : ISelectCustomerViewModel
    {
        private int _customerId { get; set; }
        private string _fullName { get; set; }
        public int CustomerID
        {
            get
            {
                if (_customerId == null)
                {
                    _customerId = 0;
                }
                return _customerId;
            }

            set
            {
                _customerId = value;
            }
        }

        public string FuLLName
        {
            get
            {
                if (_fullName==null)
                {
                    _fullName = "";
                }
                return _fullName;
            }

            set
            {
                _fullName = value;
            }
        }
    }
}
