using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChitApp
{
    public partial class Sites : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              try
              {
                  MenuItem mnuItem = Menu1.FindItem("Register"); // Find particular item
                  Menu1.Items.Remove(mnuItem);
                  MenuItem mnuItem1 = Menu1.FindItem("Payment"); // Find particular item
                  Menu1.Items.Remove(mnuItem1);
              }
              catch(Exception ex)
              {
                  Response.Write(ex.Message);
              }
          }
          public void PageDisplay()
          {
              //MenuItem mnuItem = Menu1.S("Register"); // Find particular item

              //MenuItem mnuItem1 = Menu1.FindItem("Payment"); // Find particular item
              MenuItem obj = new MenuItem();
              obj.Text = "Register";
              obj.NavigateUrl = "~/RegistrationPage.aspx";
              Menu1.Items.Add(obj);

              Menu1.Items.Add(new MenuItem
              {
                  Text = "Payment",
                  NavigateUrl = "~/PaymentPage.aspx"
              });

          }
        }
    }
