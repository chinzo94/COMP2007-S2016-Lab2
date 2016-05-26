using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/**
 * @author: Chad Ostler
 * @date: May 26, 2016
 * @Version: 0.0.1
 * 
 * */

namespace COMP2007_S2016_Lab2
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
         * Adds a css class of "active" to list items relating to the current page
         * 
         * @Private
         * @Method SetActivePage
         * 
         * */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}