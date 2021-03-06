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

public partial class Backoffice_Referensi_Kelas_List : System.Web.UI.Page
{
    public int NoKe = 0;
    protected string dsReportSessionName = "dsListRefKelas";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["SIMRS.UserId"] == null)
            {
                Response.Redirect(Request.ApplicationPath + "/Backoffice/login.aspx");
            }
            int UserId = (int)Session["SIMRS.UserId"];
            if (Session["KelasManagement"] == null)
            {
                Response.Redirect(Request.ApplicationPath + "/Backoffice/UnAuthorize.aspx");
            }
            else
            {
                btnNew.Text = "<img alt=\"New\" src=\"" + Request.ApplicationPath + "/images/new_f2.gif\" align=\"middle\" border=\"0\" name=\"new\" value=\"new\">" + Resources.GetString("Referensi", "AddKelas");
            }
            btnSearch.Text = Resources.GetString("", "Search");
            ImageButtonFirst.ImageUrl = Request.ApplicationPath + "/images/navigator/nbFirst.gif";
            ImageButtonPrev.ImageUrl = Request.ApplicationPath + "/images/navigator/nbPrevpage.gif";
            ImageButtonNext.ImageUrl = Request.ApplicationPath + "/images/navigator/nbNextpage.gif";
            ImageButtonLast.ImageUrl = Request.ApplicationPath + "/images/navigator/nbLast.gif";

            UpdateDataView(true);
        }
    }

    #region .Update View Data

    //////////////////////////////////////////////////////////////////////
    // PhysicalDataRead
    // ------------------------------------------------------------------

    /// <summary>
    /// This function is responsible for loading data from database.
    /// </summary>
    /// <returns>DataSet</returns>
    public DataSet PhysicalDataRead()
    {
        // Local variables
        DataSet oDS = new DataSet();

        // Get Data 
        SIMRS.DataAccess.RS_Kelas myObj = new SIMRS.DataAccess.RS_Kelas();
        DataTable myData = myObj.SelectAll();
        oDS.Tables.Add(myData);

        return oDS;
    }

    /// <summary>
    /// This function is responsible for binding data to Datagrid.
    /// </summary>
    /// <param name="dv"></param>
    private void BindData(DataView dv)
    {
        // Sets the sorting order
        dv.Sort = DataGridList.Attributes["SortField"];
        if (DataGridList.Attributes["SortAscending"] == "no")
            dv.Sort += " DESC";

        if (dv.Count > 0)
        {
            DataGridList.ShowFooter = false;
            int intRowCount = dv.Count;
            int intPageSaze = DataGridList.PageSize;
            int intPageCount = intRowCount / intPageSaze;
            if (intRowCount - (intPageCount * intPageSaze) > 0)
                intPageCount = intPageCount + 1;
            if (DataGridList.CurrentPageIndex >= intPageCount)
                DataGridList.CurrentPageIndex = intPageCount - 1;
        }
        else
        {
            DataGridList.ShowFooter = true;
            DataGridList.CurrentPageIndex = 0;
        }
        // Re-binds the grid 
        NoKe = DataGridList.PageSize * DataGridList.CurrentPageIndex;
        DataGridList.DataSource = dv;
        DataGridList.DataBind();

        int CurrentPage = DataGridList.CurrentPageIndex + 1;
        lblCurrentPage.Text = CurrentPage.ToString();
        lblTotalPage.Text = DataGridList.PageCount.ToString();
        lblTotalRecord.Text = dv.Count.ToString();
    }


    /// <summary>
    /// This function is responsible for loading data from database and store to Session.
    /// </summary>
    /// <param name="strDataSessionName"></param>
    public void DataFromSourceToMemory(String strDataSessionName)
    {
        // Gets rows from the data source
        DataSet oDS = PhysicalDataRead();

        // Stores it in the session cache
        Session[strDataSessionName] = oDS;
    }

    /// <summary>
    /// This function is responsible for update data view from datagrid.
    /// </summary>
    /// <param name="requery">true = get data from database, false= get data from session</param>
    public void UpdateDataView(bool requery)
    {
        // Retrieves the data
        if ((Session[dsReportSessionName] == null) || (requery))
        {
            if (Request.QueryString["CurrentPage"] != null && Request.QueryString["CurrentPage"].ToString() != "")
                DataGridList.CurrentPageIndex = int.Parse(Request.QueryString["CurrentPage"].ToString());
            DataFromSourceToMemory(dsReportSessionName);
        }
        DataSet ds = (DataSet)Session[dsReportSessionName];
        BindData(ds.Tables[0].DefaultView);

    }
    public void UpdateDataView()
    {
        // Retrieves the data
        if ((Session[dsReportSessionName] == null))
        {
            DataFromSourceToMemory(dsReportSessionName);
        }
        DataSet ds = (DataSet)Session[dsReportSessionName];
        BindData(ds.Tables[0].DefaultView);
    }

    #endregion

    #region .Event DataGridList
    //////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////
    //                           HANDLERs                               //
    //////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////


    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a new page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void PageChanged(Object sender, DataGridPageChangedEventArgs e)
    {
        DataGridList.CurrentPageIndex = e.NewPageIndex;
        DataGridList.SelectedIndex = -1;
        UpdateDataView();
    }

    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a new page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="nPageIndex"></param>
    public void GoToPage(Object sender, int nPageIndex)
    {
        DataGridPageChangedEventArgs evPage;
        evPage = new DataGridPageChangedEventArgs(sender, nPageIndex);
        PageChanged(sender, evPage);
    }
    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a first page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GoToFirst(Object sender, ImageClickEventArgs e)
    {
        GoToPage(sender, 0);
    }

    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a previous page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GoToPrev(Object sender, ImageClickEventArgs e)
    {
        if (DataGridList.CurrentPageIndex > 0)
        {
            GoToPage(sender, DataGridList.CurrentPageIndex - 1);
        }
        else
        {
            GoToPage(sender, 0);
        }
    }

    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a next page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GoToNext(Object sender, System.Web.UI.ImageClickEventArgs e)
    {
        if (DataGridList.CurrentPageIndex < (DataGridList.PageCount - 1))
        {
            GoToPage(sender, DataGridList.CurrentPageIndex + 1);
        }
    }

    /// <summary>
    /// This function is responsible for loading the content of the new
    /// page when you click on the pager to move to a last page.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GoToLast(Object sender, ImageClickEventArgs e)
    {
        GoToPage(sender, DataGridList.PageCount - 1);
    }


    /// <summary>
    /// This function is invoked when you click on a column's header to
    /// sort by that. It just saves the current sort field name and 
    /// refreshes the grid.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void SortByColumn(Object sender, DataGridSortCommandEventArgs e)
    {
        String strSortBy = DataGridList.Attributes["SortField"];
        String strSortAscending = DataGridList.Attributes["SortAscending"];

        // Sets the new sorting field
        DataGridList.Attributes["SortField"] = e.SortExpression;

        // Sets the order (defaults to ascending). If you click on the
        // sorted column, the order reverts.
        DataGridList.Attributes["SortAscending"] = "yes";
        if (e.SortExpression == strSortBy)
            DataGridList.Attributes["SortAscending"] = (strSortAscending == "yes" ? "no" : "yes");

        // Refreshes the view
        OnClearSelection(null, null);
        UpdateDataView();
    }


    /// <summary>
    /// The function gets invoked when a new item is being created in 
    /// the datagrid. This applies to pager, header, footer, regular 
    /// and alternating items. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void PageItemCreated(Object sender, DataGridItemEventArgs e)
    {
        // Get the newly created item
        ListItemType itemType = e.Item.ItemType;

        //////////////////////////////////////////////////////////
        // Is it the HEADER?
        if (itemType == ListItemType.Header)
        {
            for (int i = 0; i < DataGridList.Columns.Count; i++)
            {
                // draw to reflect sorting
                if (DataGridList.Attributes["SortField"] == DataGridList.Columns[i].SortExpression)
                {
                    //////////////////////////////////////////////
                    // Should be much easier this way:
                    // ------------------------------------------
                    // TableCell cell = e.Item.Cells[i];
                    // Label lblSorted = new Label();
                    // lblSorted.Font = "webdings";
                    // lblSorted.Text = strOrder;
                    // cell.Controls.Add(lblSorted);
                    //
                    // but it seems it doesn't work <g>
                    //////////////////////////////////////////////

                    // Add a non-clickable triangle to mean desc or asc.
                    // The </a> ensures that what follows is non-clickable
                    TableCell cell = e.Item.Cells[i];
                    LinkButton lb = (LinkButton)cell.Controls[0];
                    //lb.Text += "</a>&nbsp;<span style=font-family:webdings;>" + GetOrderSymbol() + "</span>";
                    lb.Text += "</a>&nbsp;<img src=" + Request.ApplicationPath + "/images/icons/" + GetOrderSymbol() + " >";
                }
            }
        }


        //////////////////////////////////////////////////////////
        // Is it the PAGER?
        if (itemType == ListItemType.Pager)
        {
            // There's just one control in the list...
            TableCell pager = (TableCell)e.Item.Controls[0];

            // Enumerates all the items in the pager...
            for (int i = 0; i < pager.Controls.Count; i += 2)
            {
                // It can be either a Label or a Link button
                try
                {
                    Label l = (Label)pager.Controls[i];
                    l.Text = "Hal " + l.Text;
                    l.CssClass = "CurrentPage";
                }
                catch
                {
                    LinkButton h = (LinkButton)pager.Controls[i];
                    h.Text = "[ " + h.Text + " ]";
                    h.CssClass = "HotLink";
                }
            }
        }
    }

    /// <summary>
    /// Verifies whether the current sort is ascending or descending and 
    /// returns an appropriate display text (i.e., a webding)
    /// </summary>
    /// <returns></returns>
    private String GetOrderSymbol()
    {
        bool bDescending = (bool)(DataGridList.Attributes["SortAscending"] == "no");
        //return (bDescending ? " 6" : " 5");
        return (bDescending ? "downbr.gif" : "upbr.gif");
    }

    /// <summary>
    /// When clicked clears the current selection if any 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnClearSelection(Object sender, EventArgs e)
    {
        DataGridList.SelectedIndex = -1;
    }


    #endregion

    #region .Event Button

    /// <summary>
    /// When clicked, redirect to form add for inserts a new record to the database 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnNewRecord(Object sender, EventArgs e)
    {
        string CurrentPage = DataGridList.CurrentPageIndex.ToString();
        Response.Redirect("Add.aspx?CurrentPage=" + CurrentPage);
    }


    /// <summary>
    /// When clicked, filter data.  
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnSearch(Object sender, System.EventArgs e)
    {
        if ((Session[dsReportSessionName] == null))
        {
            DataFromSourceToMemory(dsReportSessionName);
        }
        DataSet ds = (DataSet)Session[dsReportSessionName];
        DataView dv = ds.Tables[0].DefaultView;
        if (cmbFilterBy.Items[cmbFilterBy.SelectedIndex].Value == "Kode")
            dv.RowFilter = " Kode LIKE '%" + txtSearch.Text + "%'";
        else if (cmbFilterBy.Items[cmbFilterBy.SelectedIndex].Value == "Nama")
            dv.RowFilter = " Nama LIKE '%" + txtSearch.Text + "%'";
        else if (cmbFilterBy.Items[cmbFilterBy.SelectedIndex].Value == "Keterangan")
            dv.RowFilter = " Keterangan LIKE '%" + txtSearch.Text + "%'";
        else
            dv.RowFilter = "";

        BindData(dv);
    }

    #endregion

    #region .Update Link Item Butom
    /// <summary>
    /// The function is responsible for get link button form.
    /// </summary>
    /// <param name="szId"></param>
    /// <param name="CurrentPage"></param>
    /// <returns></returns>
    public string GetLinkButton(string Id, string Nama, string CurrentPage)
    {
        string szResult = "";
        if (Session["KelasManagement"] != null)
        {
            szResult += "<a class=\"toolbar\" href=\"Edit.aspx?CurrentPage=" + CurrentPage + "&Id=" + Id + "\" ";
            szResult += ">" + Resources.GetString("", "Edit") + "</a>";
            szResult += "<a class=\"toolbar\" href=\"Delete.aspx?CurrentPage=" + CurrentPage + "&Id=" + Id + "\" ";
            szResult += ">" + Resources.GetString("", "Delete") + "</a>";
        }
        return szResult;
    }
    #endregion
}
