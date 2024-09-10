using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak4
{
    public partial class Cenzura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCenzurisi_Click(string sender, EventArgs e)
        {
        }

        private string CenzurisiText(string izvorniText, string text)
        {
            return izvorniText;
        }

        protected void btnCenzurisi_Click1(object sender, EventArgs e)
        {
            var izvorniText = txtUlaz.Value;
            txtIzlaz.Text = CenzurisiText(izvorniText, txtRec.Text);
        }
    }
}