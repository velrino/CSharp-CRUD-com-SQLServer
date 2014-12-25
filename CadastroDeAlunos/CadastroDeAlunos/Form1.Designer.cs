namespace CadastroDeAlunos
{
    partial class frm_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_crud));
            this.DataEHora = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label_Idade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_EMAIL = new System.Windows.Forms.Label();
            this.label_Nome = new System.Windows.Forms.Label();
            this.BoxNomePai = new System.Windows.Forms.TextBox();
            this.BoxCidade = new System.Windows.Forms.TextBox();
            this.BoxTelefone = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgEditar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgExcluir = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.radioCodigo = new System.Windows.Forms.RadioButton();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnCadAluno = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSalvar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeletar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSair = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEditar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluir)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataEHora
            // 
            this.DataEHora.Enabled = true;
            this.DataEHora.Interval = 1000;
            this.DataEHora.Tick += new System.EventHandler(this.DataEHora_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 78);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(765, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel1.Text = "lbDataeHora";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 326);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 273);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label_Cidade);
            this.tabPage1.Controls.Add(this.label_telefone);
            this.tabPage1.Controls.Add(this.label_Idade);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label_EMAIL);
            this.tabPage1.Controls.Add(this.label_Nome);
            this.tabPage1.Controls.Add(this.BoxNomePai);
            this.tabPage1.Controls.Add(this.BoxCidade);
            this.tabPage1.Controls.Add(this.BoxTelefone);
            this.tabPage1.Controls.Add(this.txtIdade);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.BoxEmail);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome do Pai";
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(32, 158);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(40, 13);
            this.label_Cidade.TabIndex = 2;
            this.label_Cidade.Text = "Cidade";
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(208, 93);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(49, 13);
            this.label_telefone.TabIndex = 2;
            this.label_telefone.Text = "Telefone";
            // 
            // label_Idade
            // 
            this.label_Idade.AutoSize = true;
            this.label_Idade.Location = new System.Drawing.Point(208, 20);
            this.label_Idade.Name = "label_Idade";
            this.label_Idade.Size = new System.Drawing.Size(34, 13);
            this.label_Idade.TabIndex = 2;
            this.label_Idade.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label3";
            // 
            // label_EMAIL
            // 
            this.label_EMAIL.AutoSize = true;
            this.label_EMAIL.Location = new System.Drawing.Point(32, 93);
            this.label_EMAIL.Name = "label_EMAIL";
            this.label_EMAIL.Size = new System.Drawing.Size(35, 13);
            this.label_EMAIL.TabIndex = 2;
            this.label_EMAIL.Text = "E-mail";
            // 
            // label_Nome
            // 
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(32, 20);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 1;
            this.label_Nome.Text = "Nome";
            // 
            // BoxNomePai
            // 
            this.BoxNomePai.Location = new System.Drawing.Point(211, 193);
            this.BoxNomePai.Name = "BoxNomePai";
            this.BoxNomePai.Size = new System.Drawing.Size(100, 20);
            this.BoxNomePai.TabIndex = 0;
            // 
            // BoxCidade
            // 
            this.BoxCidade.Location = new System.Drawing.Point(35, 193);
            this.BoxCidade.Multiline = true;
            this.BoxCidade.Name = "BoxCidade";
            this.BoxCidade.Size = new System.Drawing.Size(100, 20);
            this.BoxCidade.TabIndex = 0;
            // 
            // BoxTelefone
            // 
            this.BoxTelefone.Location = new System.Drawing.Point(211, 128);
            this.BoxTelefone.MaxLength = 10;
            this.BoxTelefone.Name = "BoxTelefone";
            this.BoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.BoxTelefone.TabIndex = 0;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(211, 55);
            this.txtIdade.MaxLength = 3;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 0;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(348, 128);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(348, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // BoxEmail
            // 
            this.BoxEmail.Location = new System.Drawing.Point(35, 128);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(100, 20);
            this.BoxEmail.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgEditar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgEditar
            // 
            this.dgEditar.AllowUserToAddRows = false;
            this.dgEditar.AllowUserToDeleteRows = false;
            this.dgEditar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEditar.Location = new System.Drawing.Point(8, 52);
            this.dgEditar.Name = "dgEditar";
            this.dgEditar.ReadOnly = true;
            this.dgEditar.Size = new System.Drawing.Size(740, 189);
            this.dgEditar.TabIndex = 0;
            this.dgEditar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEditar_CellContentClick);
            this.dgEditar.Enter += new System.EventHandler(this.dgEditar_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtExcluir);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dgExcluir);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(754, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir Aluno";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(39, 54);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.Size = new System.Drawing.Size(185, 20);
            this.txtExcluir.TabIndex = 2;
            this.txtExcluir.TextChanged += new System.EventHandler(this.txtExcluir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Aluno";
            // 
            // dgExcluir
            // 
            this.dgExcluir.AllowUserToAddRows = false;
            this.dgExcluir.AllowUserToDeleteRows = false;
            this.dgExcluir.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgExcluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcluir.Location = new System.Drawing.Point(8, 116);
            this.dgExcluir.Name = "dgExcluir";
            this.dgExcluir.ReadOnly = true;
            this.dgExcluir.Size = new System.Drawing.Size(740, 125);
            this.dgExcluir.TabIndex = 0;
            this.dgExcluir.Enter += new System.EventHandler(this.dgExcluir_Enter);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPesquisar);
            this.tabPage4.Controls.Add(this.radioCodigo);
            this.tabPage4.Controls.Add(this.radioNome);
            this.tabPage4.Controls.Add(this.txtPesquisa);
            this.tabPage4.Controls.Add(this.dgPesquisa);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(754, 247);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pesquisar Aluno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(609, 31);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // radioCodigo
            // 
            this.radioCodigo.AutoSize = true;
            this.radioCodigo.Location = new System.Drawing.Point(355, 79);
            this.radioCodigo.Name = "radioCodigo";
            this.radioCodigo.Size = new System.Drawing.Size(77, 17);
            this.radioCodigo.TabIndex = 4;
            this.radioCodigo.Text = "Por Código";
            this.radioCodigo.UseVisualStyleBackColor = true;
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Checked = true;
            this.radioNome.Location = new System.Drawing.Point(236, 79);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(72, 17);
            this.radioNome.TabIndex = 3;
            this.radioNome.TabStop = true;
            this.radioNome.Text = "Por Nome";
            this.radioNome.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(16, 34);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(572, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(8, 102);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.ReadOnly = true;
            this.dgPesquisa.Size = new System.Drawing.Size(732, 150);
            this.dgPesquisa.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadAluno,
            this.btnSalvar,
            this.btnDeletar,
            this.btnSair});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(765, 37);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnCadAluno.Image")));
            this.btnCadAluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(32, 32);
            this.btnCadAluno.Text = "Cadastrar";
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(32, 32);
            this.btnSalvar.Text = "Atualizar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(32, 32);
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 32);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // frm_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_crud";
            this.Text = "Sistema de Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frm_crud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEditar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcluir)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DataEHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripStatusLabel btnCadAluno;
        private System.Windows.Forms.ToolStripStatusLabel btnSalvar;
        private System.Windows.Forms.ToolStripStatusLabel btnDeletar;
        private System.Windows.Forms.ToolStripStatusLabel btnSair;
        private System.Windows.Forms.DataGridView dgEditar;
        private System.Windows.Forms.DataGridView dgExcluir;
        private System.Windows.Forms.RadioButton radioCodigo;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Idade;
        private System.Windows.Forms.Label label_Nome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_EMAIL;
        private System.Windows.Forms.TextBox BoxNomePai;
        private System.Windows.Forms.TextBox BoxCidade;
        private System.Windows.Forms.TextBox BoxTelefone;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox BoxEmail;
    }
}

