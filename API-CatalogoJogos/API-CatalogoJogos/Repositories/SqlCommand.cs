using System;

namespace API_CatalogoJogos.Repositories
{
    internal class SqlCommand
    {
        private string comando;
        private SqlConnection sqlConnection;

        public SqlCommand(string comando, SqlConnection sqlConnection)
        {
            this.comando = comando;
            this.sqlConnection = sqlConnection;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}