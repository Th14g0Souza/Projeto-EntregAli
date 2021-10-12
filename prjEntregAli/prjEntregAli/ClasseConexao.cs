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

    SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
    // pega a string da app.config
    private SqlConnection conectar()
    {
        try
        {
            //String strConexao = "Password=12345; Persist Security Info=True; User ID=sa; Initial Catalog=PetLabDB; Data Source=" + Environment.MachineName + "\\SQLSERVER01";

            //String strConexao = "Password=12345; Persist Security Info=True; User ID=aluno; Initial Catalog=PetLabDB; Data Source=" + Environment.MachineName + "\\SQLSERVER01";
            //String strConexao = "Server=15.0.2080.9;Initial Catalog=EntregAliDB;Password=ths2409; User ID=thsouza; Integrated Security=True;Connect Timeout=20;Data Source=" + Environment.MachineName; //+ "\\SQLEXPRESS";
            //conexao.ConnectionString = strConexao;
            conexao.Open();
            return conexao;
        }
        catch (Exception erro)
        {
            MessageBox.Show("Erro de conexão com banco de dados");
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
        catch (Exception erro) { }
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
            else
            {
                return ds.Tables[0];
            }
        }
        catch
        {            
            //MessageBox.Show("Atenção: " + erro);
            return null;
        }
        finally
        {
            desconectar();
        }
    }


}