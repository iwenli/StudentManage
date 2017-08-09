<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="SM.StudentUI.page.ChangePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改密码</title>
    <link href="../css/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />
    <x:Panel ID="Panel1" runat="server" Layout="Fit" ShowBorder="False" ShowHeader="false"
        BodyPadding="5px" EnableBackgroundColor="true">
        <Toolbars>
            <x:Toolbar ID="Toolbar1" runat="server">
                <Items>
                    <x:ToolbarText ID="ToolbarText1" Text="为了保障您的信息安全，请将密码设置为数字、字母和字符的组合" CssClass="red" runat="server">
                    </x:ToolbarText>
                
                </Items>
            </x:Toolbar>
        </Toolbars>
        
        <Items>
            <x:Panel ID="Panel2" Layout="Form" runat="server" ShowBorder="false" ShowHeader="false" HideMode="Offsets" AutoHeight="true">
                <Items>
                            <x:SimpleForm ID="SimpleForm1" LabelAlign="Left" LabelWidth="70px" runat="server"                                                       EnableBackgroundColor="false" ShowBorder="False" Title="请提供以下信息修改您的密码：" ShowHeader="true" BodyPadding="13px">
                                <Items>
                                    <x:NumberBox  ID="tbxStuId" Label="学&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号" Required="true" ShowRedStar="true" runat="server" DecimalPrecision="0" FocusOnPageLoad="True"  MinLength="8" MaxLength="8"  NextFocusControl="tbxStuOldPwd"  ShowEmptyLabel="True" AutoPostBack="true"  EmptyText="此处输入学号" OnTextChanged="tbx_Event"> 
                                    </x:NumberBox>
                                    <x:TextBox ID="tbxStuOldPwd" Label="当前密码" ShowRedStar="true" runat="server"  MaxLength="18" MinLength="6" TextMode="Password" Required="true" NextFocusControl="tbxStuNewPwd"  AutoPostBack="true" OnTextChanged="tbx_Event">
                                    </x:TextBox>
                                    <x:TextBox ID="tbxStuNewPwd" Label="新密码" ShowRedStar="true" runat="server"  MaxLength="18" MinLength="6" TextMode="Password" Required="true" NextFocusControl="tbxStuPwdSure"  AutoPostBack="true" OnTextChanged="tbx_Event">
                                    </x:TextBox>

                                    <x:TextBox ID="tbxStuPwdSure" Label="确&nbsp;&nbsp;&nbsp;认" ShowRedStar="true" runat="server" TextMode="Password" Required="true"  NextFocusControl="tbxCaptcha" CompareControl="tbxStuNewPwd" ShowEmptyLabel="False"> 
                                    </x:TextBox>
                                    <x:TextBox ID="tbxCaptcha" Label="验&nbsp;证&nbsp;码" Required="true" ShowRedStar="true" runat="server" EmptyText="此处输入下图的验证码（不区分大小写）" MaxLength="6" MinLength="6"   NextFocusControl="btnChangePwd"  AutoPostBack="true" OnTextChanged="tbx_Event">
                                    </x:TextBox>
                                    <x:Panel ID="Panel3" CssStyle="padding-left:75px;" ShowBorder="false" ShowHeader="false" EnableBackgroundColor="false" AutoHeight="true" runat="server">
                                        <Items>
                                            <x:Image ID="Image1" ToolTip="验证码"  CssStyle="float:left;width:140px" runat="server"  ImageUrl="" ShowEmptyLabel="true">
                                            </x:Image>
                                            <x:LinkButton ToolTip="单击切换验证码" CssStyle="float:left;padding-top:10px;" ID="btnRefresh" Text="看不清?" runat="server" OnClick="btnRefresh_Click">
                                            </x:LinkButton>
                                        </Items>
                                    </x:Panel>
                                    <x:Button ID="btnChangePwd" runat="server"  Text="确认修改"  CssClass="inline" OnClick="btnChangePwd_click" Icon="NewRed" ValidateForms="SimpleForm1" CssStyle="padding-top:14px;" FocusOnPageLoad="True"  Enabled="false"> 
                                    </x:Button>
                                </Items> 
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel4" Layout="Fit" runat="server" ShowBorder="false" ShowHeader="false" HideMode="Offsets" Hidden="false" EnableBackgroundColor="true" BodyPadding="30px" >
                        <Items>
                        <x:Label ID="labResult" Text="" CssClass="red" runat="server" Readonly="True"></x:Label>
                            <x:Image ID="Image2" runat="server"></x:Image>
                            <x:LinkButton ToolTip="关闭" CssStyle="float:left;padding-top:10px;" ID="LinkButtonExit" Text="【关闭】" runat="server"></x:LinkButton>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
    </form>
</body>
</html>
