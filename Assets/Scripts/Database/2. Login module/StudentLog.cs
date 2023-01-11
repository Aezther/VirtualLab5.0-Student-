using Mono.Data.Sqlite;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using Unity.VisualScripting;

public class StudentLog : MonoBehaviour
{

    public StudentLogin script;
    private string connectionString;
    private string sqlQuery;
    private string StudentIDInfo;
    void Start()
    {
        connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        //GetandAddUserLoggedInTimeAndDate();
    }

    public void FetchData() {
        //timeLoggedIn = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm:ss tt");
        //Debug.Log("Logged in at: " + time);

        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {

                //start
                //sqlQuery = "SELECT StudentID FROM StudentsTBL WHERE Username = '" + UserIF.text + "';";
                //sqlQuery = "INSERT INTO StudentSessionsTBL (Action, Time, StudentID) VALUES ('Login','sanagumanaka','1');";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        StudentIDInfo = reader.GetInt32(0).ToString();
                        Debug.Log(StudentIDInfo);
                    }
                    reader.Close();
                }
                dbConnection.Close();
            }
        }
    }
}
