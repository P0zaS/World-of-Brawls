using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class Database : MonoBehaviour
{
    private string dbName = @"URI=file:WoB.db";
    void Start()
    {
        CreateDB();
    }

    private void CreateDB()
    {
        using(var conn = new SqliteConnection(dbName))
        {
            conn.Open();


            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS players_history (Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    " WinnerID int, WinnerSprite int, Name VARCHAR, P1Score VARCHAR, P2Score VARCHAR, Date VARCHAR);";
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
  
}
