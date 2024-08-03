using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VSNetTemplates.Site.Templates1
{
    public partial class SAPageTemplate1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set culture.
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-Mx");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-MX");

            // On Create page...
            if (!IsPostBack)
            {
                // Translation according current culture page language.
                ficTranslation();
            }
        }


        public void pcvAlert(string vpsMessage)
        {
            // Cleans the message to allow single quotation marks.
            string vlsCleanMessage = vpsMessage.Replace("'", " ");
            vlsCleanMessage = vlsCleanMessage.Replace("\n", "\\n");
            vlsCleanMessage = vlsCleanMessage.Replace("\r", "\\r");

            string vlsScript = @"<script type='text/javascript'>alert('" + vlsCleanMessage + "')</script>";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", vlsScript, false);

        }

        public void pgvOpenPage(string vpsURL, bool vpbIsPopup)
        {

            if (vpbIsPopup)
            {
                // Open page as popup.
                string vlsScript = "window.open('" + vpsURL + "', 'popup_window', 'width=450,height=500,left=450,top=50,resizable=no');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", vlsScript, true);
            }
            else {
                // Redirect page.                                
                Response.Redirect(vpsURL);
            }

        }
        public int ficTranslation()
        {
            try
            {
                // Set Resource Manager class object for label traslation.
                ResourceManager vloResourceManagerGen = new ResourceManager("VSNetTemplates.Resources.General", Assembly.GetExecutingAssembly());
                //ResourceManager vloResourceManager = new ResourceManager("VSNetTemplates.Resources.INLoc", Assembly.GetExecutingAssembly());

                // Translate labels.                
                //gvwMain.Columns[0].HeaderText = vloResourceManager.GetString("Code");
                //gvwMain.Columns[1].HeaderText = vloResourceManager.GetString("Name");
                //btnNew.Text = vloResourceManagerGen.GetString("New");

                // Translate Messages.
                //hdnMsg_DuplicateCode.Value = vloResourceManagerGen.GetString("DuplicateCode");

                // Assign Master Labels.
                //MasterPage mainPage = (this.Master as MasterPage);
                //System.Web.UI.WebControls.Label lblAppName = mainPage.FindControl("lblAppName") as System.Web.UI.WebControls.Label;
                //lblAppName.Text = vloResourceManagerGen.GetString("Inventory"); ;
                //System.Web.UI.WebControls.Label lblPageTitle = mainPage.FindControl("lblPageTitle") as System.Web.UI.WebControls.Label;
                //lblPageTitle.Text = vloResourceManager.GetString("Locations"); ;

            }
            catch
            {
                return 1;
            }

            return 0;
        }

    }
}