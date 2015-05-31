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

namespace Society_Maharanapratab
{
    public partial class ListDepositeAdd : System.Web.UI.Page
    {
        //int RegistrationID;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                FillDropdown();
               // BindData();
                
                    //Table.innerHTML = TableString;
                    //BindGrid();
                }
            }

        [WebMethod]
        public static string BindData(string ddlValue)
        {
            string TableString = "";
            //if()
            //{
            Entity obj = new Entity();
            int RegistrationID = Convert.ToInt32(ddlValue);
                //Convert.ToInt32(ddlUName.SelectedValue);
            DataSet ds1 = BusinessLayer.Admin.GetLoanTypeUserId(RegistrationID);
           
            
            //TableString = TableString + "<table><tr><th>Loan Name</th></tr>";
            //for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
            //{
            //    TableString = TableString + "<tr><td>" + ds1.Tables[0].Rows[0]["LoanType"].ToString() + "</td></tr>";
            //}
            //}
            //RegistrationID = Convert.ToInt32(ddlUName.SelectedValue);
            DataSet ds = BusinessLayer.Admin.GetsearchDeposite(RegistrationID);
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
                {

                    TableString = TableString + "<fieldset style='border: 1px solid black;margin: 0;padding: 10px;'><legend style='display: block;'>" + ds1.Tables[0].Rows[j]["LoanType"].ToString() + "</legend><table class='dvtable'><tr><th>Customer Name</th><th>Father's Name</th><th>Loan Date</th><th>Total Paid</th><th>Entered By</th><th>Mobile Number</th><th>Gender</th><th>Action</th></tr>";


                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if ((ds1.Tables[0].Rows[j]["LoanType"]).ToString() == (ds.Tables[0].Rows[i]["LoanType"]).ToString())
                        {
                            TableString = TableString + "<tr><td>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</td><td>" + ds.Tables[0].Rows[i]["FatherName"].ToString() + "</td><td>" + (Convert.ToDateTime(ds.Tables[0].Rows[i]["Date"].ToString())).ToString("dd/MM/yyyy") + "</td><td>" + ds.Tables[0].Rows[i]["Total"].ToString() + "</td><td>" + ds.Tables[0].Rows[i]["EntryDoneBy"].ToString() + "</td><td>" + ds.Tables[0].Rows[i]["MobileNo"].ToString() + "</td><td>" + ds.Tables[0].Rows[i]["Gender"].ToString() + "</td><td><a id='lbtnEdit' href='/AddDeposite.aspx?DepositeID=" + ds.Tables[0].Rows[i]["DepositeID"] + "'>Edit|</a><a ID='lbtnDelete' OnClick='Delete(" + ds.Tables[0].Rows[i]["DepositeID"] + " );'>Delete|</a><a id='lbtnDetail' href='/Detail.aspx?DepositeID=" + ds.Tables[0].Rows[i]["DepositeID"] + "'>Detail|</a></td></tr>";
                        }
                    }

                    TableString = TableString + " </table></fieldset><br>";
                }
                //divtable.InnerHtml = TableString;
            }
            else
            {
                TableString = "<span style='color:red;font-weight:bold;'>No record found.</span>";
            }
            return TableString;
        }
        protected void FillDropdown()
        {
            DataSet ds = BusinessLayer.Admin.GetIsActiveName();
            ddlUName.DataSource = ds.Tables[0];
            ddlUName.DataTextField = "Name";
            ddlUName.DataValueField = "RegistrationID";
            ddlUName.DataBind();
            ddlUName.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        [WebMethod]
        public static string GetDeleteData(int DepositeID)
        {
            
            OpreationResult opr = BusinessLayer.Admin.DeleteDeposite(DepositeID);
            if (opr.ReturnValue > 0)
            {
                
            }
            return Convert.ToString(opr.ReturnValue);
        }
        //protected void BindGrid()
        //{


            //if (Convert.ToString(ddlUName.SelectedValue) == "")
            //{
            //    GV_list.DataSource = null;
            //    GV_list.DataBind();
            //}
            //else
            //{
                //string Registration = ddlUName.SelectedValue;


                //int? RegistrationID = Convert.ToInt32(ddlUName.SelectedValue);
                //if(RegistrationID == 0)
                //    RegistrationID=null;
                //DataSet ds = BusinessLayer.Admin.GetsearchDeposite(RegistrationID);
                //GV_list.DataSource = ds.Tables[0];
                //GV_list.DataBind();


            //}
        //}

        protected void GV_list_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "EDIT")
            {
                Response.Redirect("~/AddDeposite.aspx?DepositeID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "DETAIL")
            {
                Response.Redirect("~/Detail.aspx?DepositeID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "DELETE")
            {
                int DepositeID = Convert.ToInt32(e.CommandArgument.ToString());
                OpreationResult opr = BusinessLayer.Admin.DeleteDeposite(DepositeID);
                if (opr.ReturnValue > 0)
                {
                    Response.Write("Delete Successfully");
                }
                //BindGrid();
            }
        }

        protected void GV_list_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GV_list_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GV_list_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //GV_list.EditIndex = e.NewEditIndex;
            
        }

        protected void GV_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GV_list_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //GV_list.PageIndex = e.NewPageIndex;
            //BindGrid();
        }

        protected void ddlUName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BindData();
            //BindGrid();
        }
        
    }
}