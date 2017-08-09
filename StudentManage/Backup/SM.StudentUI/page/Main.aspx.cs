using System;
using System.Web;
using System.Xml;
using FineUI;
using Newtonsoft.Json.Linq;
using SM.BaseControls;
using SM.Base;

namespace SM.StudentUI
{
    public partial class Main : PageBase
    {
        protected string logoShow;
        #region Page_Init
        

        protected void Page_Init(object sender, EventArgs e)
        {
            string menuType = "menu";
            HttpCookie menuCookie = Request.Cookies["MenuStyle"];
            if (menuCookie != null)
            {
                menuType = menuCookie.Value;
            }

            // 注册客户端脚本，服务器端控件ID和客户端ID的映射关系
            JObject ids = GetClientIDS(btnExpandAll, btnCollapseAll, windowSourceCode, mainTabStrip);

            if (menuType == "accordion")
            {
                Accordion accordionMenu = InitAccordionMenu();
                ids.Add("mainMenu", accordionMenu.ClientID);
                ids.Add("menuType", "accordion");
            }
            else
            {
                Tree treeMenu = InitTreeMenu();
                ids.Add("mainMenu", treeMenu.ClientID);
                ids.Add("menuType", "menu");
            }

            // 只在页面第一次加载时注册客户端用到的脚本
            if (!Page.IsPostBack)
            {
                string idsScriptStr = String.Format("window.IDS={0};", ids.ToString(Newtonsoft.Json.Formatting.None));
                PageContext.RegisterStartupScript(idsScriptStr);
            }
        }

        private Accordion InitAccordionMenu()
        {
            Accordion accordionMenu = new Accordion();
            accordionMenu.ID = "accordionMenu";
            accordionMenu.EnableFill = true;
            accordionMenu.ShowBorder = false;
            accordionMenu.ShowHeader = false;
            Region2.Items.Add(accordionMenu);


            XmlDocument xmlDoc = XmlDataSource1.GetXmlDocument();
            XmlNodeList xmlNodes = xmlDoc.SelectNodes("/Tree/TreeNode");
            foreach (XmlNode xmlNode in xmlNodes)
            {
                if (xmlNode.HasChildNodes)
                {
                    AccordionPane accordionPane = new AccordionPane();
                    accordionPane.Title = xmlNode.Attributes["Text"].Value;
                    accordionPane.Layout = Layout.Fit;
                    accordionPane.ShowBorder = false;
                    accordionPane.BodyPadding = "2px 0 0 0";
                    accordionMenu.Items.Add(accordionPane);

                    Tree innerTree = new Tree();
                    innerTree.EnableArrows = true;
                    innerTree.ShowBorder = false;
                    innerTree.ShowHeader = false;
                    innerTree.EnableIcons = false;
                    innerTree.AutoScroll = true;
                    accordionPane.Items.Add(innerTree);

                    XmlDocument innerXmlDoc = new XmlDocument();
                    innerXmlDoc.LoadXml(String.Format("<?xml version=\"1.0\" encoding=\"utf-8\" ?><Tree>{0}</Tree>", xmlNode.InnerXml));

                    // 绑定AccordionPane内部的树控件
                    innerTree.DataSource = innerXmlDoc;
                    innerTree.DataBind();

                    // 重新设置每个节点的图标
                    ResolveTreeNode(innerTree.Nodes);
                }
            }
            return accordionMenu;
        }

        private Tree InitTreeMenu()
        {
            Tree treeMenu = new Tree();
            treeMenu.ID = "treeMenu";
            treeMenu.EnableArrows = true;
            treeMenu.ShowBorder = false;
            treeMenu.ShowHeader = false;
            treeMenu.EnableIcons = false;
            treeMenu.AutoScroll = true;
            Region2.Items.Add(treeMenu);

            // 绑定 XML 数据源到树控件
            treeMenu.DataSource = XmlDataSource1;
            treeMenu.DataBind();

            // 重新设置每个节点的图标
            ResolveTreeNode(treeMenu.Nodes);

            return treeMenu;
        }


        private JObject GetClientIDS(params ControlBase[] ctrls)
        {
            JObject jo = new JObject();
            foreach (ControlBase ctrl in ctrls)
            {
                jo.Add(ctrl.ID, ctrl.ClientID);
            }

            return jo;
        }

        #endregion

        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!PageMange.IsFirstPage())
            {
                Response.Redirect(Request.ApplicationPath + SString.PAGE_DEFAULT);
            }

