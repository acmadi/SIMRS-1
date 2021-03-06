<%@ Page Language="C#" MasterPageFile="~/Backoffice/Backoffice.master" AutoEventWireup="true" CodeFile="LABView.aspx.cs" Inherits="Backoffice_Registrasi_LABView" Title="Untitled Page" %>
<%@ Register Src="../Controls/HeaderRJ.ascx" TagName="HeaderRJ" TagPrefix="uc5" %>
<%@ Register Src="../Controls/ViewRegistrasiLAB.ascx" TagName="ViewRegistrasiLAB" TagPrefix="uc2" %>
<%@ Register Src="../Controls/ViewDataUmum.ascx" TagName="ViewDataUmum" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Src="../Controls/ViewRekamMedisLAB.ascx" TagName="ViewRekamMedisLAB" TagPrefix="uc3" %>
<%@ Register Src="../Controls/ViewKuitansiLAB.ascx" TagName="ViewKuitansiLAB" TagPrefix="uc6" %>
<%@ Register Src="../Controls/ViewKasirLAB.ascx" TagName="ViewKasirLAB" TagPrefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true" EnableScriptLocalization="true">
    </asp:ScriptManager>
    <script language="javascript" type="text/javascript" src="../../js/Popup.js"></script>
    <asp:HiddenField ID="HFStatusRawatJalan" runat="server" />
    <asp:HiddenField ID="HFRegistrasiId" runat="server" />
    <asp:HiddenField ID="HFRawatJalanId" runat="server" />
    <asp:HiddenField ID="HFPasienId" runat="server" />
    <table class="adminheading">
	    <tr>
		    <th class="menudottedline">
		        Data Pasien Labroratorium 
		    </th>
		    <th style="width:50px;text-align:center" class="menudottedline">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="Middle" ImageUrl="~/images/icons/find.gif" OnClick="ImageButton1_Click" CausesValidation="False" />
		    </th>
	    </tr>
    </table>
    <uc5:HeaderRJ ID="HeaderRJ1" runat="server" />
    <ajaxToolkit:TabContainer ID="TabPasien" runat="server" ActiveTabIndex="1">
        <ajaxToolkit:TabPanel ID="TabUmum" runat="server" HeaderText="">
            <HeaderTemplate>
                <%= Resources.GetString("RS", "TabUmunLAB")%>
            </HeaderTemplate>
            <ContentTemplate>
                <uc1:ViewDataUmum ID="UCViewDataUmum" runat="server" />
                <hr />
                <a href="javascript:void(0)" class="button" visible="False" onclick="" id="btnIdentitasPasien" runat="server">Print Identitas Pasien</a>
                <asp:Button ID="btnEditDataPasien" CssClass="button" runat="server" OnClick="btnEditDataPasien_Click"
                    Text="Edit Data Pasien" />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabRegistrasi" runat="server" HeaderText="">
            <HeaderTemplate>
                <%= Resources.GetString("RS", "TabRegistrasiLAB")%> 
            </HeaderTemplate>
            <ContentTemplate>
                <uc2:ViewRegistrasiLAB ID="UCViewRegistrasiLAB" runat="server" />
                <hr />
                <a href="javascript:void(0)" class="button" visible="False" onclick="" id="btnIkhtisarKunjungan" runat="server">Print Ikhtisar Kunjungan</a>
                <a href="javascript:void(0)" class="button" visible="False" onclick="" id="btnLembarKonsultasi" runat="server">Print Lembar Konsultasi</a>
                <asp:Button ID="btnEditRegistrasiLAB" runat="server" CssClass="button" OnClick="btnEditRegistrasiLAB_Click"
                    Text="Edit Data Kunjungan" />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabRM" runat="server" HeaderText="">
            <HeaderTemplate>
                <%= Resources.GetString("RS", "TabRekamMedisLAB")%>
            </HeaderTemplate>
            <ContentTemplate>
                <uc3:ViewRekamMedisLAB id="UCViewRekamMedisLAB" runat="server">
                </uc3:ViewRekamMedisLAB>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabKasir" runat="server" HeaderText="">
            <HeaderTemplate>
                <%= Resources.GetString("RS", "TabLayananLAB")%>
            </HeaderTemplate>
            <ContentTemplate>
                <uc4:ViewKasirLAB ID="UCViewKasirLAB" runat="server" />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabKuitansi" runat="server" HeaderText="">
            <HeaderTemplate>
                <%= Resources.GetString("RS", "TabKuitansiLAB")%>
            </HeaderTemplate>
            <ContentTemplate>
                <uc6:ViewKuitansiLAB ID="UCViewKuitansiLAB" runat="server" />
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
</asp:Content>

