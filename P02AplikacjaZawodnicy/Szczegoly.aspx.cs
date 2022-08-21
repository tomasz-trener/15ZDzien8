using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Szczegoly : System.Web.UI.Page
    {
        public ZawodnikVM Zawodnik;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string idString = Request["id"];
                int id;

                if (!int.TryParse(idString, out id))
                    Response.Redirect("Default.aspx");
                else if (id > 0)
                {
                    ZawodnicyRepository zr = new ZawodnicyRepository();
                    Zawodnik = zr.WczytajZawodnika(id);
                    txtImie.Text = Zawodnik.Imie;
                    txtNazwisko.Text = Zawodnik.Nazwisko;
                    txtKraj.Text = Zawodnik.Kraj;
                    txtMiasto.Text = Zawodnik.Miasto;
                    txtWaga.Text = Zawodnik.Waga.ToString();
                    txtWzrost.Text = Zawodnik.Wzrost.ToString();
                    txtDataUr.Text = Zawodnik.DataUr?.ToString("dd-MM-yyyy");
                    btnUsun.Visible = true;
                }
            }
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            string idString = Request["id"];
            int id;

            if (!int.TryParse(idString, out id))
                Response.Redirect("Default.aspx");
            else
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                ZawodnikVM z = new ZawodnikVM();
                z.Id_zawodnika = id;
                z.Imie = txtImie.Text;
                z.Nazwisko = txtNazwisko.Text;
                z.Kraj = txtKraj.Text;
                z.DataUr = Convert.ToDateTime(txtDataUr.Text);
                z.Waga = Convert.ToInt32(txtWaga.Text);
                z.Wzrost = Convert.ToInt32(txtWzrost.Text);
                z.Miasto = txtMiasto.Text;

                if (id > 0)
                    zr.Edytuj(z);
                else
                    zr.DodajZawodnika(z);

                Response.Redirect("Default.aspx");
            }
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            string idString = Request["id"];
            int id;

            if (!int.TryParse(idString, out id))
                Response.Redirect("Default.aspx");
            else
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.UsunZawodnika(new ZawodnikVM() { Id_zawodnika = id });
                Response.Redirect("Default.aspx");
            }
        }
    }
}