<%@ Page Language="C#" MasterPageFile="~/Backoffice/Backoffice.master" AutoEventWireup="true" CodeFile="RIEditRegistrasi.aspx.cs" Inherits="Backoffice_Registrasi_RIEditRegistrasi" Title="Untitled Page" %>

<%@ Register Src="../Controls/EditRegistrasiRI.ascx" TagName="EditRegistrasiRI" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1"  EnableScriptGlobalization="true" EnableScriptLocalization="true" runat="server">
    </asp:ScriptManager>
    <table class="adminheading" width="100%" id="Table3">
        <tr>
            <th class="menudottedline">
                Edit Data Kunjungan Pasien Rawat Inap 
            </th>
            <td class="menudottedline" align="right">&nbsp;
            </td>
        </tr>
    </table>
    <uc1:EditRegistrasiRI ID="EditRegistrasiRI1" runat="server" />
    <table class="adminheading" width="100%">
	    <tr>
		    <td style="width: 150px" class="menudottedline">
			    &nbsp;</td>
		    <td style="width:50px" class="menudottedline">
                <asp:ImageButton ID="btnSave" ImageUrl="~/images/save_f2.gif" runat="server" OnClick="btnSave_Click" />
		    </td>
		    <td style="width:50px" class="menudottedline">
                <asp:ImageButton ID="btnCancel" ImageUrl="~/images/cancel_f2.gif" runat="server" CausesValidation="False" OnClick="btnCancel_Click" />
		    </td>
		    <td class="menudottedline">&nbsp;</td>
	    </tr>
    </table> 
</asp:Content>

