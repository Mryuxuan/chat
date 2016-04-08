using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class sent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Application["chatcontent"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s;
            s = "<font color='blue'>" + Session["username"].ToString() + "</font>";
            s = s + txtcontent.Text;
            s = s + "(<i>" + DateTime.Now.ToString() + "</i>)";
            s = s + "<br>";
            Application.Lock();
            Application["chatcontent"] = Application["chatcontent"].ToString() + s;
            Application.UnLock();
            txtcontent.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string users;
            string[] user;
            Application.Lock();
            users = Application["username"].ToString();
            user = users.Split(',');
            Application["username"] = null;
            for (int i = 0; i < user.Length; i++)
            {
                if (Session["username"].ToString() != user[i])
                {
                    if (Application["username"] == null)
                        Application["username"] = user[i];
                    else
                        Application["username"] = Application["username"].ToString() + "," + user[i];

                }
            }
            Application["chatcontent"] = Application["chatcontent"].ToString() + "<font color='red'>" + Session["username"].ToString() + "</font>" + "离开了聊天室！<br>";
            Application.UnLock();
            Session["username"] = null;
            Response.Redirect("login.aspx");

        }

        protected void Button2_Load(object sender, EventArgs e)
        {
           
        }
    }
}