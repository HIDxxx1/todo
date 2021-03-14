using System.Configuration;
using System.Data.SqlClient;

namespace Momo.Objects
{
    internal static class SQLServerHelper
    {
        internal static string ConnectionString = @"";

        static SQLServerHelper()
        {
            //SQLserverのサーバー名

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource =
                ConfigurationManager.AppSettings["DataSource"];
            builder.InitialCatalog =
                ConfigurationManager.AppSettings["InitialCatalog"];
            builder.IntegratedSecurity =
                ConfigurationManager.AppSettings["IntegratedSecurity"] == "1";
            builder.UserID =
                ConfigurationManager.AppSettings["UserID"];
            builder.Password =
                ConfigurationManager.AppSettings["Password"];

            //接続文字列
            ConnectionString = builder.ToString();
        }

        /// <summary>
        /// SQL実行するための共通関数
        /// </summary>
        /// <param name="sql">SQL文字列</param>
        /// <param name="parameters">SQL文字列を配列</param>
        internal static void Execute(
            string sql,
            SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if(parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.ExecuteNonQuery();
            }
        }
    }
}
