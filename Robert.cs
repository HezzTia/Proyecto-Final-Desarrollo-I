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
        }

        static void ConnectDB()
        {
            string vConnectionString = @"Data Source=SharpMe";
            SQLiteConnection vSQLCon = new SQLiteConnection(vConnectionString);
            vSQLCon.Open();
        }

        //static void QueryDB()
        //{
        //    string DBConn = @"Data Source=SharpMe.mdf;
        //                    AttachDbFilename=[DataDirectory]\SharpMe.mdf;
        //                    Integrated Security=True;User Interface=True;";

        //    SQLiteConnection vSQLCon = new SQLiteConnection(DBConn);
        //    vSQLCon.Open();

        //    string vGetUsers = "SELECT * FROM [Users]";

        //    using (SQLiteTransaction vTransaction = vSQLCon.BeginTransaction())
        //    {
        //        SQLiteCommand vCommand = new SQLiteCommand(vGetUsers, vSQLCon);
        //        vCommand.ExecuteNonQuery();
        //        vCommand.Dispose();

        //        vTransaction.Commit();
        //        vSQLCon.Close();
        //    }
        //}

        static void CreateTables()
        {
            string CreateUsersT = @"CREATE TABLE IF NOT EXISTS [Users] (
                                  [Id]          INT IDENTITY(1, 1) NOT NULL,
                                  [User]        NVARCHAR(15) NOT NULL,
                                  [FirstName]   NVARCHAR(50) NOT NULL,
                                  [LastName]    NVARCHAR(50) NOT NULL,
                                  [MailAddress] NVARCHAR(25) NOT NULL,
                                  [BirthDate]   DATE NOT NULL,
                                  [Sexo]        INT NOT NULL,
                                  [Password]    VARCHAR(128) NOT NULL)";

            string CreateGradesT = @"CREATE TABLE IF NOT EXISTS [Grades] (
                                   [UserId]  INT IDENTITY (1, 1) NOT NULL,
                                   [M1Grade] INT NULL,
                                   [M2Grade] INT NULL,
                                   [M3Grade] INT NULL,
                                   [M4Grade] INT NULL,
                                   [M5Grade] INT NULL,
                                   [FGrade]  INT NULL)";

            SQLiteConnection.CreateFile("SharpMe.db");
            using (SQLiteConnection vCon = new SQLiteConnection(@"Data Source=SharpMe.db"))
            {
                using (SQLiteCommand vCommand = new SQLiteCommand(vCon))
                {
                    vCon.Open();
                    vCommand.CommandText = CreateUsersT;
                    vCommand.ExecuteNonQuery();

                    vCommand.CommandText = CreateGradesT;
                    vCommand.ExecuteNonQuery();

                    vCommand.CommandText = "SELECT * FROM [Users]";

                    using (SQLiteDataReader vDataReader = vCommand.ExecuteReader())
                    {
                        while (vDataReader.Read())
                        {
                            Console.WriteLine(vDataReader.GetString(0));
                        }
                    }
                    vCon.Close();
                }
            }
        }
    }
}
