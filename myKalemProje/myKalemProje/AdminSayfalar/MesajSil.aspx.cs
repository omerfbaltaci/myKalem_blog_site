using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class MesajSil : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MESAJID"]);
            var mesaj = db.TBLILETISIM.Find(x);
            db.TBLILETISIM.Remove(mesaj);
            db.SaveChanges();
            Response.Redirect("Mesajlar.Aspx");
        }
    }
}