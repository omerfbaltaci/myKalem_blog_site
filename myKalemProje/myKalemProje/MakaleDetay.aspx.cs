using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje
{
    public partial class MakaleDetay : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MAKALEID"]);
            var blog = db.TBLMAKALE.Where(x => x.MAKALEID == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            var yorumlar = db.TBLYORUM.Where(x => x.YORUMMAKALE == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MAKALEID"]);
            TBLYORUM t = new TBLYORUM();
            t.KULLANICIAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.YORUMICERIK = TextBox3.Text;
            t.YORUMMAKALE = id;
            db.TBLYORUM.Add(t);
            db.SaveChanges();
            Response.Redirect("MakaleDetay.Aspx?MAKALEID=" + id);
        }
    }
}