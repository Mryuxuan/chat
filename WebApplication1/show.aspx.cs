using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string users;
            string[] user;
            if (Application["username"] != null)
            {
                users = Application["username"].ToString();
                user = users.Split(',');
                for (int i = 0; i < user.Length; i++)
                {
                    ListBox1.Items.Add(user[i]);
                }
            }
        }
    }
}