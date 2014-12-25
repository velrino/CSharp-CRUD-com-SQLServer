/**
 * Desenvolvido por: Denis "Velrino" Magalhães 
 * Desenvolvido em Dezembro de 2014
 * Finalidade: Conceitos básicos em C#, banco relacional SQL e Plataforma Desktop Windows
 **/
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class frm_crud : Form
    {
        public frm_crud()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void frm_crud_Load(object sender, EventArgs e)
        {
            DataEHora_Tick(e, e); //Atualização do Evento
            AdministracaoDEBanco test = new AdministracaoDEBanco();
            // Condições ao Conectar
            if (test.conectar())
            {
                MessageBox.Show("Conectado ao Banco");

            }
            else
            {
                MessageBox.Show("Não conseguiu conectar ao Banco!");
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        // Metodo privado do componente DataEHora
        private void DataEHora_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now; //Pega o componente DataEHora e coloca um DateTIme para exibir a mesma hora do Computador
            toolStripStatusLabel1.Text = " Hoje é " + dataHora.ToLongDateString() + " | Hora: " + dataHora.ToLongTimeString(); //Nome da Label e o que será exibido dentro dela
  
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Atualizacao
        public void TestUpdate()
        {

            AdministracaoDEBanco obj = new AdministracaoDEBanco();

            ArrayList arr = new ArrayList();
            // [NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL],[CIDADE],[UF],[NOME_PAI],[NOME_MAE]
            try
            {

                arr.Add(1);
                arr.Add("Denis");
                arr.Add(18);
                arr.Add("Sao Paulo");
                arr.Add("2035 5387");
                arr.Add("teste@teste.com");
                arr.Add("Sao Paulo");
                arr.Add("SP");
                arr.Add("Denilton");
                arr.Add("Derpina");



                if (obj.Update(arr))
                {
                    MessageBox.Show("Atualizado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não Atualizado", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro ocorrido");
            }
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            AdministracaoDEBanco obj = new AdministracaoDEBanco();

            ArrayList arr = new ArrayList();
            // [NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL],[CIDADE],[UF],[NOME_PAI],[NOME_MAE]
            try
            {
 
                arr.Add(txtNome.Text);
                arr.Add("12");
                arr.Add("Sao Paulo");
                arr.Add("123");
                arr.Add("Teia@seila.com");
                arr.Add("Sao Paulo");
                arr.Add("SP");
                arr.Add("Elveino");
                arr.Add("Derpina");
                
                     

            if (obj.Insert(arr))
            {
                MessageBox.Show("Cadastrado com sucesso","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

         catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro ocorrido");
            }
    }



   
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            AdministracaoDEBanco obj = new AdministracaoDEBanco();

            int codAluno = int.Parse(txtExcluir.Text);

            if (obj.Delete(codAluno))
            {
                MessageBox.Show("om sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgExcluir_Enter(e, e);
            }
            else
            {
                MessageBox.Show("Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TestUpdate();

        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }

        private void dgEditar_Enter(object sender, EventArgs e)
        {
            AdministracaoDEBanco obj = new AdministracaoDEBanco();

            dgEditar.DataSource = obj.ListaGrid();
        }

        private void dgExcluir_Enter(object sender, EventArgs e)
        {
            AdministracaoDEBanco obj = new AdministracaoDEBanco();

            dgExcluir.DataSource = obj.ListaGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Botão Radio de Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            AdministracaoDEBanco obj = new AdministracaoDEBanco();
            string Tiposql;

            if(radioNome.Checked)
            {
                //Quando for Nome o Array vai retornar os campos
                Tiposql = "SELECT [NOME] AS Nome ,[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS WHERE NOME LIKE @VALOR";
                dgPesquisa.DataSource = obj.Pesquisar(Tiposql, "%"+txtPesquisa.Text+"%");            
            }
            else
            {
                //Quando não for Nome (Código/Id) o Array vai retornar os campos
                Tiposql = "SELECT [NOME] AS Nome ,[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS WHERE ID_ALUNO LIKE @VALOR";
                dgPesquisa.DataSource = obj.Pesquisar(Tiposql, "%" + txtPesquisa.Text + "%");
            }
        }

        private void txtExcluir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
}
    }
