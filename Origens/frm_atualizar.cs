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
    public partial class frm_atualizar : Form
    {
        public frm_atualizar()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frm_atualizar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetOrigens.doencas' table. You can move, or remove it, as needed.
            this.doencasTableAdapter.Fill(this.dataSetOrigens.doencas);
            // TODO: This line of code loads data into the 'dataSetOrigens.escolaridades' table. You can move, or remove it, as needed.
            this.escolaridadesTableAdapter.Fill(this.dataSetOrigens.escolaridades);
            // TODO: This line of code loads data into the 'dataSetOrigens.temperamentos' table. You can move, or remove it, as needed.
            this.temperamentosTableAdapter.Fill(this.dataSetOrigens.temperamentos);
            // TODO: This line of code loads data into the 'dataSetOrigens.view_faixa_altura' table. You can move, or remove it, as needed.
            this.view_faixa_alturaTableAdapter.Fill(this.dataSetOrigens.view_faixa_altura);
            // TODO: This line of code loads data into the 'dataSetOrigens.tipos_cabelo' table. You can move, or remove it, as needed.
            this.tipos_cabeloTableAdapter.Fill(this.dataSetOrigens.tipos_cabelo);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_pele' table. You can move, or remove it, as needed.
            this.cores_peleTableAdapter.Fill(this.dataSetOrigens.cores_pele);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_cabelo' table. You can move, or remove it, as needed.
            this.cores_cabeloTableAdapter.Fill(this.dataSetOrigens.cores_cabelo);
            // TODO: This line of code loads data into the 'dataSetOrigens.cores_olho' table. You can move, or remove it, as needed.
            this.cores_olhoTableAdapter.Fill(this.dataSetOrigens.cores_olho);
            // TODO: This line of code loads data into the 'dataSetOrigens.estados' table. You can move, or remove it, as needed.
            this.estadosTableAdapter.Fill(this.dataSetOrigens.estados);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Candidato c = new Candidato();
                c.codigo = 29;
                DataSetOrigensTableAdapters.candidatosTableAdapter adaptador = new DataSetOrigensTableAdapters.candidatosTableAdapter();
                DataSetOrigens.candidatosDataTable candidatosRows =  adaptador.ObterCandidatoPeloCodigo(c.codigo);
                DataSetOrigens.candidatosRow row = candidatosRows[0];

                txtCODIGO.Text = c.codigo.ToString();
                txtNOME.Text = row.nom_candidato;
                txtCPF.Text = row.cpf_candidato;
                dtpNASCIMENTO.Value = row.dat_nascimento_candidato;
                txtTELEFONE.Text = row.tel_candidato;
               

            }
            catch (Exception exc)
            {
            }
        }
    }
}
