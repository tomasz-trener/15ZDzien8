using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjaWebowa
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPowitanie_Click(object sender, EventArgs e)
        {
            // lblTekst.Text = "ala ma kota";

            int liczba1 = Convert.ToInt32(txtLiczba1.Text);
            int liczba2 = Convert.ToInt32(txtLiczba2.Text);

            int wynik = liczba1 + liczba2;

            lblTekst.Text = wynik.ToString();
        }
    }
}