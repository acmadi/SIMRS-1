<%@ Page Language="C#" MasterPageFile="~/Backoffice/Backoffice.master" AutoEventWireup="true" CodeFile="AddTM.aspx.cs" Inherits="Backoffice_Tarif_AddTM" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" language="javascript" src="../../js/inputFormatNo.js"></script>
    <table class="adminheading" id="Table3">
		<tr>
			<th class="menudottedline">
				Tambah Layanan & Tarif Tindakan Medis
			</th>
			<td class="menudottedline" align="right">&nbsp;
			</td>
		</tr>
	</table>
	<table class="adminform" id="Table1" border="0">
		<tr>
			<td colspan="2">
				<asp:Label id="lblError" runat="server" ForeColor="Red"></asp:Label>
				<asp:ValidationSummary id="ValidationSummary1" runat="server" DisplayMode="SingleParagraph" HeaderText="Tanda * harus diisi atau dipilih!"></asp:ValidationSummary></td>
		</tr>
		<tr>
			<td class="text">Kelompok</td>
			<td>
                <asp:DropDownList ID="cmbKelompokLayanan" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ControlToValidate="cmbKelompokLayanan">*</asp:RequiredFieldValidator></td>
		</tr>
		<tr>
            <td class="text">
                Kode<asp:TextBox id="txtId" runat="server" MaxLength="2" Width="8px" ReadOnly="True" Visible="False"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtKode" runat="server" MaxLength="50" Width="161px"></asp:TextBox></td>
        </tr>
		<tr>
			<td class="text">Nama Layanan</td>
			<td>
				<asp:TextBox id="txtNama" runat="server" MaxLength="50" Width="350px"></asp:TextBox>&nbsp;
				<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="txtNama">*</asp:RequiredFieldValidator></td>
		</tr>
        <tr>
            <td class="text">
                Kelas III</td>
            <td>
                <input id="txtTarifIII" onkeypress="CheckInteger()" onblur="FormatAsNumber(this)" onfocus="FormatAsDecimal(this)"  runat="server" maxlength="20" name="txtTarif" style="width: 165px; text-align: right;" type="text" />&nbsp;
				</td>
        </tr>
        <tr>
            <td class="text">
                Kelas II</td>
            <td>
                <input id="txtTarifII" onkeypress="CheckInteger()" onblur="FormatAsNumber(this)" onfocus="FormatAsDecimal(this)"  runat="server" maxlength="20" name="txtTarif" style="width: 165px; text-align: right;" type="text" />&nbsp;
				</td>
        </tr>
        <tr>
            <td class="text">
                Kelas I</td>
            <td>
                <input id="txtTarifI" onkeypress="CheckInteger()" onblur="FormatAsNumber(this)" onfocus="FormatAsDecimal(this)"  runat="server" maxlength="20" name="txtTarif" style="width: 165px; text-align: right;" type="text" />&nbsp;
				</td>
        </tr>
        <tr>
            <td class="text">
                Kelas VIP</td>
            <td>
                <input id="txtTarifVIP" onkeypress="CheckInteger()" onblur="FormatAsNumber(this)" onfocus="FormatAsDecimal(this)"  runat="server" maxlength="20" name="txtTarif" style="width: 165px; text-align: right;" type="text" />&nbsp;
				</td>
        </tr>
        <tr>
            <td class="text">
                Kelas VVIP</td>
            <td>
                <input id="txtTarifVVIP" onkeypress="CheckInteger()" onblur="FormatAsNumber(this)" onfocus="FormatAsDecimal(this)"  runat="server" maxlength="20" name="txtTarif" style="width: 165px; text-align: right;" type="text" />&nbsp;
				</td>
        </tr>
		<tr>
			<td class="text">Keterangan</td>
			<td>
				<asp:TextBox id="txtKeterangan" runat="server" Width="350px" MaxLength="50" TextMode="MultiLine"></asp:TextBox></td>
		</tr>
	</table>
	<table class="adminheading" id="Table2">
		<tr>
			<td width="150px" class="menudottedline">
				&nbsp;</td>
			<td width="50px" class="menudottedline" align="left">
				<div class="toolbar" onmouseover="MM_swapImage('save','','../../../images/save_f2.gif',1);"
					onmouseout="MM_swapImgRestore();">
					<asp:linkbutton id="btnSave" OnClick="OnSave" runat="server"></asp:linkbutton></div>
			</td>
			<td width="50" class="menudottedline" align="left">
				<div class="toolbar" onmouseover="MM_swapImage('cancel','','../../../images/cancel_f2.gif',1);"
					onmouseout="MM_swapImgRestore();"><asp:linkbutton id="btnCancel" OnClick="OnCancel" runat="server" CausesValidation="False"></asp:linkbutton></div>
			</td>
			<td class="menudottedline">&nbsp;</td>
		</tr>
	</table>
</asp:Content>

