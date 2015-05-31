using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using BusinessLayer;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Society_Maharanapratab
{
    public partial class AddDeposite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTotal.Attributes.Add("readonly", "readonly");
            if (!IsPostBack)
            {
                txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                
                Filldropdown();
               // Filldropdown1();
                if (Request.QueryString.Count > 0)
                {
                    //int  = Convert.ToInt32(Request.QueryString[""].ToString());
                    int DepositeID = Convert.ToInt32(Request.QueryString["DepositeID"].ToString());
                    DataSet ds = BusinessLayer.Admin.GetDeposite(DepositeID);
                    ddlUsername.SelectedValue = ds.Tables[0].Rows[0]["RegistrationID"].ToString();
                    Filldropdown1(Convert.ToInt32(ddlUsername.SelectedValue));
                    txtDate.Text = (Convert.ToDateTime(ds.Tables[0].Rows[0]["Date"].ToString())).ToString("dd/MM/yyyy");
                    //txtLoanType.Text = ds.Tables[0].Rows[0]["LoanType"].ToString();
                    ddlLoanType.SelectedValue = ds.Tables[0].Rows[0]["UserLoanId"].ToString();
                    //if (ds.Tables[0].Rows[0]["LoanId"].ToString() == "0")
                    //{
                    //    txtLoanType.Text = ds.Tables[0].Rows[0]["LoanType"].ToString();
                    //    txtLoanType.Visible = true;
                    //}
                    //else
                    //{
                    //    txtLoanType.Visible = false;
                    //}
                    txtLoan.Text = ds.Tables[0].Rows[0]["Loan"].ToString();
                    txtCashLoan.Text = ds.Tables[0].Rows[0]["CashLoan"].ToString();
                    txtConsumerloan.Text = ds.Tables[0].Rows[0]["ConsumerLoan"].ToString();
                    txtVehicleLoan.Text = ds.Tables[0].Rows[0]["VehicleLoan"].ToString();
                    txtHelpLoan.Text = ds.Tables[0].Rows[0]["HelpLoan"].ToString();
                    txtInterest.Text = ds.Tables[0].Rows[0]["Interest"].ToString();
                    txtPunishmentInterest.Text = ds.Tables[0].Rows[0]["PunishmentInterest"].ToString();
                    txtTrustfund.Text = ds.Tables[0].Rows[0]["TrustFund"].ToString();
                    txtEntryfee.Text = ds.Tables[0].Rows[0]["EntryFee"].ToString();
                    txtOther.Text = ds.Tables[0].Rows[0]["Other"].ToString();
                    txtTotal.Text = ds.Tables[0].Rows[0]["Total"].ToString();
                    txtEntryDoneBy.Text = ds.Tables[0].Rows[0]["EntryDoneBy"].ToString();

                    

                    btnSave.Text = "Update";
                    lblRemaining.Visible = false;
                }
            }
        }
        protected void Filldropdown()
        {


            DataSet ds = BusinessLayer.Admin.GetIsActiveName();
            ddlUsername.DataSource = ds.Tables[0];
            ddlUsername.DataTextField = "Name";
            ddlUsername.DataValueField = "RegistrationID";
            ddlUsername.DataBind();
            ddlUsername.Items.Insert(0, new ListItem("--Select--", "0"));
            //ddlUsername.SelectedIndex = 0;
        }
        protected void Filldropdown1(int RegistrationID)
        {
            //int RegistrationID = Convert.ToInt32(ddlUsername.SelectedValue.ToString());
            DataSet ds = BusinessLayer.Admin.GetLoanType(RegistrationID);
            ddlLoanType.DataSource = ds.Tables[0];
            ddlLoanType.DataTextField = "LoanType";
            ddlLoanType.DataValueField = "UserLoanId";
            ddlLoanType.DataBind();
            ddlLoanType.Items.Insert(0, new ListItem("--Select--", "-1"));
            //ddlLoanType.Items.Insert(1, new ListItem("Other", "0"));
            //ddlLoanType.SelectedIndex = 0;

        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text=="Save")
            {
            Entity obj = new Entity();
            obj.RegistrationID= Convert.ToInt16(ddlUsername.SelectedValue.ToString());

            //obj.Name = ddlUsername.Text.ToString().Trim();
            obj.Date = DateTime.ParseExact(txtDate.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            //obj.LoanId = Convert.ToInt16(ddlLoanType.SelectedValue.ToString());
            //obj.LoanType = txtLoanType.Text.ToString().Trim();
            //obj.LoanType = ddlLoanType.Text.ToString().Trim();
            //if (ddlLoanType.SelectedValue == "0")
            //{
            //    obj.LoanType = txtLoanType.Text.ToString().Trim();
                
            //}
            //else
            //{

            //    obj.LoanType = ddlLoanType.SelectedItem.Text.ToString().Trim();
            //}
            //obj.LoanType = ddlLoanType.Text.ToString().Trim();
            obj.Loan = txtLoan.Text.ToString().Trim();
            obj.CashLoan = txtCashLoan.Text.ToString().Trim();
            obj.ConsumerLoan = txtConsumerloan.Text.ToString().Trim();
            obj.VehicleLoan = txtVehicleLoan.Text.ToString().Trim();
            obj.HelpLoan = txtHelpLoan.Text.ToString().Trim();
            obj.Interest = txtInterest.Text.ToString().Trim();
            obj.PunishmentInterest = txtPunishmentInterest.Text.ToString().Trim();
            obj.TrustFund = txtTrustfund.Text.ToString().Trim();
            obj.EntryFee = txtEntryfee.Text.ToString().Trim();
            obj.Other = txtOther.Text.ToString().Trim();
            obj.Total = txtTotal.Text.ToString().Trim();
            obj.EntryDoneBy = txtEntryDoneBy.Text.ToString().Trim();
            obj.UserLoanId = Convert.ToInt32(ddlLoanType.SelectedValue);
            OpreationResult or = new OpreationResult();
           
            or = BusinessLayer.Admin.SaveDeposite(obj);
            if (or.ReturnValue > 0)
                {
                 Response.Write("<script>alert('Save Successfully');</script>");
                 Response.Redirect("ListDepositeAdd.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Not Save');</script>");
                }
            }
            if (btnSave.Text == "Update")
            {
                Entity obj = new Entity();
                int DepositeID = Convert.ToInt32(Request.QueryString["DepositeID"].ToString());
                //ddlUsername.Text = (SelectedItem.Value.ToString());
                //obj.Name = ddlUsername.Text.ToString().Trim();
                obj.Date = obj.Date = DateTime.ParseExact(txtDate.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                //obj.LoanId = Convert.ToInt16(ddlLoanType.SelectedValue.ToString());
                //if (ddlLoanType.SelectedValue == "0")
                //{
                //    obj.LoanType = txtLoanType.Text.ToString().Trim();

                //}
                //else
                //{

                //    obj.LoanType = ddlLoanType.SelectedItem.Text.ToString().Trim();
                //}
                obj.Loan = txtLoan.Text.ToString().Trim();
                obj.CashLoan = txtCashLoan.Text.ToString().Trim();
                obj.ConsumerLoan = txtConsumerloan.Text.ToString().Trim();
                obj.VehicleLoan = txtVehicleLoan.Text.ToString().Trim();
                obj.HelpLoan = txtHelpLoan.Text.ToString().Trim();
                obj.Interest = txtInterest.Text.ToString().Trim();
                obj.PunishmentInterest = txtPunishmentInterest.Text.ToString().Trim();
                obj.TrustFund = txtTrustfund.Text.ToString().Trim();
                obj.EntryFee = txtEntryfee.Text.ToString().Trim();
                obj.Other = txtOther.Text.ToString().Trim();
                obj.Total = txtTotal.Text.ToString().Trim();
                obj.EntryDoneBy = txtEntryDoneBy.Text.ToString().Trim();
                obj.UserLoanId = Convert.ToInt32(ddlLoanType.SelectedValue);
                OpreationResult or = new OpreationResult();

                or = BusinessLayer.Admin.UpdateDeposite(obj,DepositeID);
                if (or.ReturnValue > 0)
                {
                    Response.Write("<script>alert('Update Successfully');</script>");
                    Response.Redirect("ListDepositeAdd.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Not Save');</script>");
                }
            }
        }

        protected void ddlUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            int RegistrationID = Convert.ToInt32(ddlUsername.SelectedValue);
            Filldropdown1(RegistrationID);
        }
        

        protected void ddlLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlLoanType.SelectedValue == "0")
            //{
            //    txtLoanType.Visible = true;
            //}
            //else
            //{
            //    txtLoanType.Visible = false;
            //}

            int RegistrationId = Convert.ToInt32(ddlUsername.SelectedValue);
            int UserLoadId = Convert.ToInt32(ddlLoanType.SelectedValue);

            DataSet ds1 = BusinessLayer.Admin.GetUserLoanAmount(UserLoadId);
            int TotalLoan = Convert.ToInt32(ds1.Tables[0].Rows[0]["Amount"]);
            //lblRemaining.Text = ds1.Tables[0].Rows[0]["Amount"].ToString();

            //DataSet dsdata = BusinessLayer.Admin.GetUserInstallments(UserLoadId);
            int TotalDeposite = 0;
            if (ds1.Tables[1].Rows.Count > 0)
            {
                foreach (DataRow dr  in ds1.Tables[1].Rows)
                {
                   TotalDeposite += Convert.ToInt32(dr["Total"]);
                }
            }
            int Remaining = TotalLoan - TotalDeposite;
            lblRemaining.Text = Remaining.ToString();

            //int a = Convert.ToInt32(lblRemaining.Text);
            //int b
            //int z = Convert.ToInt32(txtTotal.Text);
            //int z= a - z;
          
        }
        //protected void btnBCK_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("ListDepositeAdd.aspx");
        //}
    }
}