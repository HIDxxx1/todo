using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momo.Objects
{
   internal static class SQLServerHelper
    {
        internal static string ConnectionString = @"";

        static SQLServerHelper()
        {
            var builder = new SqlConnectionStringBuilder();
            //SQLserverのサーバー名
            builder.DataSource = @"DESKTOP-E5AQK36\SQLEXPRESS";
            //データベース名
            builder.InitialCatalog = "Mono";
            //認証方法
            builder.IntegratedSecurity = true;
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
