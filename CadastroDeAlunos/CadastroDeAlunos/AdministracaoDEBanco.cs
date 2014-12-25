using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CadastroDeAlunos
{
    class AdministracaoDEBanco
    {
        // Conexao com o Banco em .MDF
        private const string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Cursos\Desktop\Visual C#\CadastroDeAlunos\CadastroDeAlunos\CURD_ALUNOS.mdf;Integrated Security=True";
        
        private string vsql = String.Empty;
        SqlConnection objCon = null;

    #region "Metodos de Conexão com o Banco"
        public bool conectar()
        {
            objCon = new SqlConnection(str);

            //Testar conexao
            try
            {
                // Abrir conexao
                objCon.Open();
                return true;
            }
            catch
            {
                // Não consegui abrir conexao
                return false;
            }

        }

        private bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
    #endregion

     #region "Metodos de Execução de SQL"
        // Inserir
        public bool Insert(ArrayList p_arrInsert) {

            vsql = "INSERT INTO CRUD_ALUNOS ([NOME],[IDADE],[ENDERECO],[TELEFONE],[EMAIL],[CIDADE],[UF],[NOME_PAI],[NOME_MAE])" +
     "VALUES (@NOME, @IDADE ,@ENDERECO ,@TELEFONE ,@EMAIL ,@CIDADE ,@UF ,@NOME_PAI ,@NOME_MAE);";

            SqlCommand objcmd = null;


            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrInsert[0]));
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_arrInsert[1]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_arrInsert[2]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrInsert[3]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_arrInsert[4]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrInsert[5]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_arrInsert[6]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_arrInsert[7]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_MAE", p_arrInsert[8]));

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlLer)
                {
                    throw sqlLer;
                }
                finally {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        
        }
        // Atualizar
        public bool Update(ArrayList p_arrUpdate) {

            // Pegar os valores da tabela e substituir, quando o ID do aluno for igual a ID do aluno preenchido no campo
            vsql = "UPDATE CRUD_ALUNOS SET NOME = @NOME, IDADE = @IDADE, ENDERECO = @ENDERECO, TELEFONE = @TELEFONE, EMAIL = @EMAIL, CIDADE = @CIDADE, UF = @UF, NOME_PAI = @NOME_PAI, NOME_MAE = @NOME_MAE WHERE ID_ALUNO = @ID_ALUNO";

            //Objeto de Comando
            SqlCommand objcmd = null;


            if (this.conectar())
            {
                // Tenta
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@ID_ALUNO", p_arrUpdate[0]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrUpdate[1]));
                    objcmd.Parameters.Add(new SqlParameter("@IDADE", p_arrUpdate[2]));
                    objcmd.Parameters.Add(new SqlParameter("@ENDERECO", p_arrUpdate[3]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrUpdate[4]));
                    objcmd.Parameters.Add(new SqlParameter("@EMAIL", p_arrUpdate[5]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrUpdate[6]));
                    objcmd.Parameters.Add(new SqlParameter("@UF", p_arrUpdate[7]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_PAI", p_arrUpdate[8]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME_MAE", p_arrUpdate[9]));
                    
                    //Executa os comandos
                    objcmd.ExecuteNonQuery();
                    //Retorna verdadeiro
                    return true;
                }
                catch (SqlException sqlLer)
                {
                    throw sqlLer;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        
        }
        // Deletar
        public bool Delete(int id_aluno) {

            // Pegar os valores da tabela e substituir, quando o ID do aluno for igual a ID do aluno preenchido no campo
            vsql = "DELETE FROM CRUD_ALUNOS WHERE ID_ALUNO = @ID_ALUNO";

            //Objeto de Comando
            SqlCommand objcmd = null;


            if (this.conectar())
            {
                // Tenta
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@ID_ALUNO", id_aluno);                    

                    objcmd.ExecuteNonQuery();
                    //Retorna verdadeiro
                    return true;
                }
                catch (SqlException sqlLer)
                {
                    throw sqlLer;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }
    #endregion

    //#region "Metodos de Listagem e Pesquisa"
    //    // Exibir
        public DataTable ListaGrid() {
            // Pegar os valores da tabela e substituir, quando o ID do aluno for igual a ID do aluno preenchido no campo
            vsql = "SELECT [ID_ALUNO] AS Código, [NOME] AS Nome ,[IDADE],[ENDERECO],[TELEFONE],[EMAIL] FROM CRUD_ALUNOS";

            //Objeto de Comando
            SqlCommand objcmd = null;


            if (this.conectar())
            {
                // Tenta
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    //objcmd.ExecuteNonQuery();
                    //Retorna verdadeiro
                    return dt;
                }
                catch (SqlException sqlLer)
                {
                    throw sqlLer;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }
        // Pesquisar
            public DataTable Pesquisar(string Textosql, string param) {

                // Pegar os valores da tabela e substituir, quando o ID do aluno for igual a ID do aluno preenchido no campo
               this.vsql = Textosql;

                //Objeto de Comando
                SqlCommand objcmd = null;


                if (this.conectar())
                {
                    // Tenta
                    try
                    {
                        objcmd = new SqlCommand(vsql, objCon);
                        objcmd.Parameters.Add(new SqlParameter("@VALOR", param));
                        SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        //objcmd.ExecuteNonQuery();
                        //Retorna verdadeiro
                        return dt;
                    }
                    catch (SqlException sqlLer)
                    {
                        throw sqlLer;
                    }
                    finally
                    {
                        this.desconectar();
                    }
                }
                else
                {
                    return null;
                }

            }
        //    #endregion
    
    }
}
