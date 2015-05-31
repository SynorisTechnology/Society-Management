using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using DataLayer;
using BusinessLayer;

namespace BusinessLayer
{
    public class Admin
    {
        //Save Registration
        public static OpreationResult SaveRegistration(Entity obj)
        {
            return DataLayer.AdminD.SaveRegistration(obj);
        }
        //   Update registration information
       
        public static OpreationResult registrationRegistration(Entity obj, int RegistrationID)
        {
            return DataLayer.AdminD.registrationRegistration(obj, RegistrationID);
        }
        // Delete registration information

        public static OpreationResult DeleteRegistration(int RegistrationID)
        {
            return DataLayer.AdminD.DeleteRegistration(RegistrationID);
        }
        //Search registration   information
        public static DataSet Searchregistration(int RegistrationID)
        {
            return DataLayer.AdminD.Searchregistration(RegistrationID);
        }
        //GET Search registration   information
        public static DataSet Getsearchregistration()
        {
            return DataLayer.AdminD.Getsearchregistration();
        }



        //Save Deposite
        public static OpreationResult SaveDeposite(Entity obj)
        {
            return DataLayer.AdminD.SaveDeposite(obj);
        }
        //   Update Deposite 

        public static OpreationResult UpdateDeposite(Entity obj, int DepositeID)
        {
            return DataLayer.AdminD.UpdateDeposite(obj, DepositeID);
        }
        // Delete  Deposite

        public static OpreationResult DeleteDeposite(int DepositeID)
        {
            return DataLayer.AdminD.DeleteDeposite(DepositeID);
        }
        //Search    Deposite
        public static DataSet GetByIdSearchDeposite(int DepositeID)
        {
            return DataLayer.AdminD.GetByIdSearchDeposite(DepositeID);
        }
        //GET Search Deposite
        public static DataSet GetsearchDeposite(int? RegistrationID)
        {
            return DataLayer.AdminD.GetsearchDeposite(RegistrationID);
        }
        //GET Deposit Deposite
        public static DataSet GetDeposite(int DepositeID)
        {
            return DataLayer.AdminD.GetDeposite(DepositeID);
        }
        //GET GetName    
        public static DataSet GetName()
        {
            return DataLayer.AdminD.GetName();
        }
        //Select IsActive
        public static DataSet GetIsActiveName()
        {
            return DataLayer.AdminD.GetIsActiveName();
        }
        //GET GetName    
        public static DataSet GetDescription()
        {
            return DataLayer.AdminD.GetDescription();
        }
        //GET Get Loan Tye 
        //public static DataSet GetLoanType(int RegistrationID)
        //{
        //    return DataLayer.AdminD.GetLoanType(RegistrationID);
        //}

        //Loan Type ADD
        public static OpreationResult SaveLoanType(Entity obj)
        {
            return DataLayer.AdminD.SaveLoanType(obj);
        }

        //Loan Type Update
        public static OpreationResult UpdateLoanType(Entity obj, int LoanId)
        {
            return DataLayer.AdminD.UpdateLoanType(obj, LoanId);
        }
        // Delete  Loantype
        public static OpreationResult DeleteLoanType(int LoanId)
        {
            return DataLayer.AdminD.DeleteLoanType(LoanId);
        }

        //GET Loan Type    
        public static DataSet GetLoanType(int RegistrationID)
        {
            return DataLayer.AdminD.GetLoanType(RegistrationID);
        }

        //GET Search Loan type
        public static DataSet GetsearchLoantype()
        {
            return DataLayer.AdminD.GetsearchLoantype();
        }

        //GET ById Search Loan type
        public static DataSet GetsearchLoanById(int LoanId)
        {
            return DataLayer.AdminD.GetsearchLoanById(LoanId);
        }
        // Get Data Loan type User Id
        public static DataSet GetLoanTypeUserId(int RegistrationID)
        {
            return DataLayer.AdminD.GetLoanTypeUserId(RegistrationID);
        }


        //UserLoan


        // User Insert 
        public static OpreationResult UserInsert(Entity obj)
        {
            return DataLayer.AdminD.UserInsert(obj);
        }
        // Update User Loan
        public static OpreationResult UpdateUserLoan(Entity obj, int UserLoanId)
        {
            return DataLayer.AdminD.UpdateUserLoan(obj, UserLoanId);
        }
        // Get User Loan
        public static DataSet GetUserLoan(int UserLoanId)
        {
            return DataLayer.AdminD.GetUserLoan(UserLoanId);
        }
        //GET UserName
        public static DataSet UserName()
        {
            return DataLayer.AdminD.UserName();
        }
        // Get UserLoan  
        public static DataSet UserLoan()
        {
            return DataLayer.AdminD.UserLoan();
        }
        //  UserLoan  
        public static DataSet GetUserLoan()
        {
            return DataLayer.AdminD.GetUserLoan();
        }
        // Delete  User Loan

        public static OpreationResult DeleteUserLaon(int UserLoanId)
        {
            return DataLayer.AdminD.DeleteUserLaon(UserLoanId);
        }
         //  UserLoan Amount
        public static DataSet GetUserLoanAmount(int LoanType)
        {
            return DataLayer.AdminD.GetUserLoanAmount(LoanType);
        }

        //  UserInstallment Amount
        public static DataSet GetUserInstallments(int LoanType)
        {
            return DataLayer.AdminD.GetUserInstallments(LoanType);
        }




        //ReActive
        public static DataSet ReActioveCustomer()
        {
            return DataLayer.AdminD.ReActioveCustomer();
        }
        //ReActive1
        public static OpreationResult ReActive1(int RegistrationID)
        {
            return DataLayer.AdminD.ReActive1(RegistrationID);
        }


        //ReActive User
        public static DataSet UserReactive()
        {
            return DataLayer.AdminD.UserReactive();
        }
        //ReActive1 User
        public static OpreationResult UserReactive1(int UserLoanId)
        {
            return DataLayer.AdminD.UserReactive1(UserLoanId);
        }
    }
}
