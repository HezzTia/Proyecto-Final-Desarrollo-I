using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace ProyectoFinal
{
    internal class Robert
    {
        static void Nobody()
        {
            ConnectDB();
        }

        static void ConnectDB()
        {
            string vConnectionString = @"Data Source=./SharpMe.db";
            SQLiteConnection vSQLCon = new SQLiteConnection(vConnectionString);
            vSQLCon.Open();
        }
        static void CreateTable()
        {
            string vConnectionString = @"Data Source=./SharpMe.db";
            SQLiteConnection vSQLCon = new SQLiteConnection(vConnectionString);
            vSQLCon.Open();

            string vCreateT = "CREATE TABLE [USERS] (" +
                "[ID] TEXT NULL, " +
                "[UserID] TEXT NULL, " +
                "[Nombre] TEXT NULL, " +
                "[Apellidos] TEXT NULL, " +
                "[Password] TEXT NULL " +
                ")";

            using (SQLiteTransaction vDBTrans = vSQLCon.BeginTransaction())
            {
                SQLiteCommand vSQLCommand = new SQLiteCommand(vCreateT, vSQLCon);
                vSQLCommand.ExecuteNonQuery();
                vSQLCommand.Dispose();

                vDBTrans.Commit();

                vSQLCon.Close();
            }
        }
    }
}
