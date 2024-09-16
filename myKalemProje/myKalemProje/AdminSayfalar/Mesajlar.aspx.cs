using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Mesajlar : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KULLANICI"].ToString());
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Login.Aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz: " + Session["KULLANICI"].ToString());
            }
            Repeater1.DataSource = db.TBLILETISIM.ToList();
            Repeater1.DataBind();
        }
    }
}