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
using System.Data.SqlTypes;
public partial class Backoffice_Tarif_AddRawatInap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["SIMRS.UserId"] == null)
            {
                Response.Redirect(Request.ApplicationPath + "/Backoffice/login.aspx");
            }
            int UserId = (int)Session["SIMRS.UserId"];
            if (Session["AddTarif"] == null)
            {
                Response.Redirect(Request.ApplicationPath + "/Backoffice/UnAuthorize.aspx");
            }
            btnSave.Text = "<center><img alt=\"" + Resources.GetString("", "Save") + "\" src=\"" + Request.ApplicationPath + "/images/save_f2.gif\" align=\"middle\" border=\"0\" name=\"save\" value=\"save\"><center>";
            btnCancel.Text = "<center><img alt=\"" + Resources.GetString("", "Cancel") + "\" src=\"" + Request.ApplicationPath + "/images/cancel_f2.gif\" align=\"middle\" border=\"0\" name=\"cancel\" value=\"cancel\"><center>";

            GetListKelompokLayanan();
        }

    }

    public void GetListKelompokLayanan()
    {
        string KelompokLayananId = "";
        if (Request.QueryString["KelompokLayananId"] != null && Request.QueryString["KelompokLayananId"].ToString() != "")
            KelompokLayananId = Request.QueryString["KelompokLayananId"].ToString();
        SIMRS.DataAccess.RS_KelompokLayanan myObj = new SIMRS.DataAccess.RS_KelompokLayanan();
        DataTable dt = myObj.GetList();
        cmbKelompokLayanan.Items.Clear();
        int i = 0;
        cmbKelompokLayanan.Items.Add("");
        cmbKelompokLayanan.Items[i].Text = "";
        cmbKelompokLayanan.Items[i].Value = "";
        i++;
        foreach (DataRow dr in dt.Rows)
        {
            cmbKelompokLayanan.Items.Add("");
            cmbKelompokLayanan.Items[i].Text = dr["Kode"].ToString()+". "+dr["Nama"].ToString();
            cmbKelompokLayanan.Items[i].Value = dr["Id"].ToString();
            if (dr["Id"].ToString() == KelompokLayananId)
                cmbKelompokLayanan.SelectedIndex = i;
            i++;
        }
    }
    
    /// <summary>
    /// This function is responsible for save data into database.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnSave(Object sender, EventArgs e)
    {
        if (Session["SIMRS.UserId"] == null)
        {
            Response.Redirect(Request.ApplicationPath + "/Backoffice/login.aspx");
        }
        int UserId = (int)Session["SIMRS.UserId"];
        if (!Page.IsValid)
        {
            return;
        }

        SIMRS.DataAccess.RS_Layanan myObj = new SIMRS.DataAccess.RS_Layanan();
        myObj.Id = 0;
        myObj.Kode = txtKode.Text;
        myObj.Nama = txtNama.Text;
        myObj.JenisLayananId = 2;// Rawat Inap
        if (cmbKelompokLayanan.SelectedIndex > 0)
            myObj.KelompokLayananId = int.Parse(cmbKelompokLayanan.SelectedItem.Value);
        decimal RJ = 0;
        decimal Kelas3 = 0;
        decimal Kelas2 = 0;
        decimal Kelas1 = 0;
        decimal KelasV = 0;
        decimal KelasVV = 0;
        if (txtTarifIII.Value != "")
            Kelas3 = decimal.Parse(txtTarifIII.Value);
        if (txtTarifII.Value != "")
            Kelas2 = decimal.Parse(txtTarifII.Value);
        if (txtTarifI.Value != "")
            Kelas1 = decimal.Parse(txtTarifI.Value);
        if (txtTarifVIP.Value != "")
            KelasV = decimal.Parse(txtTarifVIP.Value);
        if (txtTarifVVIP.Value != "")
            KelasVV = decimal.Parse(txtTarifVVIP.Value);

        myObj.Keterangan = txtKeterangan.Text;
        myObj.CreatedBy = UserId;
        myObj.CreatedDate = DateTime.Now;

        if (myObj.IsExist())
        {
            lblError.Text = Resources.GetString("Referensi", "WarExistLayanan");
            return;
        }
        else
        {
            myObj.InsertDataRI(RJ, Kelas3, Kelas2, Kelas1, KelasV, KelasVV);
            string KelompokLayananId = "";
            if (Request.QueryString["KelompokLayananId"] != null && Request.QueryString["KelompokLayananId"].ToString() != "")
                KelompokLayananId = Request.QueryString["KelompokLayananId"].ToString();
            string CurrentPage = "";
            if (Request.QueryString["CurrentPage"] != null && Request.QueryString["CurrentPage"].ToString() != "")
                CurrentPage = Request.QueryString["CurrentPage"].ToString();
            Response.Redirect("ListRawatInap.aspx?CurrentPage=" + CurrentPage + "&KelompokLayananId=" + KelompokLayananId);
        }
    }
    /// <summary>
    /// This function is responsible for cancel save data into database.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnCancel(Object sender, EventArgs e)
    {
        string CurrentPage = "";
        string KelompokLayananId = "";
        if (Request.QueryString["KelompokLayananId"] != null && Request.QueryString["KelompokLayananId"].ToString() != "")
            KelompokLayananId = Request.QueryString["KelompokLayananId"].ToString();
        if (Request.QueryString["CurrentPage"] != null && Request.QueryString["CurrentPage"].ToString() != "")
            CurrentPage = Request.QueryString["CurrentPage"].ToString();
        Response.Redirect("ListRawatInap.aspx?CurrentPage=" + CurrentPage + "&KelompokLayananId=" + KelompokLayananId);
    }
}
