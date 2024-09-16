using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class MakaleSil : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MAKALEID"]);
            var blog = db.TBLMAKALE.Find(x);
            db.TBLMAKALE.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Makaleler.Aspx");
        }
    }
}