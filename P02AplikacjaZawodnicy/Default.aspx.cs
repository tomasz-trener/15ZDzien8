using P05BibliotekaZawodnikVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        public ZawodnikVM[] Zawodnicy;

        protected void Page_Load(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnicy = zr.WczytajZawodnikow("", null);
        }
    }
}