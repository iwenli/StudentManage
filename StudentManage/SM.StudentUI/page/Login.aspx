<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SM.StudentUI.page.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>学生信息录入系统      登陆</title> 
    <link href="../css/main.css" rel="stylesheet" type="text/css" />
    <link href="../css/default.css" rel="stylesheet" type="text/css" />
     
</head>
<body  background="images/bg.jpg">
    <form id="form1" runat="server">
    <iframe src="http://www.thinkpage.cn/weather/weather.aspx?uid=&cid=101010100&l=zh-CHS&p=CMA&a=1&u=C&s=11&m=1&x=1&d=5&fc=FFFFFF&bgc=C6C6C6&bc=C6C6C6&ti=1&in=1&li=2&ct=iframe" frameborder="0" scrolling="no" width="200" height="630" allowTransparency="true"></iframe>
    <x:PageManager ID="PageManager1" runat="server" />
    <br />
    <br />
    <x:Window ID="Window1" runat="server" Title="学生登陆" IsModal="false" EnableClose="false"
        WindowPosition="GoldenSection" Width="350px">
        <Items>
            <x:SimpleForm ID="SimpleForm1" runat="server" ShowBorder="false" BodyPadding="10px"
                LabelWidth="60px" EnableBackgroundColor="true" ShowHeader="false">
                <Items>
                    <x:NumberBox  ID="tbxUserName" Label="学&nbsp;&nbsp;&nbsp;号" Required="true" ShowRedStar="true" 
                        runat="server" DecimalPrecision="0" FocusOnPageLoad="True" MaxLength="8"  MinLength="8"
                         NextFocusControl="tbxPassword" 
                        ShowEmptyLabel="True" OnTextChanged="btmEnabled" AutoPostBack="true" EmptyText="点击输入学号"> </x:NumberBox>
                    <x:TextBox ID="tbxPassword" Label="密&nbsp;&nbsp;&nbsp;码" TextMode="Password" Required="true" 
                        ShowRedStar="true" runat="server" NextFocusControl="tbxCaptcha" OnTextChanged="btmEnabled" AutoPostBack="true" MaxLength="18" MinLength="6">
                    </x:TextBox>
                    <x:TextBox ID="tbxCaptcha" Label="验证码" Required="true" ShowRedStar="true" 
                        runat="server" EmptyText="输入下图的验证码（不区分大小写）" MaxLength="6" MinLength="6" 
                        NextFocusControl="btnLogin" OnTextChanged="btmEnabled" AutoPostBack="true">
                    </x:TextBox>
                    <x:Panel ID="Panel1" CssStyle="padding-left:65px;" ShowBorder="false" ShowHeader="false" EnableBackgroundColor="true"
                        runat="server">
                        <Items>
                            <x:Image ID="Image1" CssStyle="float:left;width:160px;" runat="server"  ImageUrl="" ShowEmptyLabel="true">
                            </x:Image>
                            <x:LinkButton CssStyle="float:left;padding-top:8px;" ID="btnRefresh" Text="看不清？" ToolTip="点击更改验证码" runat="server" OnClick="btnRefresh_Click">
                            </x:LinkButton>
                        </Items>
                      </x:Panel>
                </Items>
            </x:SimpleForm>
        </Items>
                    <Toolbars>
                        <x:Toolbar ID="Toolbar1" runat="server" Position="Footer">
                            <Items>
                                <x:Button ID="btnLogin" Text="登 录" Type="Submit" Size="Medium" Icon="User"  CssClass="inline" ValidateForms="SimpleForm1" ValidateTarget="Top" runat="server" Enabled="false" OnClick="btnLogin_Click"> </x:Button>
                                <x:Button ID="btnFindPwd" Text="找回密码" Type="Submit"  Size="Medium" ValidateForms="null"    ValidateTarget="Top" runat="server" CssClass="inline" EnablePostBack="False" Icon="ZoomIn" IconAlign="Right"> </x:Button>
                            </Items>
                        </x:Toolbar>
                    </Toolbars>
    </x:Window>
    <x:Window ID="Window2" IconUrl="images/16/10.png" runat="server" Popup="false"
        WindowPosition="GoldenSection" IsModal="true" Title="找回密码" EnableMaximize="False"
        EnableResize="False" Target="Self" EnableIFrame="true" IFrameUrl="about:blank"
        Height="280px" Width="350px"></x:Window>
    </form>
</body>
</html>
