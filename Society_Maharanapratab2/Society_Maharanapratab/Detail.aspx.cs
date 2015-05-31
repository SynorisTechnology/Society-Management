using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Society_Maharanapratab
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    int DepositeID = Convert.ToInt32(Request.QueryString["DepositeID"].ToString());
                    
                    DataSet ds = BusinessLayer.Admin.GetDeposite(DepositeID);
                    lblReciptId.Text = ds.Tables[0].Rows[0]["DepositeID"].ToString();
                    lblName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    lblFathername.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
                    lblAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    lblDate.Text=(Convert.ToDateTime(ds.Tables[0].Rows[0]["Date"].ToString())).ToString("MM/dd/yyyy");
                    //lblDate.Text = ds.Tables[0].Rows[0]["Date"].ToString();
                    lblLoanType.Text = ds.Tables[0].Rows[0]["LoanType"].ToString();
                    lblLoan.Text = ds.Tables[0].Rows[0]["Loan"].ToString();
                    lblCashLoan.Text = ds.Tables[0].Rows[0]["CashLoan"].ToString();
                    lblConsumerLoan.Text = ds.Tables[0].Rows[0]["ConsumerLoan"].ToString();
                    lblVehicleLoan.Text = ds.Tables[0].Rows[0]["VehicleLoan"].ToString();
                    lblHelpLoan.Text = ds.Tables[0].Rows[0]["HelpLoan"].ToString();
                    lblInterest.Text = ds.Tables[0].Rows[0]["Interest"].ToString();
                    lblPunishmentInterest.Text = ds.Tables[0].Rows[0]["PunishmentInterest"].ToString();
                    lblTrustFund.Text = ds.Tables[0].Rows[0]["TrustFund"].ToString();
                    lblEntryFee.Text = ds.Tables[0].Rows[0]["EntryFee"].ToString();
                    lblOther.Text = ds.Tables[0].Rows[0]["Other"].ToString();
                    lblTotal.Text = ds.Tables[0].Rows[0]["Total"].ToString();
                    lblEntryDoneBy.Text = ds.Tables[0].Rows[0]["EntryDoneBy"].ToString();
                    //btnUpdate.Text = "Update";
                }
            }
        }
        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int DepositeID = Convert.ToInt32(Request.QueryString["DepositeID"].ToString());
        //    Response.Redirect("AddDeposite.aspx?DepositeID=" + DepositeID);
        //}
    }
}