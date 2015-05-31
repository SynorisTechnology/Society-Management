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
    public partial class UserReActive : System.Web.UI.Page
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
            
            DataSet ds = BusinessLayer.Admin.UserReactive();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillGrid();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "REACTIVE")
            {
                int UserLoanId = Convert.ToInt32(e.CommandArgument.ToString());
                OpreationResult opr = BusinessLayer.Admin.UserReactive1(UserLoanId);
                if (opr.ReturnValue > 0)
                {
                    Response.Write("('ReActive Successfully')");
                }
                FillGrid();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}