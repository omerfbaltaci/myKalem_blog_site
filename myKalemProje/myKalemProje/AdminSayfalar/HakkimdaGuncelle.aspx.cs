using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class HakkimdaGuncelle : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = 1;
            if (Page.IsPostBack == false)
            {
                var deger = db.TBLHAKKIMIZDA.Find(y);
                TextBox1.Text = deger.ACIKLAMA;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = 1;
            var blog = db.TBLHAKKIMIZDA.Find(y);
            blog.ACIKLAMA = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("HakkimdaGuncelle.Aspx");
        }
    }
}