            if (!IsPostBack)
            {
                InitMenuStyleButton();
                InitLangMenuButton();
                InitThemeMenuButton();

                // 显示源代码按钮
                btnChangePwd.OnClientClick = windowSourceCode.GetShowReference("ChangePwd.aspx");
            }
            if (!PageMange.IsLogin())
            {
                JSUtility.AlertAndRedirect("由于您长时间没有操作\n为了保护您的账号安全请重新登陆", "Login.aspx");
            }

            StudentBasicInfo SBI;
            StudentBasicInfo.getStudentBaseInfo(out SBI, DHelper.GetSession(SColumn.U_NAME).ToString());
            logoShow = String.Format(PageMange.getRegardsChar(), SBI.Name, DateTime.Now.ToString(SString.DATE));
        }

        /// <summary>
        /// 初始化样式菜单
        /// </summary>
        private void InitMenuStyleButton()
        {
            string menuStyleID = "MenuStyleTree";
            
            HttpCookie menuStyleCookie = Request.Cookies["MenuStyle"];
            if (menuStyleCookie != null)
            {
                switch (menuStyleCookie.Value)
                {
                    case "menu":
                        menuStyleID = "MenuStyleTree";
                        break;
                    case "accordion":
                        menuStyleID = "MenuStyleAccordion";
                        break;
                }
            }
            SetSelectedMenuID(MenuStyle, menuStyleID);
        }

        /// <summary>
        /// 初始化语言菜单
        /// </summary>
        private void InitLangMenuButton()
        {
            string langMenuID = "MenuLangZHCN";

            string langValue = PageManager1.Language.ToString().ToLower();
            switch (langValue)
            {
                case "zh_cn":
                    langMenuID = "MenuLangZHCN";
                    break;
                case "en":
                    langMenuID = "MenuLangEN";
                    break;
            }
            SetSelectedMenuID(MenuLang, langMenuID);
        }

        /// <summary>
        /// 初始化主题菜单
        /// </summary>
        private void InitThemeMenuButton()
        {
            string themeMenuID = "MenuThemeBlue";

            string customThemeValue = PageManager1.CustomTheme.ToString().ToLower();
          
            if (!String.IsNullOrEmpty(customThemeValue))
            {
                switch (customThemeValue)
                {
                    case "blueen":
                        themeMenuID = "MenuThemeBlueen";
                        break;
                    case "first":
                        themeMenuID = "MenuThemeFirst";
                        break;
                    case "second":
                        themeMenuID = "MenuThemeSecond";
                        break;
                    case "fourth":
                        themeMenuID = "MenuThemeFourth";
                        break;
                }
            }
            else
            {
                string themeValue = PageManager1.Theme.ToString().ToLower();
                switch (themeValue)
                {
                    case "blue":
                        themeMenuID = "MenuThemeBlue";
                        break;
                    case "gray":
                        themeMenuID = "MenuThemeGray";
                        break;
                    case "access":
                        themeMenuID = "MenuThemeAccess";
                        break;
                }
            }
            SetSelectedMenuID(MenuTheme, themeMenuID);
        }
        #endregion

        #region Event

        /// <summary>
        /// 系统语言选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MenuLang_CheckedChanged(object sender, EventArgs e)
        {
            MenuCheckBox menuCheckBox = sender as MenuCheckBox;
            if (!menuCheckBox.Checked)
            {
                // CheckedChanged会触发两次，一次是取消选中的菜单项，另一次是选中的菜单项；
                // 这里不处理取消选中的菜单项的事件，从而防止此函数重复执行两次
                return;
            }

            string langValue = "zh_cn";
            string langID = GetSelectedMenuID(MenuLang);
            switch (langID)
            {
                case "MenuLangZHCN":
                    langValue = "zh_cn";
                    break;
                case "MenuLangEN":
                    langValue = "en";
                    break;
            }
            SaveToCookieAndRefresh("Language", langValue);
        }

        /// <summary>
        /// 主题选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MenuTheme_CheckedChanged(object sender, EventArgs e)
        {
            MenuCheckBox menuCheckBox = sender as MenuCheckBox;
            if (!menuCheckBox.Checked)
            {
                // CheckedChanged会触发两次，一次是取消选中的菜单项，另一次是选中的菜单项；
                // 这里不处理取消选中的菜单项的事件，从而防止此函数重复执行两次
                return;
            }

            string themeValue = "Blue";
            string themeID = GetSelectedMenuID(MenuTheme);

            switch (themeID)
            {
                case "MenuThemeBlue":
                    themeValue = "blue";
                    break;
                case "MenuThemeGray":
                    themeValue = "gray";
                    break;
                case "MenuThemeAccess":
                    themeValue = "access";
                    break;
                case "MenuThemeBlueen":
                    themeValue = "blueen";
                    break;
                case "MenuThemeFirst":
                    themeValue = "first";
                    break;
                case "MenuThemeSecond":
                    themeValue = "second";
                    break;
                case "MenuThemeFourth":
                    themeValue = "fourth";
                    break;
            }
            SaveToCookieAndRefresh("Theme", themeValue);
        }

        /// <summary>
        /// 菜单样式选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MenuStyle_CheckedChanged(object sender, EventArgs e)
        {
            MenuCheckBox menuCheckBox = sender as MenuCheckBox;
            if (!menuCheckBox.Checked)
            {
                // CheckedChanged会触发两次，一次是取消选中的菜单项，另一次是选中的菜单项；
                // 这里不处理取消选中的菜单项的事件，从而防止此函数重复执行两次
                return;
            }

            string menuValue = "menu";
            string menuStyleID = GetSelectedMenuID(MenuStyle);
             
            switch (menuStyleID)
            {
                case "MenuStyleTree":
                    menuValue = "tree";
                    break;
                case "MenuStyleAccordion":
                    menuValue = "accordion";
                    break;
                
            }
            SaveToCookieAndRefresh("MenuStyle", menuValue);
        }

        /// <summary>
        /// 获取菜单的激活菜单项的ID
        /// </summary>
        /// <param name="menuButton">菜单</param>
        /// <returns>菜单项ID</returns>
        private string GetSelectedMenuID(MenuButton menuButton)
        {
            foreach (MenuItem item in menuButton.Menu.Items)
            {
                if (item is MenuCheckBox && (item as MenuCheckBox).Checked)
                {
                    return item.ID;
                }
            }
            return null;
        }

        /// <summary>
        /// 将指定菜单的菜单项（ID）激活
        /// </summary>
        /// <param name="menuButton">菜单</param>
        /// <param name="selectedMenuID">菜单项的ID</param>
        private void SetSelectedMenuID(MenuButton menuButton, string selectedMenuID)
        {
            foreach (MenuItem item in menuButton.Menu.Items)
            {
                MenuCheckBox menu = (item as MenuCheckBox);
                if (menu != null && menu.ID == selectedMenuID)
                {
                    menu.Checked = true;
                }
                else
                {
                    menu.Checked = false;
                }
            }
        }

        /// <summary>
        /// 保存cookie并刷新页面
        /// </summary>
        /// <param name="cookieName"></param>
        /// <param name="cookieValue"></param>
        private void SaveToCookieAndRefresh(string cookieName, string cookieValue)
        {
            DHelper.SetCookie(cookieName, 1, cookieValue);
            PageContext .Refresh();
        }

        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void exit_System(object sender, EventArgs e)
        {
            Session.Remove(SColumn.U_NAME);
            JSUtility.AlertAndRedirect("是否退出系统？", Request.ApplicationPath + SString.PAGE_DEFAULT);
        }

        #endregion

        #region Tree

        /// <summary>
        /// 重新设置每个节点的图标
        /// </summary>
        /// <param name="nodes"></param>
        private void ResolveTreeNode(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    if (!String.IsNullOrEmpty(node.NavigateUrl))
                    {
                        node.IconUrl = GetIconForTreeNode(node.NavigateUrl);
                    }
                }
                else
                {
                    ResolveTreeNode(node.Nodes);
                }
            }
        }

        /// <summary>
        /// 根据链接地址返回相应的图标
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private string GetIconForTreeNode(string url)
        {
            string iconUrl = "images/filetype/vs_unknow.png";
            url = url.ToLower();
            int lastDotIndex = url.LastIndexOf('.');
            string fileType = url.Substring(lastDotIndex + 1);
            if (fileType == "txt")
            {
                iconUrl = "images/filetype/vs_txt.png";
            }
            else if (fileType == "aspx")
            {
                iconUrl = "images/filetype/vs_aspx.png";
            }
            else if (fileType == "htm" || fileType == "html")
            {
                iconUrl = "images/filetype/vs_htm.png";
            }

            return iconUrl;
        }

        #endregion
    }
}
