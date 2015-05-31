using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BusinessLayer;
using DataLayer;
using System.Drawing;
using System.IO;
using System.Text;
using System.Globalization;

namespace Society_Maharanapratab
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtage.Attributes.Add("readonly", "readonly");
            if (!IsPostBack)
            {
                //txtDOB.Text = DateTime.Today.ToString("dd/MM/yyyy");


                if (Request.QueryString.Count > 0)
                {


                    int RegistrationID = Convert.ToInt32(Request.QueryString["RegistrationID"].ToString());
                    DataSet ds = BusinessLayer.Admin.Searchregistration(RegistrationID);
                    txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    txtFathername.Text = ds.Tables[0].Rows[0]["FatherName"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    txtDOB.Text = (Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString())).ToString("dd/MM/yyyy");
                    txtMbl.Text = ds.Tables[0].Rows[0]["MobileNo"].ToString();
                    if (Convert.ToString(ds.Tables[0].Rows[0]["Gender"]).ToUpper() == "MALE")
                    {
                        rdomale.Checked = true;
                        rdoFemale.Checked = false;
                    }
                    else
                    {
                        rdomale.Checked = false;
                        rdoFemale.Checked = true;
                    }
                    txtage.Text = ds.Tables[0].Rows[0]["Age"].ToString();
                    txtECName.Text = ds.Tables[0].Rows[0]["EmergencyContactName"].ToString();
                    txtECNo.Text = ds.Tables[0].Rows[0]["EmergencyContactNo"].ToString();

                    fuPhoto.Visible = false;
                    fuPhoto.Enabled = false;
                    spimage.Visible = false;
                    //fuPhoto.Enabled = false;
                    //.Visible = false;
                    //RFVPhoto.EnableClientScript = false;
                    //fuPhoto.Visible = false;
                    //fuPhoto.Enabled = false;
                    //txtage.Enabled = false;
                    btnSubmit.Text = "Update";
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Update")
            {
                Entity obj = new Entity();
                int RegistrationID = Convert.ToInt32(Request.QueryString["RegistrationID"].ToString());
                obj.Name = txtName.Text.ToString().Trim();
                obj.FatherName = txtFathername.Text.ToString().Trim();
                obj.Address = txtAddress.Text.ToString().Trim();
                obj.Email = txtEmail.Text.ToString().Trim();
                obj.DateOfBirth = DateTime.ParseExact(txtDOB.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                        .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                obj.MobileNo = txtMbl.Text.ToString().Trim();
                if (rdomale.Checked)
                {
                    obj.Gender = "Male";
                }
                else
                {
                    obj.Gender = "Female";
                }


                obj.Age = txtage.Text.ToString().Trim();
                obj.EmergencyContactName = txtECName.Text.ToString().Trim();
                obj.EmergencyContactNo = txtECNo.Text.ToString().Trim();

                //string Pho = string.Empty;
                //if (fuPhoto.HasFile == true && fuPhoto.PostedFile.ContentLength < 5242880)
                //{
                //    string fileName = Path.GetFileName(fuPhoto.FileName);
                //    string ext4 = Path.GetExtension(fuPhoto.FileName).ToUpper();
                //    string AllowedImageTypes = System.Configuration.ConfigurationManager.AppSettings["AllowedImageTypes"].ToString();
                //    string filename = fuPhoto.FileName.ToLower().ToString();
                //    string[] exts = filename.Split('.');
                //    string name = exts[0].ToString();
                //    string ext = exts[1].ToString();
                //    if (AllowedImageTypes.Contains(ext4))
                //    {
                //        Pho = fuPhoto.FileName.Trim() + "_" + "1" + "." + ext;
                //        obj.Photo = "~/SocietyDB/REgistration_Society/" + fuPhoto;
                //    }
                //    else
                //    {
                //        Response.Write("<script>alert('Only jpg, jpeg, bmp, png files allowed');</script>");
                //    }

                OpreationResult or = new OpreationResult();
                or = BusinessLayer.Admin.registrationRegistration(obj, RegistrationID);
                if (or.ReturnValue > 0)
                {

                    //Response.Write("<script>alert('Update Successfully');</script>");
                    Response.Redirect("RegistrationList_Society.aspx");
                }

                else
                {
                    Response.Write("<script>alert('Not Update');</script>");

                }

                //}
            }

            if (btnSubmit.Text == "Submit")
            {
                Entity obj = new Entity();

                obj.Name = txtName.Text.ToString().Trim();
                obj.FatherName = txtFathername.Text.ToString().Trim();
                obj.Address = txtAddress.Text.ToString().Trim();
                obj.Email = txtEmail.Text.ToString().Trim();

                obj.DateOfBirth = DateTime.ParseExact(txtDOB.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                     .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
                obj.MobileNo = txtMbl.Text.ToString().Trim();
                if (rdomale.Checked)
                {
                    obj.Gender = "Male";
                }
                else
                {
                    obj.Gender = "Female";
                }
                obj.Age = txtage.Text.ToString().Trim();
                obj.EmergencyContactName = txtECName.Text.ToString().Trim();
                obj.EmergencyContactNo = txtECNo.Text.ToString().Trim();
                string Ph = string.Empty;
                if (fuPhoto.HasFile == true && fuPhoto.PostedFile.ContentLength < 5242880)
                {
                    string fileName = Path.GetFileName(fuPhoto.FileName);
                    string ext4 = Path.GetExtension(fuPhoto.FileName).ToUpper();
                    string AllowedImageTypes = System.Configuration.ConfigurationManager.AppSettings["AllowedImageTypes"].ToString();
                    //string filename = fuPhoto.FileName.ToLower().ToString();
                    //string[] exts = filename.Split('.');
                    //string name = exts[0].ToString();
                    //string ext = exts[1].ToString();

                    if (AllowedImageTypes.Contains(ext4))
                    {
                        //Pho = fuPhoto.FileName.Trim() + "_" + "" + "." + ext4;
                        fuPhoto.SaveAs(Server.MapPath("~/Images/Photo/") + fileName);
                        obj.Photo = "~/Images/Photo/" + fileName;

                    }
                    else
                    {
                        Response.Write("<script>alert('Only jpg, jpeg, bmp, png files allowed');</script>");
                    }

                }

                OpreationResult or = new OpreationResult();
                or = BusinessLayer.Admin.SaveRegistration(obj);
                if (or.ReturnValue > 0)
                {

                    Response.Write("<script>alert('Saved Successfully');</script>");
                    Response.Redirect("RegistrationList_Society.aspx");
                }

                else
                {
                    Response.Write("<script>alert('Not Saved');</script>");

                }


            }
        }
    }
}