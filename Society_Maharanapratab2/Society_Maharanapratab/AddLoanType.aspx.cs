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
    public partial class AddLoanType : System.Web.UI.Page
    {
        int LoanId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
                
                //DataSet ds = BusinessLayer.Admin.GetsearchLoanById(LoanId);
                //tx.Text = ds.Tables[0].Rows[0][""].ToString();
                //bt
               
            }
        }
        protected void FillGrid()
        {

            //if (ViewState["tbl_Loantype"] == null)
            //{
            //    GV_LoanType.DataSource = null;
            //    GV_LoanType.DataBind();
            //}
            //else
            //{
                DataSet ds = BusinessLayer.Admin.GetsearchLoantype();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        GV_LoanType.DataSource = ds.Tables[0];
                        GV_LoanType.DataBind();
                    }
                    else
                    {
                        ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                        GV_LoanType.DataSource = ds.Tables[0];
                        GV_LoanType.DataBind();
                        GV_LoanType.Rows[0].Visible = false;
                        GV_LoanType.Rows[0].Controls.Clear();

                    }
                }
                
            //}
            
        }

        protected void GV_LoanType_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {

                Entity obj = new Entity();
                obj.LoanType = ((TextBox)GV_LoanType.FooterRow.FindControl("txtLoanTypeNew")).Text;
                OpreationResult or = new OpreationResult();
                or = BusinessLayer.Admin.SaveLoanType(obj);
                if (or.ReturnValue > 0)
                {

                    //Response.Write("<script>alert('inserted Successfully');</script>");
                    //Response.Write("Your data was inserted successfully");
                    Response.Redirect("AddLoanType.aspx");
                }

                else
                {
                    Response.Write("<script>alert('Not Save');</script>");

                }
                FillGrid();
            }
       

            //if (e.CommandName.ToUpper() == "EDIT")
            //{
            //    Response.Redirect("~/AddLoanType.aspx?LoanId=" + e.CommandArgument.ToString());
            //}
            if (e.CommandName.ToUpper() == "DELETE")
            {
                int LoanId = Convert.ToInt32(e.CommandArgument.ToString());
                OpreationResult opr = BusinessLayer.Admin.DeleteLoanType(LoanId);
                if (opr.ReturnValue > 0)
                {
                    Response.Write("<script>return confirm('Not Delete');</script>");
                }
                FillGrid();
            }
            if (e.CommandName.ToUpper() == "UPDATE")
            { 
                
               LoanId  = Convert.ToInt32(e.CommandArgument.ToString());
            //HiddenField hfLoanType = (HiddenField)GV_LoanType.Rows[]
                //int LoanId = Convert.ToInt32(((HiddenField)GV_LoanType..FindControl("hf_LoanId")).Value);
               // int LoanId = Convert.ToInt32(Request.QueryString["LoanId"].ToString());
               
             // int LoanId = Convert.ToInt32(hf_LoanId.Text);
               
            }
           
        
        }
        protected void GV_LoanType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

        protected void GV_LoanType_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GV_LoanType.EditIndex = e.NewEditIndex;
            FillGrid();
        }

        protected void GV_LoanType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Entity obj = new Entity();
            //int LoanId = Convert.ToInt32(ViewState["LoanId"]);
            obj.LoanType = ((TextBox)GV_LoanType.Rows[e.RowIndex].FindControl("txtLoanType")).Text;
            OpreationResult or = new OpreationResult();
            or = BusinessLayer.Admin.UpdateLoanType(obj, LoanId);
            if (or.ReturnValue > 0)
            {

                //Response.Write("<script>alert('Updated Successfully');</script>");
                //Response.Write("Your data not Updated successfully");
                Response.Redirect("AddLoanType.aspx");
            }

            else
            {
                Response.Write("Your data not Updated successfully");

            }
            GV_LoanType.EditIndex = -1;
            FillGrid();
        }

        protected void GV_LoanType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GV_LoanType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_LoanType.PageIndex = e.NewPageIndex;
            FillGrid();
        }

        protected void GV_LoanType_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GV_LoanType.EditIndex = -1;
            FillGrid();

        }
    }
}