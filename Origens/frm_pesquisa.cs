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
        public static Candidato candidatoSelecionado = new Candidato();
        public frm_pesquisa()
        {
            InitializeComponent();
            candidatoSelecionado = new Candidato();
        }

        public frm_atualizar formularioAtualizacao { get; set; }

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
            this.Close();
            this.Dispose();

            formularioAtualizacao.carregarFormulario(Convert.ToInt32(candidatoSelecionado.codigo));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            formularioAtualizacao.carregarFormulario(Convert.ToInt32(candidatoSelecionado.codigo));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidatoPesquisaTableAdapter.Fill(this.dataSetOrigens.candidatoPesquisa, txtPALAVRA_CHAVE.Text);
            }
            catch (Exception exc)
            {

            }
        }
    }
}
