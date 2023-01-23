using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class LessonManageActDeact : MonoBehaviour
{
    private string connectionString;
    private string sqlQuery;
    public Button TOF;
    public Button DnD;
    public Button Microscope;
    public Button SnV; 

    void Start()
    {
        connectionString = "Data Source = C:\\Users\\Ian\\OneDrive\\Documents\\VirtualLab\\VirtualLab.db";
    }
    void Update(){
        CheckActiveInactiveLesson();
    }

    public void CheckActiveInactiveLesson(){
        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {
                //start
                sqlQuery = "SELECT LessonStatus FROM LessonsTBL WHERE LessonName = 'ToF';";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        string Status = reader.GetString(0);
                        if (Status == "Enabled"){
                            TOF.interactable = true;
                        }else{
                            TOF.interactable = false;
                        }
                        Debug.Log(Status); 
                    }
                    reader.Close();
                }
                dbCmd.ExecuteNonQuery();
                //end
                sqlQuery = "SELECT LessonStatus FROM LessonsTBL WHERE LessonName = 'DnD';";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        string Status = reader.GetString(0);
                        
                        if (Status == "Enabled"){
                            DnD.interactable = true;
                        }else{
                            DnD.interactable = false;
                        }
                        Debug.Log(Status); 
                    }
                    reader.Close();
                }
                dbCmd.ExecuteNonQuery();
                //end
                sqlQuery = "SELECT LessonStatus FROM LessonsTBL WHERE LessonName = 'Microscope';";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        string Status = reader.GetString(0);
                        
                        if (Status == "Enabled"){
                            Microscope.interactable = true;
                        }else{
                            Microscope.interactable = false;
                        }
                        Debug.Log(Status); 
                    }
                    reader.Close();
                }
                dbCmd.ExecuteNonQuery();
                //end
                sqlQuery = "SELECT LessonStatus FROM LessonsTBL WHERE LessonName = 'SnV';";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        string Status = reader.GetString(0);
                        if (Status == "Enabled"){
                            SnV.interactable = true;
                        }else{
                            SnV.interactable = false;
                        }
                        Debug.Log(Status); 
                    }
                    reader.Close();
                }
                dbCmd.ExecuteNonQuery();
                //end
            }
            dbConnection.Close();
        }
    }

}
