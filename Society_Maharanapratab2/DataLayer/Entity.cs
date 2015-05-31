using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Entity
    {
        #region
        public int RegistrationID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Photo { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNo { get; set; }

        #endregion

        #region
        public int DepositeID { get; set; }
        
        public string Date { get; set; }
        public string SNo { get; set; }
        public string Description { get; set; }
        public string Rupees { get; set; }
        public string Loan { get; set; }
        public string CashLoan { get; set; }
        public string ConsumerLoan { get; set; }
        public string VehicleLoan { get; set; }
        public string HelpLoan { get; set; }
        public string Interest { get; set; }
        public string PunishmentInterest { get; set; }
        public string TrustFund { get; set; }
        public string EntryFee { get; set; }
        public string Other { get; set; }
        public string Total { get; set; }
        public string EntryDoneBy { get; set; }
        public string ReciptNo { get; set; }
        public string LoanType { get; set; }
        public int LoanId { get; set; }
        public int UserLoanId { get; set; }
        #endregion

        #region
        public string Amount { get; set; }
        public string Duration { get; set; }
        public string AmountUnitInterest { get; set; }
        #endregion
    }
}
