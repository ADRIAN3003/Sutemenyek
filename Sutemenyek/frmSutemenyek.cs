using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sutemenyek
{
    public partial class frmSutemenyek : Form
    {
        public List<Sutemenyek> sutemenyeks;
        public frmSutemenyek(List<Sutemenyek> sutemenyeks)
        {
            InitializeComponent();
            this.sutemenyeks = sutemenyeks;
        }

        private void frmSutemenyek_Load(object sender, EventArgs e)
        {

        }
    }
}
