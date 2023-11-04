<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ASP_DotNet.Validator" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Validation Form</h1>
        <div>
            <label for="txtName">Name:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged">Enter a name</asp:TextBox>
        </div>
        <div>
            <label for="txtFamilyName">Family Name:&nbsp;&nbsp;&nbsp; </label>&nbsp;<asp:TextBox ID="txtFamilyName" runat="server">enter family name</asp:TextBox>
        </div>
        <div>
            <label for="txtAddress">Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>&nbsp;
            <asp:TextBox ID="txtAddress" runat="server">enter valid address</asp:TextBox>
        </div>
        <div>
            <label for="txtCity">City:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server">enter city</asp:TextBox>
        </div>
        <div>
            <label for="txtZipCode">Zip Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>&nbsp;<asp:TextBox ID="txtZipCode" runat="server">enter zipcode</asp:TextBox>
        </div>
        <div>
            <label for="txtPhone">Phone:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPhone" runat="server">enter numbers</asp:TextBox>
        </div>
        <div>
            <label for="txtEmail">Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>&nbsp;<asp:TextBox ID="txtEmail" runat="server">enter valid email</asp:TextBox>
            <br />
        </div>
        <div>
            &nbsp;<asp:Button ID="btnCheck" runat="server" Text="Check" OnClick="btnCheck_Click" />
        </div>
    </form>
</body>
</html>