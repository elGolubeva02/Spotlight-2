using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПП
{
    public class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
    }
}
