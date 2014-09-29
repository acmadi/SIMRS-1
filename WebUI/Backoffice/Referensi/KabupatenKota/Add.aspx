<%@ Page Language="C#" MasterPageFile="~/Backoffice/Backoffice.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Backoffice_Referensi_KabupatenKota_Add" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="adminheading" id="Table3">
		<tr>
			<th class="menudottedline">
				<%= Resources.GetString("Referensi","TitleAddKabupatenKota") %>
			</th>
			<td class="menudottedline" align="right">&nbsp;
			</td>
		</tr>
	</table>
	<table class="adminform" id="Table1" border="0">
		<tr>
			<td colspan="2"><asp:label id="lblError" runat="server" ForeColor="Red"></asp:label><asp:validationsummary id="ValidationSummary1" runat="server" HeaderText="Tanda * harus diisi atau dipilih!"
					DisplayMode="SingleParagraph"></asp:validationsummary></td>
		</tr>
		<tr>
			<td class="text">Propinsi</td>
			<td><asp:dropdownlist id="cmbPropinsi" OnSelectedIndexChanged="OnPropinsiChanged" runat="server" AutoPostBack="True"></asp:dropdownlist><asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" ControlToValidate="cmbPropinsi">*</asp:requiredfieldvalidator></td>
		</tr>
		<tr>
			<td class="text">Kode
				<asp:textbox id="txtId" runat="server" Visible="False" ReadOnly="True" Width="8px" MaxLength="2"></asp:textbox>
				<asp:textbox id="txtKode" runat="server" MaxLength="50" Width="16px" Visible="False"></asp:textbox></td>
			<td><input onkeypress="CheckInteger()" id="txtKodeProp" style="WIDTH: 32px; HEIGHT: 22px; TEXT-ALIGN: left"
					type="text" maxLength="2" size="1" name="txtKodeProp" runat="server" disabled>.<input onkeypress="CheckInteger()" id="txtKodeKab" style="WIDTH: 32px; HEIGHT: 22px; TEXT-ALIGN: left"
					type="text" maxLength="2" size="1" name="txtKodeKab" runat="server"><asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" ControlToValidate="txtKodeKab">*</asp:requiredfieldvalidator></td>
		</tr>
		<tr>
			<td class="text">Nama</td>
			<td><asp:textbox id="txtNama" runat="server" Width="350px" MaxLength="50"></asp:textbox><asp:requiredfieldvalidator id="RequiredFieldValidator2" runat="server" ControlToValidate="txtNama">*</asp:requiredfieldvalidator></td>
		</tr>
		<tr>
			<td class="text">Keterangan</td>
			<td><asp:textbox id="txtKeterangan" runat="server" Width="350px" MaxLength="50" TextMode="MultiLine"></asp:textbox></td>
		</tr>
		<tr>
			<td style="HEIGHT: 20px" width="150">Aktif</td>
			<td style="HEIGHT: 20px"><asp:radiobutton id="rbtYes" runat="server" Checked="True" Text="Ya" GroupName="Published"></asp:radiobutton><asp:radiobutton id="rbtNo" runat="server" Text="Tidak" GroupName="Published"></asp:radiobutton></td>
		</tr>
		<tr>
			<td class="text">Urutan</td>
			<td></td>
		</tr>
	</table>
	<table class="adminheading" id="Table2">
		<tr>
			<td class="menudottedline" width="150">&nbsp;</td>
			<td class="menudottedline" align="left" width="50">
				<div class="toolbar" onmouseover="MM_swapImage('save','','../../../images/save_f2.gif',1);"
					onmouseout="MM_swapImgRestore();"><asp:linkbutton id="btnSave" onclick="OnSave" runat="server"></asp:linkbutton></div>
			</td>
			<td class="menudottedline" align="left" width="50">
				<div class="toolbar" onmouseover="MM_swapImage('cancel','','../../../images/cancel_f2.gif',1);"
					onmouseout="MM_swapImgRestore();"><asp:linkbutton id="btnCancel" onclick="OnCancel" runat="server" CausesValidation="False"></asp:linkbutton></div>
			</td>
			<td class="menudottedline">&nbsp;</td>
		</tr>
	</table>
</asp:Content>

