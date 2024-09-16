using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class istatistik : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLMAKALE.Count().ToString();
            Label2.Text = db.TBLYORUM.Count().ToString();
            Label3.Text = db.TBLMAKALE.Where(x => x.MAKALETUR == 2).Count().ToString();
            Label4.Text = db.TBLMAKALE.Where(x => x.TBLTUR.TURAD == "Dizi").Count().ToString();
            Label5.Text = db.TBLMAKALE.Where(x => x.TBLTUR.TURAD == "Animasyon").Count().ToString();
            Label6.Text = db.TBLMAKALE.Where(y => y.MAKALEID == (db.TBLYORUM.GroupBy(x => x.YORUMMAKALE).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.MAKALEBASLIK).FirstOrDefault();

        }
    }
}