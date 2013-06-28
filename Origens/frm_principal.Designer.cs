namespace Origens
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_home = new System.Windows.Forms.ToolStripButton();
            this.bt_cadastro = new System.Windows.Forms.ToolStripButton();
            this.bt_atualizar = new System.Windows.Forms.ToolStripButton();
            this.bt_sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bt_ajuda = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(147)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(210, 107);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_home,
            this.bt_cadastro,
            this.bt_atualizar,
            this.bt_sair,
            this.toolStripButton1,
            this.bt_ajuda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(211, 700);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_home
            // 
            this.bt_home.AutoSize = false;
            this.bt_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_home.Image = global::Origens.Properties.Resources.marca_origem;
            this.bt_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(210, 107);
            this.bt_home.Text = "toolStripButton1";
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_cadastro
            // 
            this.bt_cadastro.AutoSize = false;
            this.bt_cadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("bt_cadastro.Image")));
            this.bt_cadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_cadastro.Name = "bt_cadastro";
            this.bt_cadastro.Size = new System.Drawing.Size(210, 107);
            this.bt_cadastro.Text = "toolStripButton2";
            this.bt_cadastro.Click += new System.EventHandler(this.bt_cadastro_Click);
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.AutoSize = false;
            this.bt_atualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_atualizar.Image = global::Origens.Properties.Resources.atualizar_cadastro;
            this.bt_atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(210, 107);
            this.bt_atualizar.Text = "toolStripButton3";
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bt_sair.AutoSize = false;
            this.bt_sair.AutoToolTip = false;
            this.bt_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(66)))), ((int)(((byte)(108)))));
            this.bt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_sair.Image = global::Origens.Properties.Resources.sair2;
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bt_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(210, 60);
            this.bt_sair.Text = "toolStripButton5";
            this.bt_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_sair.ToolTipText = "Sair";
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Origens.Properties.Resources.localizar_semen;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(210, 107);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bt_ajuda
            // 
            this.bt_ajuda.AutoSize = false;
            this.bt_ajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_ajuda.Image = global::Origens.Properties.Resources.ajuda;
            this.bt_ajuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_ajuda.Name = "bt_ajuda";
            this.bt_ajuda.Size = new System.Drawing.Size(210, 107);
            this.bt_ajuda.Text = "toolStripButton4";
            this.bt_ajuda.Click += new System.EventHandler(this.bt_ajuda_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Origens.Properties.Resources._2_tela_origem_incial;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_home;
        private System.Windows.Forms.ToolStripButton bt_cadastro;
        private System.Windows.Forms.ToolStripButton bt_atualizar;
        private System.Windows.Forms.ToolStripButton bt_ajuda;
        private System.Windows.Forms.ToolStripButton bt_sair;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}



