<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadPage.aspx.cs" Inherits="ExcelUploadDemo.FileUploadPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fileUploadTemplate" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="optStudent" runat="server" Checked="True" GroupName="uploadType" Text="Student" />
            <asp:RadioButton ID="optPI" runat="server" GroupName="uploadType" Text="Principal Investigator" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
            <br />
            <asp:RegularExpressionValidator  ID="validateTemplate" runat="server" ErrorMessage="Only .xls format is allowed" ControlToValidate="fileUploadTemplate" ValidationExpression="^.*\.(xls|xlsx|csv)$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="69px" TextMode="MultiLine" Width="225px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
