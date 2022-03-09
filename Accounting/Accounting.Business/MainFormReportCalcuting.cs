using Accounting.DataLayer.Context;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class MainFormReportCalcuting 
    {
        
        public static ReportMainFormViewModel CalcuteReport(int numberOfDays)
        {
            using (UnitOfWorkPattern db=new UnitOfWorkPattern())
            {
                DateTime startDate = DateTime.Now.AddDays(-numberOfDays);
                DateTime endDate = DateTime.Now;
                int recive = db.AccountigRepository.Get(a => a.DateTitle < endDate && a.DateTitle > startDate && a.TypeID==1).Select(r => r.Amount).Sum();
                int pay = db.AccountigRepository.Get(a => a.DateTitle < endDate && a.DateTitle > startDate && a.TypeID == 2).Select(r => r.Amount).Sum();
                int balance = recive - pay;
                ReportMainFormViewModel repViewModel = new ReportMainFormViewModel()
                {
                    Recieve = recive,
                    Pay=pay,
                    Balance=balance
                };
                return repViewModel;
            }
        }
        //public static ReportMainFormViewModel CalcuteReport(string startDate,string endDate)
        //{
        //    using (UnitOfWorkPattern db = new UnitOfWorkPattern())
        //    {
        //        DateTime startDate = DateTime.Now.AddDays(-numberOfDays);
        //        DateTime endDate = DateTime.Now;
        //        int recive = db.AccountigRepository.Get(a => a.DateTitle < endDate && a.DateTitle > startDate && a.TypeID == 1).Select(r => r.Amount).Sum();
        //        int pay = db.AccountigRepository.Get(a => a.DateTitle < endDate && a.DateTitle > startDate && a.TypeID == 2).Select(r => r.Amount).Sum();
        //        int balance = recive - pay;
        //        ReportMainFormViewModel repViewModel = new ReportMainFormViewModel()
        //        {
        //            Recieve = recive,
        //            Pay = pay,
        //            Balance = balance
        //        };
        //        return repViewModel;
        //    }
        //}
    }
}
