using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtpwd.Text.Trim() == "")
            {
                Response.Write("<script>alert('用户名和密码不能为空!')<script>");
                return;
            }
            if (userisexist(txtname.Text.Trim()) == true)
            {
                Response.Write("<script>alert('用户名已经存在，请重新输入用户名！')<script>");
                return;
            }
            if (txtpwd.Text.Trim() != "123456")
            {
                Response.Write("<script>alert('密码错误！')<script>");
                return;
            }
            Session["username"] = txtname.Text.Trim();
            if (Application["username"] == null)
                Application["username"] = txtname.Text.Trim();
            else
                Application["username"] = Application["username"].ToString() + "," + txtname.Text.Trim();
            Application["chatcontent"] = Application["chatcontent"].ToString() + "<br><font color='red'>" + txtname.Text.Trim() + "<font>进入了聊天室！";
            Response.Redirect("sent.aspx");
        }
        public Boolean userisexist(string username)
        {
            string users;
            if (Application["username"] == null)
                return false;
            users = Application["username"].ToString();
            string[] user;
            user = users.Split(',');
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == username)
                    return true;
            }
            return false;
        }
    }
}