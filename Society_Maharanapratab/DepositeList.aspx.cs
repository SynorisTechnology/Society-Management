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
    public partial class DepositeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    if (!IsPostBack)
        //    {
        //        FillGrid1();
        //    }
        }
        //protected void FillGrid1()
        //{
        //    DataSet ds = BusinessLayer.Admin.GetsearchDeposite();
        //    GridView1.DataSource = ds.Tables[0];
        //    GridView1.DataBind();
        //}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "EDIT")
            {
                Response.Redirect("~/DepositeAdd.aspx?RegistrationID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "VIEW")
            {
                Response.Redirect("~/View.aspx?DepositeID=" + e.CommandArgument.ToString());
            }
            if (e.CommandName.ToUpper() == "DELETE")
            {
                int DepositeID = Convert.ToInt32(e.CommandArgument.ToString());
                OpreationResult opr = BusinessLayer.Admin.DeleteDeposite(DepositeID);
                if (opr.ReturnValue > 0)
                {
                    Response.Write("<script>alert('Saved Successfully');</script>");
                }
                //FillGrid1();
            }
        }
    }
}