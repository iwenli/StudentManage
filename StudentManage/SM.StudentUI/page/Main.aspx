<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="SM.StudentUI.Main" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>学生信息管理平台  1.0</title>

    <meta name="Title" content="学生信息管理平台" />
    <meta name="Description" content="学生信息管理平台" />
    <meta name="Keywords" content="学生信息管理平台" />
    <link href="../css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" AutoSizePanelID="RegionPanel1" runat="server"></x:PageManager>
    <x:RegionPanel ID="RegionPanel1" ShowBorder="false" runat="server">
        <Regions>
            <x:Region ID="Region1" Margins="0 0 0 0" ShowBorder="false" Height="50px" ShowHeader="false"
                Position="Top" Layout="Fit" runat="server">
                <Items>
                    <x:ContentPanel ShowBorder="false" CssClass="jumbotron" ShowHeader="false" ID="ContentPanel1"
                        runat="server">
                        <div class="title">
                            <a href="#" title="学生信息管理平台  当前版本1.0" class="logo"><img src="./images/logo/logo2.gif" alt="UI Logo"/></a>
                            &nbsp;<a href="#" title="天津商业大学高职学院学生信息管理平台" style="color:#fff;">学生信息管理平台  1.0  </a>
                        </div>
						<div class="version">
                            <a href="javascript:window.external.addFavorite('http://www.234486036.com','学生信息管理平台')" title="收藏"  style="color:#fff;" >添加收藏夹</a>
                        </div>
                        <div class="dateLable"><% =logoShow %>
                         
                        </div>
                    </x:ContentPanel>
                </Items>
            </x:Region>
            <x:Region ID="Region2" Split="true" EnableSplitTip="true" CollapseMode="Mini" Width="200px"
                Margins="0 0 0 0" ShowHeader="false" Title="菜单" EnableLargeHeader="false" Icon="Outline"
                EnableCollapse="true" Layout="Fit" Position="Left" runat="server">
                <Toolbars>
                    <x:Toolbar ID="Toolbar1" Position="Top" runat="server">
                        <Items>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Button ID="Button2" EnablePostBack="false" Icon="Cog" runat="server">
                                <Menu ID="Menu1" runat="server">
                                    <x:MenuButton ID="btnExpandAll" IconUrl="images/expand-all.gif" Text="展开菜单" EnablePostBack="false"
                                        runat="server">
                                    </x:MenuButton>
                                    <x:MenuButton ID="btnCollapseAll" IconUrl="images/collapse-all.gif" Text="折叠菜单"
                                        EnablePostBack="false" runat="server">
                                    </x:MenuButton>
                                    <x:MenuSeparator runat="server">
                                    </x:MenuSeparator>
                                    <x:MenuButton ID="MenuStyle" EnablePostBack="false" Text="菜单样式" runat="server">
                                        <Menu ID="Menu3" runat="server">
                                            <x:MenuCheckBox Text="树菜单" ID="MenuStyleTree" Checked="true" GroupName="MenuStyle"
                                                AutoPostBack="true" OnCheckedChanged="MenuStyle_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                            <x:MenuCheckBox Text="手风琴+树菜单" ID="MenuStyleAccordion" GroupName="MenuStyle" AutoPostBack="true"
                                                OnCheckedChanged="MenuStyle_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                        </Menu>
                                    </x:MenuButton>
                                    <x:MenuButton ID="MenuLang"  EnablePostBack="false" Text="语言" runat="server">
                                        <Menu runat="server">
                                            <x:MenuCheckBox Text="简体中文" ID="MenuLangZHCN" Checked="true" GroupName="MenuLang" AutoPostBack="true" OnCheckedChanged="MenuLang_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                            <x:MenuCheckBox Text="English" ID="MenuLangEN" GroupName="MenuLang" AutoPostBack="true" OnCheckedChanged="MenuLang_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                        </Menu>
                                    </x:MenuButton>
                                    <x:MenuButton ID="MenuTheme" EnablePostBack="false" Text="主题" runat="server">
                                        <Menu ID="Menu2" runat="server">
                                            <x:MenuCheckBox Text="Blue" ID="MenuThemeBlue" Checked="true" GroupName="MenuTheme"
                                                AutoPostBack="true" OnCheckedChanged="MenuTheme_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                            <x:MenuCheckBox Text="Gray" ID="MenuThemeGray" GroupName="MenuTheme" AutoPostBack="true"
                                                OnCheckedChanged="MenuTheme_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                            <x:MenuCheckBox Text="Access" ID="MenuThemeAccess" GroupName="MenuTheme" AutoPostBack="true" OnCheckedChanged="MenuTheme_CheckedChanged" runat="server">
                                            </x:MenuCheckBox>
                                        </Menu>
                                    </x:MenuButton>
                                </Menu>
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                </Toolbars>
            </x:Region>
            <x:Region ID="mainRegion" ShowHeader="false" Layout="Fit" Margins="0 0 0 0" Position="Center"
                runat="server">
                <Items>
                    <x:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                        <Tabs>
                            <x:Tab Title="首页" Layout="Fit" Icon="House" runat="server">
                                <Toolbars>
                                    <x:Toolbar runat="server">
                                        <Items>
                                            <x:ToolbarFill ID="ToolbarFill2" runat="server">
                                            </x:ToolbarFill>
                                            <x:Button ID="btnChangePwd" Icon="Key" Text="修改密码" EnablePostBack="false"
                                                runat="server">
                                            </x:Button>
                                           
                                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                                            </x:ToolbarSeparator>
                                            <x:Button ID="btnGotoOpenSourceSite" Icon="Help" Text="帮助" OnClientClick="window.open('help.htm', '_blank');"
                                                EnablePostBack="false" runat="server">
                                            </x:Button>
                                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                                            </x:ToolbarSeparator>
                                            <x:Button ID="Button1" Icon="TabGo" Text="退出登录" OnClick="exit_System"
                                             runat="server" EnableAjaxLoading="False" EnableAjax="False">
                                            </x:Button>
                                        </Items>
                                    </x:Toolbar>
                                </Toolbars>
                                <Items>
                                    <x:ContentPanel ShowBorder="false" BodyPadding="10px" ShowHeader="false" AutoScroll="true"
                                        CssClass="intro" runat="server">
                                        
                                        <h2>1</h2>
                                           1111111111111111
                                        <br />
                                        <br />
                                        <h2>2</h2>
                                           222222222222222222222222222222222222
                                        <br />
                                        <br />
                                        <h2>3</h2>
                                           333333333333333333333333333333333333333
                                        <br />
                                        <br />
                                        <h2>4</h2>
                                           4444444444444444444444444444444444
                                        <br />
                                        <br />
                                        <h2>5</h2>
                                            论坛：<a target="_blank" style="font-weight:bold;" href="http://fineui.com/bbs/">http://fineui.com/bbs/</a>
                                        <br />
                                            示例：<a target="_blank" href="http://fineui.com/demo/">http://fineui.com/demo/</a>
                                        <br />
                                            文档：<a target="_blank" href="http://fineui.com/doc/">http://fineui.com/doc/</a>
                                        <br />
                                            下载：<a target="_blank" href="http://fineui.codeplex.com/">http://fineui.codeplex.com/</a>
                                        <br />
                                        
                                        
                                    </x:ContentPanel>
                                </Items>
                            </x:Tab>
                        </Tabs>
                    </x:TabStrip>
                </Items>
            </x:Region>
        </Regions>
    </x:RegionPanel>
    <x:Window ID="windowSourceCode" Title="修改密码" Popup="false" runat="server" WindowPosition="GoldenSection" IsModal="true" EnableMaximize="False" EnableResize="False" Target="Self" EnableIFrame="true" IFrameUrl="about:blank" Height="290px" Width="380px" Icon="Key">
    </x:Window>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="common/menu.xml"></asp:XmlDataSource>
     <iframe id="logo" title="技术支持：天商科技 给您准确预报天气" src="http://www.thinkpage.cn/weather/weather.aspx?uid=&cid=101010100&l=zh-CHS&p=CMA&a=1&u=C&s=4&m=1&x=1&d=1&fc=2E93D9&bgc=&bc=&ti=1&in=1&li=2&ct=iframe" frameborder="0" scrolling="no" width="900" height="27" allowTransparency="true"></iframe>
   <img src="images/logo/1.png" alt="版权信息" id="logo" title="技术支持：天商科技"/>
    <script src="js/default.js" type="text/javascript"></script>
    </form>
        
</body>
</html>
