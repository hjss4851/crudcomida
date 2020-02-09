using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receitas
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
             

            
            txt_itens.Enabled = false;
            txt_modo.Enabled = false;
            txt_nome.Enabled = false;
            txt_pesquisa.Enabled = false;
            txt_rendimento.Enabled = false;
            txt_tempo.Enabled = false;
            
        }

        SqlConnection sqlcon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=cliente;Data Source=LAPTOP-2O1J5EQD\SQLEXPRESS";
        private string strSql = string.Empty;

        private void btn_add_Click(object sender, EventArgs e)
        
        {
         

        txt_itens.Enabled = true;
            txt_modo.Enabled = true;
            txt_nome.Enabled = true;
            txt_pesquisa.Enabled = true;
            txt_rendimento.Enabled = true;
            txt_tempo.Enabled = true;
        }

        private void btn_sss_Click(object sender, EventArgs e)
        {
            strSql = "insert into hjss (nome,rendimento,tempodepreparo,mododepreparo,ingredientes) values (@nome,@rendimento,@tempodepreparo,@mododepreparo,@ingredientes)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando =  new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@rendimento", SqlDbType.VarChar).Value = txt_rendimento.Text;
            comando.Parameters.Add("@tempodepreparo", SqlDbType.VarChar).Value = txt_tempo.Text;
            comando.Parameters.Add("@mododepreparo", SqlDbType.VarChar).Value = txt_modo.Text;
            comando.Parameters.Add("@ingredientes", SqlDbType.VarChar).Value = txt_itens.Text;



           
            sqlcon.Open();

            comando.ExecuteNonQuery();

            MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");
            
            /*
             * try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");

            }

            catch(Exception ex){

                MessageBox.Show(ex.Message);

            
            }

            finally
            */
            {
                sqlcon.Close();

                txt_pesquisa.Enabled = true;

                txt_itens.Clear();
                txt_modo.Clear();
                txt_nome.Clear();
                txt_pesquisa.Clear();
                txt_rendimento.Clear();
                txt_tempo.Clear();

            }

        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            /*
             * LEMBRAR DE COLOCAR O VEZES RSRS
             * 
             */ 
             
            strSql = "select*from hjss where nome=@pesquisa";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_pesquisa.Text;

            try
            {
                if(txt_pesquisa.Text == string.Empty)
                {

                    MessageBox.Show("VOCE NÃO DIGITOU O NOME.");
                    
                }

                sqlcon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)

                {
                    throw new Exception("ESTE NOME NÃO ESTA CADASTRADO");

                    
                }

                dr.Read();

                txt_nome.Text = Convert.ToString(dr["nome"]);
                txt_itens.Text = Convert.ToString(dr["ingredientes"]);
                txt_modo.Text = Convert.ToString(dr["mododepreparo"]);
                txt_rendimento.Text = Convert.ToString(dr["rendimento"]);
                txt_tempo.Text = Convert.ToString(dr["tempodepreparo"]);

            }

            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
                
            }

            finally
            {
                sqlcon.Close();

                txt_pesquisa.Clear();

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            strSql = "update hjss set nome=@nome, rendimento=@rendimento, tempodepreparo=@tempodepreparo, mododepreparo=@mododepreparo, ingredientes=@ingredientes";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlcon);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@rendimento", SqlDbType.VarChar).Value = txt_rendimento.Text;
            comando.Parameters.Add("@tempodepreparo", SqlDbType.VarChar).Value = txt_tempo.Text;
            comando.Parameters.Add("@mododepreparo", SqlDbType.VarChar).Value = txt_modo.Text;
            comando.Parameters.Add("@ingredientes", SqlDbType.VarChar).Value = txt_itens.Text;

            try
            {
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO");

                
            }

            catch(Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally
            {

                sqlcon.Close();

                txt_itens.Clear();
                txt_modo.Clear();
                txt_nome.Clear();
                txt_pesquisa.Clear();
                txt_rendimento.Clear();
                txt_tempo.Clear();

            }
        }
    }
}
