<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindPwd.aspx.cs" Inherits="SM.StudentUI.page.FindPwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>找回密码</title>
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
                    <x:ToolbarText ID="ToolbarText1" Text="温情提示：当学号、姓名、身份证号一致方可找回密码" CssClass="red" runat="server">
                    </x:ToolbarText>
                
                </Items>
            </x:Toolbar>
        </Toolbars>
        
        <Items>
            <x:Panel ID="Panel2" Layout="Fit" runat="server" ShowBorder="false" ShowHeader="false" HideMode="Offsets">
                <Items>
                     <x:GroupPanel runat="server"  CssClass="top" Title="第一步：正确填写以下信息找回您的密码" ID="GroupPanel1"                                      EnableCollapse="false">
                        <Items>
                            <x:SimpleForm ID="SimpleForm1" LabelAlign="Left" LabelWidth="70px" runat="server"                                                       EnableBackgroundColor="false" ShowBorder="False"
                                ShowHeader="False">
                                <Items>
                                    <x:NumberBox  ID="tbxStuId" Label="学&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号" Required="true" ShowRedStar="true" runat="server" DecimalPrecision="0" FocusOnPageLoad="True"  MinLength="8" MaxLength="8"  NextFocusControl="tbxStuName"  ShowEmptyLabel="True" AutoPostBack="true"  EmptyText="此处输入学号"> 
                                    </x:NumberBox>
                                    <x:TextBox ID="tbxStuName" Label="姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名" ShowRedStar="true" runat="server" CompareType="String" AutoPostBack="True" EmptyText="此处输入入学时所用姓名" NextFocusControl="tbxStuIdDate" Required="true" OnTextChanged="tbx_Event">
                                    </x:TextBox>
                                    <x:TextBox ID="tbxStuIdDate" Label="身份证号" ShowRedStar="true" runat="server" EmptyText="此处输入二代身份证号" Regex="\d{17}[\d|X]|\d{18}" AutoPostBack="True" Required="true" NextFocusControl="tbxCaptcha" OnTextChanged="tbx_Event">
                                    </x:TextBox>
                                    <x:TextBox ID="tbxCaptcha" Label="验&nbsp;证&nbsp;码" Required="true" ShowRedStar="true" runat="server" EmptyText="此处输入下图的验证码（不区分大小写）" MaxLength="6" MinLength="6"   NextFocusControl="btnFindPwd"  AutoPostBack="true" OnTextChanged="tbx_Event">
                                    </x:TextBox>
                               
                                    <x:Panel ID="Panel3" CssStyle="padding-left:75px;" ShowBorder="false" ShowHeader="false" EnableBackgroundColor="false"
                        runat="server">
                        <Items>
                                     <x:Image ID="Image1" ToolTip="验证码"  CssStyle="float:left;width:140px" runat="server"  ImageUrl="" ShowEmptyLabel="true">
                                    </x:Image>
                            <x:LinkButton ToolTip="单击切换验证码" CssStyle="float:left;padding-top:10px;" ID="btnRefresh" Text="看不清?" runat="server" OnClick="btnRefresh_Click">
                            </x:LinkButton>
                            </Items>
                      </x:Panel>

                                    <x:Button ID="btnFindPwd" runat="server"  Text="点击此处找回密码"  CssClass="inline" OnClick="findPwd_click" Icon="NewRed" ValidateForms="SimpleForm1" CssStyle="padding-top:14px;" FocusOnPageLoad="True"  Enabled="false"> </x:Button>
                                </Items> 
                            </x:SimpleForm>
                        </Items>
                    </x:GroupPanel>
                    <x:GroupPanel ID="GroupPanel2" EnableBackgroundColor="false" CssClass="top" AutoHeight="true" Title="第二步：请设定您新的密码"
                            runat="server" EnableCollapse="false" Height="195">
                        <Items>
                           <x:SimpleForm ID="SimpleForm2" LabelAlign="Left" LabelWidth="60px" runat="server"                                                       EnableBackgroundColor="false" ShowBorder="False" ShowHeader="False">
                                        <Items>
                                        <x:Label ID="labTitle" Text="请输入6~18位的新密码:" CssClass="red" runat="server"></x:Label>
                                            <x:TextBox ID="tbxStuNewPwd" Label="新密码" ShowRedStar="true" runat="server"  MaxLength="18" MinLength="6" TextMode="Password" Required="true" NextFocusControl="tbxStuPwdSure"  AutoPostBack="true" OnTextChanged="tbx_Event">
                                            </x:TextBox>

                                             <x:TextBox ID="tbxStuPwdSure" Label="确&nbsp;&nbsp;&nbsp;认" ShowRedStar="true" runat="server" TextMode="Password" Required="true"  NextFocusControl="btnSubmit" CompareControl="tbxStuNewPwd" ShowEmptyLabel="False"> 
                                            </x:TextBox>

                                            <x:Button ID="btnSubmit" runat="server"  Text="提交"  CssClass="inline"   Icon="NoteGo" ValidateForms="SimpleForm2" CssStyle="padding-top:14px;" OnClick="btnSubmint_click"> </x:Button>
                                        </Items> 
                           </x:SimpleForm>
                        </Items>
                    </x:GroupPanel>
                    <x:GroupPanel ID="GroupPanel3" EnableBackgroundColor="false" AutoHeight="true" Title="密码找回结果："
                            runat="server" EnableCollapse="false"  CssClass="top" Height="180" >
                        <Items>
                        <x:Label ID="labResult" Text="" CssClass="red" runat="server" Readonly="True"></x:Label>
                            <x:Image ID="Image2" runat="server"></x:Image>
                            <x:LinkButton ToolTip="关闭" CssStyle="float:left;padding-top:10px;" ID="LinkButtonExit" Text="【关闭】" runat="server"></x:LinkButton>
                         </Items>
                    </x:GroupPanel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>

    </form>
</body>
</html>
