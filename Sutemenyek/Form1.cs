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
    public partial class Form1 : Form
    {
        static List<Sutemenyek> sutemenyeks = new List<Sutemenyek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void mFajl_Click(object sender, EventArgs e)
        {
            if (ofdSutemeny.ShowDialog() == DialogResult.OK)
            {
                sutemenyeks.Clear();
                using (StreamReader sr = new StreamReader(ofdSutemeny.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] tmp = sr.ReadLine().Split(';');
                        sutemenyeks.Add(new Sutemenyek(tmp[0], Convert.ToInt32(tmp[1])));
                    }
                }
                mSutemenyek.Enabled = true;
                frmSutemenyek frmSutemenyek = new frmSutemenyek();
                frmSutemenyek.ShowDialog();
            }
        }

        private void mSutemenyek_Click(object sender, EventArgs e)
        {
            frmSutemenyek frmSutemenyek = new frmSutemenyek();
            frmSutemenyek.ShowDialog();
        }
    }
}
