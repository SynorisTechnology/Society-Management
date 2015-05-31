using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Globalization;

namespace Society_Maharanapratab
{
    public partial class UserLoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDate1.Text = DateTime.Today.ToString("dd/MM/yyyy");
                FillDropdown();
                FillDDL();
                if (Request.QueryString.Count > 0)
                {
                    int UserLoanId = Convert.ToInt32(Request.QueryString["UserLoanId"].ToString());
                    DataSet ds = BusinessLayer.Admin.GetUserLoan(UserLoanId);
                    ddlUser.SelectedValue = ds.Tables[0].Rows[0]["RegistrationID"].ToString();
                    //ddlLoanType.SelectedValue = ds.Tables[0].Rows[0]["LoanType"].ToString();
                    ddlLoanType.SelectedValue = ds.Tables[0].Rows[0]["LoanId"].ToString();
                    if (ds.Tables[0].Rows[0]["LoanId"].ToString() == "0")
                    {
                        txtLoanType.Text = ds.Tables[0].Rows[0]["LoanType"].ToString();
                        txtLoanType.Visible = true;
                    }
                    else
                    {
                        txtLoanType.Visible = false;
                    }


                    txtAmount.Text = ds.Tables[0].Rows[0]["Amount"].ToString();
                    ddlDuration.SelectedValue = ds.Tables[0].Rows[0]["Duration"].ToString();
                    txtAmountUnitInterest.Text = ds.Tables[0].Rows[0]["AmountUnitInterest"].ToString();
                    //txtDate1.Text = ds.Tables[0].Rows[0]["Date"].ToString();
                    txtDate1.Text = (Convert.ToDateTime(ds.Tables[0].Rows[0]["Date"].ToString())).ToString("dd/MM/yyyy");
                    btnInsert.Text = "Update";
                }
            }
        }
        protected void FillDropdown()
        {
            DataSet ds = BusinessLayer.Admin.UserName();
            ddlUser.DataSource = ds.Tables[0];
            ddlUser.DataTextField = "Name";
            ddlUser.DataValueField = "RegistrationID";
            ddlUser.DataBind();
            ddlUser.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        protected void FillDDL()
        {
            DataSet ds = BusinessLayer.Admin.UserLoan();
            ddlLoanType.DataSource = ds.Tables[0];
            ddlLoanType.DataTextField = "LoanType";
            ddlLoanType.DataValueField = "LoanId";
            ddlLoanType.DataBind();
            ddlLoanType.Items.Insert(0, new ListItem("--Select--", "-1"));
            ddlLoanType.Items.Insert(1, new ListItem("Other", "0"));
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            bool IsValid = true;
            if (ddlLoanType.Items.Count > 0)
            {
                foreach (ListItem i in ddlLoanType.Items)
                {
                    if (i.Value == txtLoanType.Text)
                    {
                        IsValid = false;
                    }
                }
            }
            if (IsValid == false)
            {
                //Response.Write("<script>alert('Not Saved');</script>");
                lblError.Text = "Other loan type is alredy exist.";
                return;
            }
            else
            {
                if (btnInsert.Text == "Update")
                {
                    Entity obj = new Entity();
                    int UserLoanId = Convert.ToInt32(Request.QueryString["UserLoanId"].ToString());
                    //ddlUser.SelectedValue = ds.Tables[0].Rows[0]["RegistrationID"].ToString();
                    obj.Name = ddlUser.Text.ToString().Trim();
                    obj.LoanType = ddlLoanType.Text.ToString().Trim();
                    if (ddlLoanType.SelectedValue == "0")
                    {
                        obj.LoanType = txtLoanType.Text.ToString().Trim();

                    }
                    else
                    {

                        obj.LoanType = ddlLoanType.SelectedItem.Text.ToString().Trim();
                    }
                    obj.Amount = txtAmount.Text.ToString().Trim();
                    obj.Duration = ddlDuration.Text.ToString().Trim();
                    obj.AmountUnitInterest = txtAmountUnitInterest.Text.ToString().Trim();
                    obj.Date = obj.Date = DateTime.ParseExact(txtDate1.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                            .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    obj.LoanId = Convert.ToInt16(ddlLoanType.SelectedValue.ToString());
                    OpreationResult or = new OpreationResult();
                    or = BusinessLayer.Admin.UpdateUserLoan(obj, UserLoanId);
                    if (or.ReturnValue > 0)
                    {

                        Response.Write("<script>alert('Updated Successfully');</script>");
                        Response.Redirect("UserLoanList.aspx");
                    }

                    else
                    {
                        Response.Write("<script>alert('Not Updated');</script>");

                    }
                }
                if (btnInsert.Text == "Insert")
                {
                    Entity obj = new Entity();
                    obj.RegistrationID = Convert.ToInt16(ddlUser.SelectedValue);
                    //obj.RegistrationID = Convert.ToInt16(ddlUser.SelectedValue.ToString());
                    obj.LoanType = ddlLoanType.Text.ToString().Trim();
                    if (ddlLoanType.SelectedValue == "0")
                    {
                        obj.LoanType = txtLoanType.Text.ToString().Trim();

                    }
                    else
                    {

                        obj.LoanType = ddlLoanType.SelectedItem.Text.ToString().Trim();
                    }
                    obj.Amount = txtAmount.Text.ToString().Trim();
                    obj.Duration = ddlDuration.SelectedValue.ToString().Trim();
                    obj.AmountUnitInterest = txtAmountUnitInterest.Text.ToString().Trim();
                    obj.Date = DateTime.ParseExact(txtDate1.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                            .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                    obj.LoanId = Convert.ToInt16(ddlLoanType.SelectedValue.ToString());
                    OpreationResult or = new OpreationResult();
                    or = BusinessLayer.Admin.UserInsert(obj);
                    if (or.ReturnValue > 0)
                    {

                        //Response.Write("<script>alert('Saved Successfully');</script>");
                        Response.Redirect("UserLoanList.aspx");
                    }

                    else
                    {
                        Response.Write("<script>alert('Not Saved');</script>");

                    }

                }
            }
        }

        protected void ddlLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLoanType.SelectedValue == "0")
            {
                txtLoanType.Visible = true;
            }
            else
            {
                txtLoanType.Visible = false;
            }
           
        }
    }
}