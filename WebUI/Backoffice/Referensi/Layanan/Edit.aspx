<%@ Page Language="C#" MasterPageFile="~/Backoffice/Backoffice.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Backoffice_Referensi_Layanan_Edit" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="adminheading" id="Table3">
		<tr>
			<th class="menudottedline">
				<%= Resources.GetString("Referensi","TitleEditLayanan") %>
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
			<td class="text">Jenis Layanan</td>
			<td>
                <asp:DropDownList ID="cmbJenisLayanan" runat="server">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cmbJenisLayanan">*</asp:RequiredFieldValidator></td>
		</tr>
		<tr>
			<td class="text">Polikinik</td>
			<td>
                <asp:DropDownList ID="cmbPoliklinik" runat="server">
                </asp:DropDownList></td>
		</tr>
		<tr>
			<td class="text">Kelompok</td>
			<td>
                <asp:DropDownList ID="cmbKelompokLayanan" runat="server">
                </asp:DropDownList></td>
		</tr>
		<tr>
			<td class="text">Kode<asp:TextBox id="txtId" runat="server" MaxLength="2" Width="8px" ReadOnly="True" Visible="False"></asp:TextBox></td>
			<td>
				<asp:TextBox id="txtKode" runat="server" MaxLength="50" Width="350px"></asp:TextBox></td>
		</tr>
		<tr>
			<td class="text">Nama</td>
			<td>
				<asp:TextBox id="txtNama" runat="server" MaxLength="50" Width="350px"></asp:TextBox>&nbsp;
				<asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" ControlToValidate="txtNama">*</asp:RequiredFieldValidator></td>
		</tr>
		<tr>
			<td class="text">Keterangan</td>
			<td>
				<asp:TextBox id="txtKeterangan" runat="server" Width="350px" MaxLength="50" TextMode="MultiLine"></asp:TextBox></td>
		</tr>
		<tr>
			<td class="text"></td>
			<td>
                <asp:ImageButton ID="btnSave" OnClick="OnSave" runat="server" ImageUrl="~/images/save_f2.gif" />
			    <asp:ImageButton ID="btnCancel" OnClick="OnCancel" runat="server" CausesValidation="False" ImageUrl="~/images/cancel_f2.gif" />
			</td>
		</tr>
	</table>
</asp:Content>

