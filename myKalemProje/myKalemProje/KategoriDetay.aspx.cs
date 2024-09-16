using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var Makaleler = db.TBLMAKALE.Where(x => x.MAKALEKATEGORI == id).ToList();
            Repeater1.DataSource = Makaleler;
            Repeater1.DataBind();

            var Makaleler2 = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = Makaleler2;
            Repeater2.DataBind();

            var Makaleler3 = db.TBLMAKALE.ToList();
            Repeater3.DataSource = Makaleler3;
            Repeater3.DataBind();
        }
    }
}