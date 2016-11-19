using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jsWebService
{
    public partial class WebForm_ws_db : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPageTime.Text = DateTime.Now.ToString();
        }
    }
}