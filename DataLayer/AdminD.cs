using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DataLayer;

namespace DataLayer
{
    public class AdminD
    {
        //Save Registration
        public static OpreationResult SaveRegistration(Entity obj)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@Name", obj.Name);
            paralist.Add(para);
            para = new SqlParameter("@FatherName", obj.FatherName);
            paralist.Add(para);
            para = new SqlParameter("@Email", obj.Email);
            paralist.Add(para);
            para = new SqlParameter("@Address", obj.Address);
            paralist.Add(para);
            para = new SqlParameter("@DateOfBirth", obj.DateOfBirth);
            paralist.Add(para);
            para = new SqlParameter("@MobileNo", obj.MobileNo);
            paralist.Add(para);
            para = new SqlParameter("@Gender", obj.Gender);
            paralist.Add(para);
            para = new SqlParameter("@Age", obj.Age);
            paralist.Add(para);
            para = new SqlParameter("@Photo", obj.Photo);
            paralist.Add(para);
            para = new SqlParameter("@EmergencyContactName", obj.EmergencyContactName);
            paralist.Add(para);
            para = new SqlParameter("@EmergencyContactNo", obj.EmergencyContactNo);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("SaveRegistration", paralist);
        }
        // Update registration information
        public static OpreationResult registrationRegistration(Entity obj, int RegistrationID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationId", RegistrationID);
            paralist.Add(para);
            para = new SqlParameter("@Name", obj.Name);
            paralist.Add(para);
            para = new SqlParameter("@FatherName", obj.FatherName);
            paralist.Add(para);
            para = new SqlParameter("@Email", obj.Email);
            paralist.Add(para);
            para = new SqlParameter("@Address", obj.Address);
            paralist.Add(para);
            para = new SqlParameter("@DateOfBirth", obj.DateOfBirth);
            paralist.Add(para);
            para = new SqlParameter("@MobileNo", obj.MobileNo);
            paralist.Add(para);
            para = new SqlParameter("@Gender", obj.Gender);
            paralist.Add(para);
            para = new SqlParameter("@Age", obj.Age);
            paralist.Add(para);
            para = new SqlParameter("@EmergencyContactName", obj.EmergencyContactName);
            paralist.Add(para);
            para = new SqlParameter("@EmergencyContactNo", obj.EmergencyContactNo);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UpdateRegistration", paralist);
        }
        // Delete registration information
        public static OpreationResult DeleteRegistration(int RegistrationID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationId", RegistrationID);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("Delete_SocietyRegistration", paralist);
        }
        //Search registration   information
        public static DataSet Searchregistration(int RegistrationID)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@RegistrationID", RegistrationID);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("Get_SocietyRegistration", ParaList);
        }
        //GET Search registration   information
        public static DataSet Getsearchregistration()
        {
            return DataLayer.DataAccess.GetData("GetById_SocietyRegistration", null);
        }



        //Save Deposite Recipet
        public static OpreationResult SaveDeposite(Entity obj)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationID", obj.RegistrationID);
            paralist.Add(para);
            para = new SqlParameter("@Date", obj.Date);
            paralist.Add(para);
            //para = new SqlParameter("@LoanId", obj.LoanId);
            //paralist.Add(para);
            para = new SqlParameter("@Loan", obj.Loan);
            paralist.Add(para);
            para = new SqlParameter("@CashLoan", obj.CashLoan);
            paralist.Add(para);
            para = new SqlParameter("@ConsumerLoan", obj.ConsumerLoan);
            paralist.Add(para);
            para = new SqlParameter("@VehicleLoan", obj.VehicleLoan);
            paralist.Add(para);
            para = new SqlParameter("@HelpLoan", obj.HelpLoan);
            paralist.Add(para);
            para = new SqlParameter("@Interest", obj.Interest);
            paralist.Add(para);
            para = new SqlParameter("@PunishmentInterest", obj.PunishmentInterest);
            paralist.Add(para);
            para = new SqlParameter("@TrustFund", obj.TrustFund);
            paralist.Add(para);
            para = new SqlParameter("@EntryFee", obj.EntryFee);
            paralist.Add(para);
            para = new SqlParameter("@Other", obj.Other);
            paralist.Add(para);
            para = new SqlParameter("@Total", obj.Total);
            paralist.Add(para);
            para = new SqlParameter("@EntryDoneBy", obj.EntryDoneBy);
            paralist.Add(para);
            //para = new SqlParameter("@LoanType", obj.LoanType);
            //paralist.Add(para);
            para = new SqlParameter("@UserLoanId", obj.UserLoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("SaveDeposite", paralist);
        }
        // Update  Deposite
        public static OpreationResult UpdateDeposite(Entity obj, int DepositeID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@DepositeID", DepositeID);
            paralist.Add(para);
            //para = new SqlParameter("@Name", obj.Name);
           // paralist.Add(para);
            para = new SqlParameter("@Date", obj.Date);
            paralist.Add(para);
            //para = new SqlParameter("@SNo", obj.SNo);
            //paralist.Add(para);
            //para = new SqlParameter("@Description", obj.Description);
            //paralist.Add(para);
            //para = new SqlParameter("@Rupees", obj.Rupees);
            //paralist.Add(para);
            //para = new SqlParameter("@LoanId", obj.LoanId);
            //paralist.Add(para);
            para = new SqlParameter("@Loan", obj.Loan);
            paralist.Add(para);
            para = new SqlParameter("@CashLoan", obj.CashLoan);
            paralist.Add(para);
            para = new SqlParameter("@ConsumerLoan", obj.ConsumerLoan);
            paralist.Add(para);
            para = new SqlParameter("@VehicleLoan", obj.VehicleLoan);
            paralist.Add(para);
            para = new SqlParameter("@HelpLoan", obj.HelpLoan);
            paralist.Add(para);
            para = new SqlParameter("@Interest", obj.Interest);
            paralist.Add(para);
            para = new SqlParameter("@PunishmentInterest", obj.PunishmentInterest);
            paralist.Add(para);
            para = new SqlParameter("@TrustFund", obj.TrustFund);
            paralist.Add(para);
            para = new SqlParameter("@EntryFee", obj.EntryFee);
            paralist.Add(para);
            para = new SqlParameter("@Other", obj.Other);
            paralist.Add(para);
            para = new SqlParameter("@Total", obj.Total);
            paralist.Add(para);
            para = new SqlParameter("@EntryDoneBy", obj.EntryDoneBy);
            paralist.Add(para);
            //para = new SqlParameter("@LoanType", obj.LoanType);
            //paralist.Add(para);
            para = new SqlParameter("@UserLoanId", obj.UserLoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UpdateDeposite", paralist);
        }
        // Delete  Deposite
        public static OpreationResult DeleteDeposite(int DepositeID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@DepositeID", DepositeID);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("deleteDeposite", paralist);
        }
        //Search   Deposite 
        public static DataSet GetByIdSearchDeposite(int DepositeID)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@DepositeID", DepositeID);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("GetById_Deposite", ParaList);
        }
        //GET Search    Deposite
        public static DataSet GetsearchDeposite(int? RegistrationID)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@RegistrationID", RegistrationID);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("Get_Deposite", ParaList);
        }
        //GET Deposit Deposite
        public static DataSet GetDeposite(int DepositeID)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@DepositeID", DepositeID);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("Detail_Select", ParaList);
        }
        //GET GetName    
        public static DataSet GetName()
        {
           
            return DataLayer.DataAccess.GetData("GetName", null);
        }
        //Select IsActive 
        public static DataSet GetIsActiveName()
        {

            return DataLayer.DataAccess.GetData("GetIsActiveName", null);
        }
        //GET GetDescription    
        public static DataSet GetDescription()
        {
            return DataLayer.DataAccess.GetData("description", null);
        }
        //GET Get Loan Type    
        //public static DataSet GetLoanType(int RegistrationID)
        //{
        //    List<SqlParameter> ParaList = new List<SqlParameter>();
        //    SqlParameter Para = new SqlParameter("@RegistrationID", RegistrationID);
        //    ParaList.Add(Para);
        //    return DataLayer.DataAccess.GetData("LoanTypebyUsername", ParaList);
        //}


        //Loan type

        //Loan Type ADD
        public static OpreationResult SaveLoanType(Entity obj)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@LoanType", obj.LoanType);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("SaveLoanType", paralist);
        }

        //Loan Type Update
        public static OpreationResult UpdateLoanType(Entity obj, int LoanId)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@LoanId", LoanId);
            paralist.Add(para);
            para = new SqlParameter("@LoanType", obj.LoanType);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UpdateLoanType", paralist);
        }
        //GET Loan Type
        public static DataSet GetLoanType(int RegistrationID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationID", RegistrationID);
            paralist.Add(para);
            return DataLayer.DataAccess.GetData("GetUserLoan", paralist);
        }
        // Delete  Loantype
        public static OpreationResult DeleteLoanType(int LoanId)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@LoanId", LoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("DeleteLoanType", paralist);
        }
        //GET Search Loan type
        public static DataSet GetsearchLoantype()
        {
            //List<SqlParameter> ParaList = new List<SqlParameter>();
            //SqlParameter Para = new SqlParameter("@LoanId", LoanId);
            //ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("SelectLoanType", null);
        }

        //GET ById Search Loan type
        public static DataSet GetsearchLoanById(int LoanId)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@LoanId", LoanId);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("SelectByIdLoantype", ParaList);
        }
        // Get Data Loan type User Id
        public static DataSet GetLoanTypeUserId(int RegistrationID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationID", RegistrationID);
            paralist.Add(para);
            return DataLayer.DataAccess.GetData("LoanTypebyUsername", paralist);
        }

        //UserLoan
         
        // User Insert  
        public static OpreationResult UserInsert(Entity obj)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationID", obj.RegistrationID);
            paralist.Add(para);
            para = new SqlParameter("@LoanType", obj.LoanType);
            paralist.Add(para);
            para = new SqlParameter("@Amount", obj.Amount);
            paralist.Add(para);
            para = new SqlParameter("@Duration", obj.Duration);
            paralist.Add(para);
            para = new SqlParameter("@AmountUnitInterest", obj.AmountUnitInterest);
            paralist.Add(para);
            para = new SqlParameter("@Date", obj.Date);
            paralist.Add(para);
            para = new SqlParameter("@LoanId", obj.LoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UserLoanInsert", paralist);
           }
        // Update User Loan
        public static OpreationResult UpdateUserLoan(Entity obj, int UserLoanId)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@UserLoanId", UserLoanId);
            paralist.Add(para);
            para = new SqlParameter("@Name", obj.Name);
            paralist.Add(para);
            para = new SqlParameter("@LoanType", obj.LoanType);
            paralist.Add(para);
            para = new SqlParameter("@Amount", obj.Amount);
            paralist.Add(para);
            para = new SqlParameter("@Duration", obj.Duration);
            paralist.Add(para);
            para = new SqlParameter("@AmountUnitInterest", obj.AmountUnitInterest);
            paralist.Add(para);
            para = new SqlParameter("@Date", obj.Date);
            paralist.Add(para);
            para = new SqlParameter("@LoanId", obj.LoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UpdateUserLoan", paralist);
        }
        // Get User Loan
        public static DataSet GetUserLoan(int UserLoanId)
        {
            List<SqlParameter> ParaList = new List<SqlParameter>();
            SqlParameter Para = new SqlParameter("@UserLoanId", UserLoanId);
            ParaList.Add(Para);
            return DataLayer.DataAccess.GetData("GetValueByIdUserLoan", ParaList);
        }
        //GET UserName    
        public static DataSet UserName()
        {

            return DataLayer.DataAccess.GetData("GetUserName", null);
        }
        // Get UserLoan
        public static DataSet UserLoan()
        {

            return DataLayer.DataAccess.GetData("LoanType_UserLoan", null);
        }
        //  UserLoan
        public static DataSet GetUserLoan()
        {

            return DataLayer.DataAccess.GetData("GetById_UserLoan", null);
        }
        // Delete  User Loan
        public static OpreationResult DeleteUserLaon(int UserLoanId)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@UserLoanId", UserLoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("DeleteUserLoan", paralist);
        }
        //  UserLoan Amount
        public static DataSet GetUserLoanAmount(int LoanType)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@UserLoanId", LoanType);
            paralist.Add(para);
            //para = new SqlParameter("@LoanType", LoanType);
            //paralist.Add(para);
            return DataLayer.DataAccess.GetData("Amount_Loan", paralist);
        }

        //  UserLoan Amount
        public static DataSet GetUserInstallments(int LoanType)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@UserLoanId", LoanType);
            paralist.Add(para);
            //para = new SqlParameter("@LoanType", LoanType);
            //paralist.Add(para);
            return DataLayer.DataAccess.GetData("GetUserInstallment", paralist);
        }




        //Reactive customer
        public static DataSet ReActioveCustomer()
        {
            //List<SqlParameter> paralist = new List<SqlParameter>();
            //SqlParameter para = new SqlParameter("@RegistrationId", RegistrationID);
            //paralist.Add(para);
            return DataLayer.DataAccess.GetData("Reactive_Customer", null);
        }

        //ReActive1
        public static OpreationResult ReActive1(int RegistrationID)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@RegistrationId", RegistrationID);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("Reacitve", paralist);
        }

        //ReActive User
        public static DataSet UserReactive()
        {
            //List<SqlParameter> paralist = new List<SqlParameter>();
            //SqlParameter para = new SqlParameter("@UserLoanId", );
            //paralist.Add(para);
            return DataLayer.DataAccess.GetData("UserReactive_Customer", null);
        }

        //ReActive1 User
        public static OpreationResult UserReactive1(int UserLoanId)
        {
            List<SqlParameter> paralist = new List<SqlParameter>();
            SqlParameter para = new SqlParameter("@UserLoanId", UserLoanId);
            paralist.Add(para);
            return DataLayer.DataAccess.ExecuteNonQuery("UserReacitve", paralist);
        }



       
    }
}
