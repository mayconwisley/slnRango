using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;

namespace Banco
{
    public class Crud : Conexao
    {
        FbParameterCollection fbParameterCollection = new FbCommand().Parameters;
        FbCommand fbCommand = null;

        public void LimparParametros()
        {
            fbParameterCollection.Clear();
        }
        public void AdicionarParamentro(string parametro, object valor)
        {
            fbParameterCollection.Add(new FbParameter(parametro, valor));
        }

        public object Executar(CommandType commandType, string sql)
        {
            if (Conectar())
            {
                try
                {
                    fbCommand = fbConnection.CreateCommand();
                    fbCommand.CommandType = commandType;
                    fbCommand.CommandText = sql;
                    fbCommand.CommandTimeout = 7200;

                    foreach (FbParameter item in fbParameterCollection)
                    {
                        fbCommand.Parameters.Add(new FbParameter(item.ParameterName, item.Value));
                    }
                    return fbCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public DataTable Tabela(CommandType commandType, string sql)
        {
            if (Conectar())
            {
                try
                {
                    fbCommand = fbConnection.CreateCommand();
                    fbCommand.CommandType = commandType;
                    fbCommand.CommandText = sql;
                    fbCommand.CommandTimeout = 7200;

                    foreach (FbParameter item in fbParameterCollection)
                    {
                        fbCommand.Parameters.Add(new FbParameter(item.ParameterName, item.Value));
                    }
                    FbDataAdapter fbDataAdapter = new FbDataAdapter(fbCommand);
                    DataTable dataTable = new DataTable();
                    fbDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    Desconectar();
                }
            }
            else
            {
                return null;
            }
        }
    }
}
