using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;
namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        myKalemEntities db = new myKalemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLMAKALE t = new TBLMAKALE();
            t.MAKALEBASLIK = TextBox1.Text;
            t.MAKALEYAZAR = TextBox3.Text;
            t.MAKALEICERIK = TextBox4.Text;
            t.MAKALETARIH = DateTime.Parse(TextBox2.Text);
            t.MAKALETUR = byte.Parse(DropDownList1.SelectedValue);
            t.MAKALEKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            db.TBLMAKALE.Add(t);
            db.SaveChanges();
            Response.Redirect("Makaleler.Aspx");
        }
    }
}