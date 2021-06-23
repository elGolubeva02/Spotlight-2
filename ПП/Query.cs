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
                    MessageBox.Show("Good luck to you!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
        public int Autorise2(string l, string p)
        {

            int kode;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select КодУченика From Ученик Where Фамилия = @l and Имя = @p ", connection);
            command.Parameters.AddWithValue("l", l);
            command.Parameters.AddWithValue("p", p);
            kode = (int)command.ExecuteScalar();
            connection.Close();
            return kode;
        }
        public int Color1(int KodY)
        {
            int Count;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select COUNT(*) From Module1 Where КодУченика = @KodY ", connection);
            command.Parameters.AddWithValue("KodY", KodY);
            Count = (int)command.ExecuteScalar();
            connection.Close();
            return Count;
        }
        public int Color2(int KodY)
        {
            int Count2;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select COUNT(*) From Module2 Where КодУченика = @KodY ", connection);
            command.Parameters.AddWithValue("KodY", KodY);
            Count2 = (int)command.ExecuteScalar();
            connection.Close();
            return Count2;
        }
        public int Color3(int KodY)
        {
            int Count3;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select COUNT(*) From Module3 Where КодУченика = @KodY ", connection);
            command.Parameters.AddWithValue("KodY", KodY);
            Count3 = (int)command.ExecuteScalar();
            connection.Close();
            return Count3;
        }
        public int Color4 (int KodY)
        {
            int Count4;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select COUNT(*) From Module4 Where КодУченика = @KodY ", connection);
            command.Parameters.AddWithValue("KodY", KodY);
            Count4 = (int)command.ExecuteScalar();
            connection.Close();
            return Count4;
        }
        public int Color5(int KodY)
        {
            int Count5;
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            command = new OleDbCommand("Select COUNT(*) From Module5 Where КодУченика = @KodY ", connection);
            command.Parameters.AddWithValue("KodY", KodY);
            Count5 = (int)command.ExecuteScalar();
            connection.Close();
            return Count5;
        }
        public DataTable Modul1(int КодУченика, bool Задание1, bool Задание2, bool Задание3)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            if (bufferTable.Rows.Count == 0)
            {
                 command = new OleDbCommand($"INSERT INTO Module1 (КодУченика, Задание1, Задание2, Задание3) VALUES ( @КодУченика, @Задание1, @Задание2, @Задание3)", connection);
                 command.Parameters.AddWithValue("КодУченика", КодУченика);
                 command.Parameters.AddWithValue("Задание1", Задание1);
                 command.Parameters.AddWithValue("Задание2", Задание2);
                 command.Parameters.AddWithValue("Задание3", Задание3);
                 dAdapt.SelectCommand = command;
                 bufferTable.Clear();
                 dAdapt.Fill(bufferTable);
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
        public DataTable Modul2(int КодУченика, bool Задание1, bool Задание2, bool Задание3)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            if (bufferTable.Rows.Count == 0)
            {
                command = new OleDbCommand($"INSERT INTO Module2 (КодУченика, Задание1, Задание2, Задание3) VALUES ( @КодУченика, @Задание1, @Задание2, @Задание3)", connection);
                command.Parameters.AddWithValue("КодУченика", КодУченика);
                command.Parameters.AddWithValue("Задание1", Задание1);
                command.Parameters.AddWithValue("Задание2", Задание2);
                command.Parameters.AddWithValue("Задание3", Задание3);
                dAdapt.SelectCommand = command;
                bufferTable.Clear();
                dAdapt.Fill(bufferTable);
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
        public DataTable Modul4(int КодУченика, bool Задание1, bool Задание2, bool Задание3)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            if (bufferTable.Rows.Count == 0)
            {
                command = new OleDbCommand($"INSERT INTO Module4 (КодУченика, Задание1, Задание2, Задание3) VALUES ( @КодУченика, @Задание1, @Задание2, @Задание3)", connection);
                command.Parameters.AddWithValue("КодУченика", КодУченика);
                command.Parameters.AddWithValue("Задание1", Задание1);
                command.Parameters.AddWithValue("Задание2", Задание2);
                command.Parameters.AddWithValue("Задание3", Задание3);
                dAdapt.SelectCommand = command;
                bufferTable.Clear();
                dAdapt.Fill(bufferTable);
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
        public DataTable Modul5(int КодУченика, bool Задание1, bool Задание2, bool Задание3)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            if (bufferTable.Rows.Count == 0)
            {
                command = new OleDbCommand($"INSERT INTO Module5 (КодУченика, Задание1, Задание2, Задание3) VALUES ( @КодУченика, @Задание1, @Задание2, @Задание3)", connection);
                command.Parameters.AddWithValue("КодУченика", КодУченика);
                command.Parameters.AddWithValue("Задание1", Задание1);
                command.Parameters.AddWithValue("Задание2", Задание2);
                command.Parameters.AddWithValue("Задание3", Задание3);
                dAdapt.SelectCommand = command;
                bufferTable.Clear();
                dAdapt.Fill(bufferTable);
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
        public DataTable Modul3(int КодУченика, bool Задание1, bool Задание2, bool Задание3)
        {
            connection.Open();
            OleDbDataAdapter dAdapt = new OleDbDataAdapter();
            bufferTable.Clear();
            if (bufferTable.Rows.Count == 0)
            {
                command = new OleDbCommand($"INSERT INTO Module3 (КодУченика, Задание1, Задание2, Задание3) VALUES ( @КодУченика, @Задание1, @Задание2, @Задание3)", connection);
                command.Parameters.AddWithValue("КодУченика", КодУченика);
                command.Parameters.AddWithValue("Задание1", Задание1);
                command.Parameters.AddWithValue("Задание2", Задание2);
                command.Parameters.AddWithValue("Задание3", Задание3);
                dAdapt.SelectCommand = command;
                bufferTable.Clear();
                dAdapt.Fill(bufferTable);
            }
            connection.Close();
            Debug.Write(bufferTable);
            return bufferTable;
        }
    }
}
