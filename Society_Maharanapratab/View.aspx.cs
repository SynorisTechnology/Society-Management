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
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {

                    int RegistrationID = Convert.ToInt32(Request.QueryString["RegistrationID"].ToString());
                    DataSet ds = BusinessLayer.Admin.Searchregistration(RegistrationID);
                    //imgEmp.AlternateText = ds.Tables[0].Rows[0]["Photo"].ToString();
                    imgEmp.ImageUrl = ds.Tables[0].Rows[0]["Photo"].ToString();
                    lblName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    lblAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    lblEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    lblDOB.Text=(Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString())).ToString("MM/dd/yyyy");
                    //lblDOB.Text = ds.Tables[0].Rows[0]["DateOfBirth"].ToString();
                    lblMbl.Text = ds.Tables[0].Rows[0]["MobileNo"].ToString();

                    lblGender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
                    lblAge.Text = ds.Tables[0].Rows[0]["Age"].ToString();
                    lblECN.Text = ds.Tables[0].Rows[0]["EmergencyContactName"].ToString();
                    lblEmergencyContactNo.Text = ds.Tables[0].Rows[0]["EmergencyContactNo"].ToString();
                    btnEdit.Text = "Update";
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int RegistrationID = Convert.ToInt32(Request.QueryString["RegistrationID"].ToString());
            Response.Redirect("REgistration_Society.aspx?RegistrationID=" + RegistrationID);
        }

        protected void btnBackToList_Click(object sender, EventArgs e)
        {

        }
    }
}