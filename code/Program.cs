using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApp12
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*
            Database databaseObject = new Database();

            string query = "INSERT INTO albums ('title','artist') VALUES (@title, @artist)";
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            myCommand.Parameters.AddWithValue("@title", "dande");
            myCommand.Parameters.AddWithValue("@artist", "vinidi");
            var result = myCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();
     */   
     }

    }
}
