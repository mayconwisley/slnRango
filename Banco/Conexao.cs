using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;

namespace Banco
{
    public class Conexao
    {
        protected FbConnection fbConnection;


        protected bool Conectar()
        {
            string strDiretorioBase = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string strConexao = $@"User = rango; Password = rango159; ServerType = 1; DataBase = {strDiretorioBase}Banco\Rango.fdb";

            fbConnection = new FbConnection(strConexao);
            try
            {
                fbConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        protected bool Desconectar()
        {
            try
            {
                if (fbConnection.State != ConnectionState.Closed)
                {
                    fbConnection.Close();
                    fbConnection.Dispose();
                    return true;
                }
                else
                {
                    fbConnection.Dispose();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
