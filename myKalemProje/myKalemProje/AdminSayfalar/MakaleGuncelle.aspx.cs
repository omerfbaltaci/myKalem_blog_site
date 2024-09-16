using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class MakaleGuncelle : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["MAKALEID"]);
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();

                var kategoriler = (from x in db.TBLKATEGORI
                                   select new
                                   {
                                       x.KATEGORIAD,
                                       x.KATEGORIID
                                   }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();

                var deger = db.TBLMAKALE.Find(y);
                TextBox1.Text = deger.MAKALEBASLIK;
                TextBox2.Text = deger.MAKALETARIH.ToString();
                TextBox3.Text = deger.MAKALEYAZAR;
                TextBox4.Text = deger.MAKALEICERIK;
                DropDownList1.SelectedValue = deger.MAKALETUR.ToString();
                DropDownList2.SelectedValue = deger.MAKALEKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["MAKALEID"]);
            var blog = db.TBLMAKALE.Find(y);
            blog.MAKALEBASLIK = TextBox1.Text;
            blog.MAKALETARIH = DateTime.Parse(TextBox2.Text);
            blog.MAKALEYAZAR = TextBox3.Text;
            blog.MAKALEICERIK = TextBox4.Text;
            blog.MAKALETUR = byte.Parse(DropDownList1.SelectedValue);
            blog.MAKALEKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Makaleler.Aspx");
        }
    }
}