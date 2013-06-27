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
    public partial class frm_localizar : Form
    {
        private Utilitarios util = new Utilitarios();
        public frm_localizar()
        {
            InitializeComponent();
        }

        private void frm_localizar_Load(object sender, EventArgs e)
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

        }

        private void cboCOR_PELE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Candidato candidato = new Candidato();
                candidato.codCorOlho = util.obterValorCombo(cboCOR_OLHOS);
                candidato.codCorCabelo = util.obterValorCombo(cboCOR_CABELO);
                candidato.codCorPele = util.obterValorCombo(cboCOR_PELE);
                candidato.codTipoCabelo = util.obterValorCombo(cboTIPO_CABELO);
                candidato.codFaixaAltura = util.obterValorCombo(cboFAIXA_ALTURA);
                candidato.codTemperamento = util.obterValorCombo(cboTEMPERAMENTO);
                candidato.codEscolaridade = util.obterValorCombo(cboESCOLARIDADE);
                candidato.codDoenca = util.obterValorCombo(cboDOENCA);
                candidato.le = util.obterValorBool(cboLE);
                candidato.praticarEsporte = util.obterValorBool(cboPRATICA_ESPORTE);

                this.candidatoLocalizarTableAdapter.Fill(
                    this.dataSetOrigens.candidatoLocalizar,
                    util.obterValorCombo(cboCOR_OLHOS),
                    util.obterValorCombo(cboCOR_CABELO),
                    util.obterValorCombo(cboCOR_PELE),
                    util.obterValorCombo(cboTIPO_CABELO),
                    util.obterValorCombo(cboFAIXA_ALTURA),
                    util.obterValorCombo(cboTEMPERAMENTO),
                    util.obterValorCombo(cboESCOLARIDADE),
                    util.obterValorCombo(cboDOENCA),
                    util.obterValorBool(cboDOENCA),
                    util.obterValorBool(cboLE));
            }
            catch (Exception exc)
            {

            }
        }
    }
}
