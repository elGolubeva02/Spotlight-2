using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public DataTable Registracia(string Фамилия, string Имя)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            try
            {
                if (bufferTable.Rows.Count == 0)
                {
                    command = new OleDbCommand($"INSERT INTO Ученик (Фамилия, Имя) VALUES ( @Фамилия, @Имя)", connection);
                    command.Parameters.AddWithValue("Фамилия", Фамилия);
                    command.Parameters.AddWithValue("Имя", Имя);
                    dAdapt.SelectCommand = command;
                    bufferTable.Clear();
                    dAdapt.Fill(bufferTable);
                    MessageBox.Show("Вы успешно зарегистрировались!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
    }
}
