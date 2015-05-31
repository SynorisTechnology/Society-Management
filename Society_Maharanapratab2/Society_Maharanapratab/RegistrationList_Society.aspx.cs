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
    public partial class RegistrationList_Society : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
            }
        }
        protected void FillGrid()
        {
            DataSet ds = BusinessLayer.Admin.Getsearchregistration();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "EDIT")
            {
                Response.Redirect("~/REgistration_Society.aspx?RegistrationID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "VIEW")
            {
                Response.Redirect("~/View.aspx?RegistrationID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "DELETE")
            {
                int RegistrationID = Convert.ToInt32(e.CommandArgument.ToString());
                OpreationResult opr = BusinessLayer.Admin.DeleteRegistration(RegistrationID);
                if (opr.ReturnValue > 0)
                {
                    Response.Write("('Delete Successfully')");
                }
                FillGrid();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillGrid();
        }

        //protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        //{
        //    DataTable dtbl = new DataTable();
            
        //if (ViewState["Sort Order"] == null)
        //{
        //    dtbl.DefaultView.Sort = e.SortExpression + " DESC";
        //    GridView1.DataSource = dtbl;
        //    GridView1.DataBind();
        //    ViewState["Sort Order"] = "DESC";
        //}
        //else
        //{
        //    dtbl.DefaultView.Sort = e.SortExpression + "" + " ASC";
        //    GridView1.DataSource = dtbl;
        //    GridView1.DataBind();
        //    ViewState["Sort Order"] = null;
        //}
        //}

    }
}