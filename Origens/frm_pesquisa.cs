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
    public partial class frm_pesquisa : Form
    {
        public static Candidato candidatoSelecionado;
        public frm_pesquisa()
        {
            InitializeComponent();
            candidatoSelecionado = new Candidato();
        }

        private void frm_pesquisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetOrigens.candidatos' table. You can move, or remove it, as needed.
            //this.candidatosTableAdapter.Fill(this.dataSetOrigens.candidatos);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
            //if datagridview have a predefined columns then using those objects as:
            candidatoSelecionado.codigo = Convert.ToInt32(dgvr.Cells[0].Value);
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.CurrentRow;
            //if datagridview have a predefined columns then using those objects as:
            String x = dgvr.Cells[0].Value.ToString();

            this.Close();
            this.Dispose();

            /*frm_atualizar atualiza = new frm_atualizar();
            atualiza.MdiParent = this.Parent();
            atualiza.Show();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidatosTableAdapter.FillBy(this.dataSetOrigens.candidatos, Convert.ToInt32(txtPALAVRA_CHAVE.Text));
            }
            catch (Exception exc)
            {

            }
        }
    }
}
