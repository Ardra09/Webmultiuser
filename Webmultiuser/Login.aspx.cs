using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webmultiuser
{
    public partial class Login : System.Web.UI.Page
    {
        class1 objcls = new class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select Count(Reg_Id) from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = objcls.Fn_scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {

                string str1 = "select Reg_Id from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string regid = objcls.Fn_scalar(str1);
                Session["userid"] = regid;
                string str2 = "select Log_Type from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string Log_Type = objcls.Fn_scalar(str2);
                if (Log_Type == "admin")
                {
                    Label1.Text = "Admin";
                }
                else if (Log_Type == "user")
                {
                    Label1.Text = "User";
                }
                else
                {
                    Label1.Text = "Invalid Username and Password";
                }
            }
        }
    }
}