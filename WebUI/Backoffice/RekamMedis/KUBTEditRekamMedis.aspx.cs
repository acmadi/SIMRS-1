using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Backoffice_RekamMedis_KUBTEditRekamMedis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, ImageClickEventArgs e)
    {
        if (EditRekamMedisKUBT1.OnSave())
        {
            if (Request["RawatJalanId"] != null && Request["RawatJalanId"] != "")
                Response.Redirect("KUBTView.aspx?RawatJalanId=" + Request["RawatJalanId"].ToString());
        }
    }
    protected void btnCancel_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("KUBTView.aspx?RawatJalanId=" + Request["RawatJalanId"].ToString());
    }
}
