using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var Makaleler = db.TBLMAKALE.ToList();
            Repeater1.DataSource = Makaleler;
            Repeater1.DataBind();

            var Makaleler2 = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = Makaleler2;
            Repeater2.DataBind();

            var Makaleler3 = db.TBLMAKALE.Take(5).ToList();
            Repeater3.DataSource = Makaleler3;
            Repeater3.DataBind();

            var Makaleler4 = db.TBLYORUM.Take(3).ToList();
            Repeater4.DataSource = Makaleler4;
            Repeater4.DataBind();

        }
    }
}