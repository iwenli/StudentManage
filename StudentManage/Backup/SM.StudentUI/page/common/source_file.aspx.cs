using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace SM.StudentUI
{
    public partial class source_file : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string file = Request.QueryString["file"];
                
                string content = File.ReadAllText(Server.MapPath(file));

                if (!String.IsNullOrEmpty(file))
                {
                    string language = "ASPX";
                    string fileName = file.ToLower();
                    if (fileName.EndsWith(".aspx"))
                    {
                        language = "ASPX";
                    }
                    else if (fileName.EndsWith(".cs"))
                    {
                        language = "C#";
                    }
                    else if (fileName.EndsWith(".config") || fileName.EndsWith(".sitemap") || fileName.EndsWith(".xml"))
                    {
                        language = "XML";
                    }
                    else if (fileName.EndsWith(".css"))
                    {
                        language = "CSS";
                    }
                    else if (fileName.EndsWith(".js"))
                    {
                        language = "JavaScript";
                    }

                    SyntaxHighlighter1.Mode = Wilco.Web.SyntaxHighlighting.HighlightMode.Source;
                    SyntaxHighlighter1.Language = language;
                    SyntaxHighlighter1.Text = content;
                } 

            }
        }
    }
}
