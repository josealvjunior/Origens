namespace Origens
{
    partial class frm_pesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPALAVRA_CHAVE = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datnascimentocandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadecandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecocandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementocandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepcandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcorolhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcorcabeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcorpeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtipocabeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfaixaalturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtemperamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codescolaridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddoencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.praticaesporteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.candidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrigens = new Origens.DataSetOrigens();
            this.candidatosTableAdapter = new Origens.DataSetOrigensTableAdapters.candidatosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // txtPALAVRA_CHAVE
            // 
            this.txtPALAVRA_CHAVE.Location = new System.Drawing.Point(74, 6);
            this.txtPALAVRA_CHAVE.Name = "txtPALAVRA_CHAVE";
            this.txtPALAVRA_CHAVE.Size = new System.Drawing.Size(328, 20);
            this.txtPALAVRA_CHAVE.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcandidatoDataGridViewTextBoxColumn,
            this.nomcandidatoDataGridViewTextBoxColumn,
            this.cpfcandidatoDataGridViewTextBoxColumn,
            this.datnascimentocandidatoDataGridViewTextBoxColumn,
            this.telcandidatoDataGridViewTextBoxColumn,
            this.codestadoDataGridViewTextBoxColumn,
            this.cidadecandidatoDataGridViewTextBoxColumn,
            this.enderecocandidatoDataGridViewTextBoxColumn,
            this.complementocandidatoDataGridViewTextBoxColumn,
            this.cepcandidatoDataGridViewTextBoxColumn,
            this.codcorolhoDataGridViewTextBoxColumn,
            this.codcorcabeloDataGridViewTextBoxColumn,
            this.codcorpeleDataGridViewTextBoxColumn,
            this.codtipocabeloDataGridViewTextBoxColumn,
            this.codfaixaalturaDataGridViewTextBoxColumn,
            this.codtemperamentoDataGridViewTextBoxColumn,
            this.codescolaridadeDataGridViewTextBoxColumn,
            this.coddoencaDataGridViewTextBoxColumn,
            this.praticaesporteDataGridViewCheckBoxColumn,
            this.leDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.candidatosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(499, 236);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // codcandidatoDataGridViewTextBoxColumn
            // 
            this.codcandidatoDataGridViewTextBoxColumn.DataPropertyName = "cod_candidato";
            this.codcandidatoDataGridViewTextBoxColumn.HeaderText = "cod_candidato";
            this.codcandidatoDataGridViewTextBoxColumn.Name = "codcandidatoDataGridViewTextBoxColumn";
            this.codcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomcandidatoDataGridViewTextBoxColumn
            // 
            this.nomcandidatoDataGridViewTextBoxColumn.DataPropertyName = "nom_candidato";
            this.nomcandidatoDataGridViewTextBoxColumn.HeaderText = "nom_candidato";
            this.nomcandidatoDataGridViewTextBoxColumn.Name = "nomcandidatoDataGridViewTextBoxColumn";
            this.nomcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfcandidatoDataGridViewTextBoxColumn
            // 
            this.cpfcandidatoDataGridViewTextBoxColumn.DataPropertyName = "cpf_candidato";
            this.cpfcandidatoDataGridViewTextBoxColumn.HeaderText = "cpf_candidato";
            this.cpfcandidatoDataGridViewTextBoxColumn.Name = "cpfcandidatoDataGridViewTextBoxColumn";
            this.cpfcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datnascimentocandidatoDataGridViewTextBoxColumn
            // 
            this.datnascimentocandidatoDataGridViewTextBoxColumn.DataPropertyName = "dat_nascimento_candidato";
            this.datnascimentocandidatoDataGridViewTextBoxColumn.HeaderText = "dat_nascimento_candidato";
            this.datnascimentocandidatoDataGridViewTextBoxColumn.Name = "datnascimentocandidatoDataGridViewTextBoxColumn";
            this.datnascimentocandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telcandidatoDataGridViewTextBoxColumn
            // 
            this.telcandidatoDataGridViewTextBoxColumn.DataPropertyName = "tel_candidato";
            this.telcandidatoDataGridViewTextBoxColumn.HeaderText = "tel_candidato";
            this.telcandidatoDataGridViewTextBoxColumn.Name = "telcandidatoDataGridViewTextBoxColumn";
            this.telcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codestadoDataGridViewTextBoxColumn
            // 
            this.codestadoDataGridViewTextBoxColumn.DataPropertyName = "cod_estado";
            this.codestadoDataGridViewTextBoxColumn.HeaderText = "cod_estado";
            this.codestadoDataGridViewTextBoxColumn.Name = "codestadoDataGridViewTextBoxColumn";
            this.codestadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadecandidatoDataGridViewTextBoxColumn
            // 
            this.cidadecandidatoDataGridViewTextBoxColumn.DataPropertyName = "cidade_candidato";
            this.cidadecandidatoDataGridViewTextBoxColumn.HeaderText = "cidade_candidato";
            this.cidadecandidatoDataGridViewTextBoxColumn.Name = "cidadecandidatoDataGridViewTextBoxColumn";
            this.cidadecandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecocandidatoDataGridViewTextBoxColumn
            // 
            this.enderecocandidatoDataGridViewTextBoxColumn.DataPropertyName = "endereco_candidato";
            this.enderecocandidatoDataGridViewTextBoxColumn.HeaderText = "endereco_candidato";
            this.enderecocandidatoDataGridViewTextBoxColumn.Name = "enderecocandidatoDataGridViewTextBoxColumn";
            this.enderecocandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementocandidatoDataGridViewTextBoxColumn
            // 
            this.complementocandidatoDataGridViewTextBoxColumn.DataPropertyName = "complemento_candidato";
            this.complementocandidatoDataGridViewTextBoxColumn.HeaderText = "complemento_candidato";
            this.complementocandidatoDataGridViewTextBoxColumn.Name = "complementocandidatoDataGridViewTextBoxColumn";
            this.complementocandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepcandidatoDataGridViewTextBoxColumn
            // 
            this.cepcandidatoDataGridViewTextBoxColumn.DataPropertyName = "cep_candidato";
            this.cepcandidatoDataGridViewTextBoxColumn.HeaderText = "cep_candidato";
            this.cepcandidatoDataGridViewTextBoxColumn.Name = "cepcandidatoDataGridViewTextBoxColumn";
            this.cepcandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcorolhoDataGridViewTextBoxColumn
            // 
            this.codcorolhoDataGridViewTextBoxColumn.DataPropertyName = "cod_cor_olho";
            this.codcorolhoDataGridViewTextBoxColumn.HeaderText = "cod_cor_olho";
            this.codcorolhoDataGridViewTextBoxColumn.Name = "codcorolhoDataGridViewTextBoxColumn";
            this.codcorolhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcorcabeloDataGridViewTextBoxColumn
            // 
            this.codcorcabeloDataGridViewTextBoxColumn.DataPropertyName = "cod_cor_cabelo";
            this.codcorcabeloDataGridViewTextBoxColumn.HeaderText = "cod_cor_cabelo";
            this.codcorcabeloDataGridViewTextBoxColumn.Name = "codcorcabeloDataGridViewTextBoxColumn";
            this.codcorcabeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcorpeleDataGridViewTextBoxColumn
            // 
            this.codcorpeleDataGridViewTextBoxColumn.DataPropertyName = "cod_cor_pele";
            this.codcorpeleDataGridViewTextBoxColumn.HeaderText = "cod_cor_pele";
            this.codcorpeleDataGridViewTextBoxColumn.Name = "codcorpeleDataGridViewTextBoxColumn";
            this.codcorpeleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codtipocabeloDataGridViewTextBoxColumn
            // 
            this.codtipocabeloDataGridViewTextBoxColumn.DataPropertyName = "cod_tipo_cabelo";
            this.codtipocabeloDataGridViewTextBoxColumn.HeaderText = "cod_tipo_cabelo";
            this.codtipocabeloDataGridViewTextBoxColumn.Name = "codtipocabeloDataGridViewTextBoxColumn";
            this.codtipocabeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codfaixaalturaDataGridViewTextBoxColumn
            // 
            this.codfaixaalturaDataGridViewTextBoxColumn.DataPropertyName = "cod_faixa_altura";
            this.codfaixaalturaDataGridViewTextBoxColumn.HeaderText = "cod_faixa_altura";
            this.codfaixaalturaDataGridViewTextBoxColumn.Name = "codfaixaalturaDataGridViewTextBoxColumn";
            this.codfaixaalturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codtemperamentoDataGridViewTextBoxColumn
            // 
            this.codtemperamentoDataGridViewTextBoxColumn.DataPropertyName = "cod_temperamento";
            this.codtemperamentoDataGridViewTextBoxColumn.HeaderText = "cod_temperamento";
            this.codtemperamentoDataGridViewTextBoxColumn.Name = "codtemperamentoDataGridViewTextBoxColumn";
            this.codtemperamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codescolaridadeDataGridViewTextBoxColumn
            // 
            this.codescolaridadeDataGridViewTextBoxColumn.DataPropertyName = "cod_escolaridade";
            this.codescolaridadeDataGridViewTextBoxColumn.HeaderText = "cod_escolaridade";
            this.codescolaridadeDataGridViewTextBoxColumn.Name = "codescolaridadeDataGridViewTextBoxColumn";
            this.codescolaridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coddoencaDataGridViewTextBoxColumn
            // 
            this.coddoencaDataGridViewTextBoxColumn.DataPropertyName = "cod_doenca";
            this.coddoencaDataGridViewTextBoxColumn.HeaderText = "cod_doenca";
            this.coddoencaDataGridViewTextBoxColumn.Name = "coddoencaDataGridViewTextBoxColumn";
            this.coddoencaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // praticaesporteDataGridViewCheckBoxColumn
            // 
            this.praticaesporteDataGridViewCheckBoxColumn.DataPropertyName = "pratica_esporte";
            this.praticaesporteDataGridViewCheckBoxColumn.HeaderText = "pratica_esporte";
            this.praticaesporteDataGridViewCheckBoxColumn.Name = "praticaesporteDataGridViewCheckBoxColumn";
            this.praticaesporteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // leDataGridViewCheckBoxColumn
            // 
            this.leDataGridViewCheckBoxColumn.DataPropertyName = "le";
            this.leDataGridViewCheckBoxColumn.HeaderText = "le";
            this.leDataGridViewCheckBoxColumn.Name = "leDataGridViewCheckBoxColumn";
            this.leDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // candidatosBindingSource
            // 
            this.candidatosBindingSource.DataMember = "candidatos";
            this.candidatosBindingSource.DataSource = this.dataSetOrigens;
            // 
            // dataSetOrigens
            // 
            this.dataSetOrigens.DataSetName = "DataSetOrigens";
            this.dataSetOrigens.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatosTableAdapter
            // 
            this.candidatosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar o candidato selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 326);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPALAVRA_CHAVE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_pesquisa";
            this.Load += new System.EventHandler(this.frm_pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrigens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPALAVRA_CHAVE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetOrigens dataSetOrigens;
        private System.Windows.Forms.BindingSource candidatosBindingSource;
        private DataSetOrigensTableAdapters.candidatosTableAdapter candidatosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datnascimentocandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadecandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecocandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementocandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepcandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcorolhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcorcabeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcorpeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtipocabeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfaixaalturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtemperamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codescolaridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddoencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn praticaesporteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn leDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}