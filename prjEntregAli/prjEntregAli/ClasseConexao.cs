﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

class ClasseConexao
{
    SqlConnection conexao = new SqlConnection();

    //(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
    // pega a string da app.config
    private SqlConnection conectar()
    {
        try
        {
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            conexao.Open();
            return conexao;
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro de conexão com banco de dados: " + erro.Message);
            desconectar();
            return null;
        }
    }

    public void desconectar()
    {
        try
        {
            if ((conexao.State == ConnectionState.Open))
            {
                conexao.Close();
                conexao.Dispose();
                conexao = null;
            }
        }
        catch (Exception erro) {
            throw erro;
        }
    }

    public DataTable executa_sql(String comando_sql)
    {
        try
        {
            conectar();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            if (comando_sql.StartsWith("insert"))
           {
                //throw new Exception("Não houve retorno de saída da instância SQL(insert)");
                return null;
                //return "No output was returned from the SQL instance."
            }
            else if (comando_sql.StartsWith("update"))
            {
                //throw new Exception("Não houve retorno de saída da instância SQL(update)");
                return null;
            }
            else if (comando_sql.StartsWith("delete"))
            {
                //throw new Exception("Não houve retorno de saída da instância SQL(delete)");
                return null;
            }

            else
            {
                return ds.Tables[0];
            }
        }
            catch (SqlException erro)
        {            
            //MessageBox.Show("Atenção: " + erro.Message);
            throw erro;
        }
        finally
        {
            desconectar();
        }
    }


}