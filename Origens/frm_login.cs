using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Origens
{
    public partial class frm_login : Form
    {
        // Define a conexção com o Banco de Dados;
        //public SqlConnection Conn = new SqlConnection();

        public frm_login()
        {
            InitializeComponent();
            //Formato de connection String com usuário e senha no Banco;
          //  Conn.ConnectionString = "Data Souce = Drago; Initial Catolog=Origens; User id=sa;Password=34190723;";
            //Conn.Open();
        }    

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Close();
            //Application.Exit();
        }
        private void frm_login_Load(object sender, EventArgs e)
        {
                    
        }      

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_principal principal = new frm_principal();
            principal.Focus();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Close();
        }
    }
}
