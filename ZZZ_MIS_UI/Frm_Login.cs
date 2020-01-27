using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZZZ_MIS_DAL;

namespace ZZZ_MIS_UI
{

    public partial class Frm_Login : Form
    {
        DSLogin dsLogin = new DSLogin();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DALogin.GetLoginByKorisnickoImeAndLozinka(dsLogin.LoginPodaci, txtKorisnickoIme.Text, txtLozinka.Text);
            int count = dsLogin.LoginPodaci.Count;

            if (count==1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
