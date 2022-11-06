using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sutemenyek
{
    public partial class frmSutemenyek : Form
    {
        List<Sutemenyek> sutemenyeks;
        public frmSutemenyek(List<Sutemenyek> sutemenyeks)
        {
            InitializeComponent();
            this.sutemenyeks = sutemenyeks;
        }

        private void frmSutemenyek_Load(object sender, EventArgs e)
        {
            foreach (var sutemeny in sutemenyeks)
            {
                switch (sutemeny.Nev)
                {
                    case "Somlói galuska":
                        lblSomloiAr.Text = sutemeny.Ar + " Ft";
                        break;
                    case "Rákózci túrós":
                        lblRakocziAr.Text = sutemeny.Ar + " Ft";
                        break;
                    case "Csoki torta":
                        lblCsokiAr.Text = sutemeny.Ar + " Ft";
                        break;
                    case "Marcipán alagút":
                        lblMarcipanAr.Text = sutemeny.Ar + " Ft";
                        break;
                    case "Eszterházy szelet":
                        lblEszterhazyAr.Text = sutemeny.Ar + " Ft";
                        break;
                }
            }
        }

        private void nSomloi_ValueChanged(object sender, EventArgs e)
        {
            sutemenyeks.Find(x => x.Nev == "Somlói galuska").Db = Convert.ToInt32(nSomloi.Value);
            lblSomloiAr.Text = nSomloi.Value * sutemenyeks.Find(x => x.Nev == "Somlói galuska").Ar + " Ft";
        }

        private void nRakoczi_ValueChanged(object sender, EventArgs e)
        {
            sutemenyeks.Find(x => x.Nev == "Rákózci túrós").Db = Convert.ToInt32(nRakoczi.Value);
            lblRakocziAr.Text = nRakoczi.Value * sutemenyeks.Find(x => x.Nev == "Rákózci túrós").Ar + " Ft";
        }

        private void nCsoki_ValueChanged(object sender, EventArgs e)
        {
            sutemenyeks.Find(x => x.Nev == "Csoki torta").Db = Convert.ToInt32(nCsoki.Value);
            lblCsokiAr.Text = nCsoki.Value * sutemenyeks.Find(x => x.Nev == "Csoki torta").Ar + " Ft";
        }

        private void nMarcipan_ValueChanged(object sender, EventArgs e)
        {
            sutemenyeks.Find(x => x.Nev == "Marcipán alagút").Db = Convert.ToInt32(nMarcipan.Value);
            lblMarcipanAr.Text = nMarcipan.Value * sutemenyeks.Find(x => x.Nev == "Marcipán alagút").Ar + " Ft";
        }

        private void nEszterhazy_ValueChanged(object sender, EventArgs e)
        {
            sutemenyeks.Find(x => x.Nev == "Eszterházy szelet").Db = Convert.ToInt32(nEszterhazy.Value);
            lblEszterhazyAr.Text = nEszterhazy.Value * sutemenyeks.Find(x => x.Nev == "Eszterházy szelet").Ar + " Ft";
        }

        private void btnRendel_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("rendeles.txt"))
            {
                foreach (var sutemeny in sutemenyeks)
                {
                    if (sutemeny.Db > 0)
                    {
                        sw.WriteLine(sutemeny.Nev + " " + sutemeny.Db + " db " + sutemeny.Ar * sutemeny.Db + " Ft");
                    }
                }
            }
            MessageBox.Show("Rendelés kiírva fájlba!");
        }
    }
}
