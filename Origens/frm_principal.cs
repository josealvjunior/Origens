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
    public partial class frm_principal : Form
    {
        public int codCandidatoSelecionado = -1;
        private int childFormNumber = 0;        
        public frm_principal()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }       

        private void bt_cadastro_Click(object sender, EventArgs e)
        {
            frm_cadastro cadastro_doador = new frm_cadastro();
            cadastro_doador.MdiParent = this;
            cadastro_doador.Show();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {

            frm_atualizar atualiza = new frm_atualizar();
            atualiza.MdiParent = this;
            atualiza.Show();

            /*frm_pesquisa pesquisa = new frm_pesquisa();
            pesquisa.MdiParent = this;
            pesquisa.formularioAtualizacao = atualiza;
            pesquisa.Show();*/

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_localizar localiza = new frm_localizar();
            localiza.MdiParent = this;
            localiza.Show();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_ajuda_Click(object sender, EventArgs e)
        {
            frm_ajuda ajuda = new frm_ajuda();
            ajuda.MdiParent = this;
            ajuda.Show();
        }
    }
}
