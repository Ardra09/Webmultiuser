using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webmultiuser
{
    public partial class Admin_reg : System.Web.UI.Page
    {
        class1 objcls = new class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_tab";
            string maxregid = objcls.Fn_scalar(sel);
            int reg_id = 0;
            if(maxregid=="")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;
            }
            string ins = "insert into Admin_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = objcls.Fn_nonquery(ins);
            if(i==1)
            {
                string inslog = "insert into Login_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin','active')";
                int j = objcls.Fn_nonquery(inslog);
            }
        }
    }
}