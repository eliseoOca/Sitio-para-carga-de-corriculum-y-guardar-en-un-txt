<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargaDeCVyLEER.aspx.cs" Inherits="Sitio_para_carga_de_corriculum_y_guardar_en_un_txt.CargaDeCVyLEER" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 109px; width: 138px">
            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
            <asp:TextBox ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>
            <asp:TextBox ID="txtExperiencia" runat="server" placeholder="Experiancia Laboral" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="btnGuardar" runat="server" Text="Button" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>
