using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Origens
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbcarrega.Value < 100)
            {
                pbcarrega.Value = pbcarrega.Value + 10;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                /*frm_principal principal = new frm_principal();
                principal.Show();*/
                frm_login login = new frm_login();
                login.ShowDialog();
                
            }
        }
    }
}
