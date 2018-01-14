using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet.Calculator
{
    public partial class CaculatorWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Result = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text));
            TextBox3.Text = Result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Result = (Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text));
            TextBox3.Text = Result.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int Result = (Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text));
            TextBox3.Text = Result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int Result = (Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text));
            TextBox3.Text = Result.ToString();
        }
    }
}