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
using static UnityEngine.UIElements.UxmlAttributeDescription;
using System.Xml.Linq;

public class LogoutScript : MonoBehaviour
{

    [SerializeField] StudentInfo userInfo;


    private string timeLoggedOut;
    private string sqlQuery;
    private string connectionString;

    
    void Awake(){

    }
    void Start()
    {
        //connectionString = "Data Source =C:\\Users\\oliva\\Documents\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";

        connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        //connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
    }

    //LOGOUT FUNCTION
    public void LogoutProceedToLogin(){

        Debug.Log(userInfo.StudentID);

        InsertStudentLogOutDateAndTime();

        userInfo.StudentID = "";
        userInfo.StudentName = "";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("2. Login Screen");
        Debug.Log(userInfo.StudentID);

    }
    public void InsertStudentLogOutDateAndTime(){

        timeLoggedOut = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm:ss tt");
        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {
                sqlQuery = "INSERT INTO StudentSessionsTBL (Action, Time, StudentID) VALUES ('Log Out','"+ timeLoggedOut +"','" + userInfo.StudentID + "');";
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
    }

    //MAIN MENU BUTTON
    public void ProceedToMainMenu(){
        SceneManager.LoadScene("3. Student's Dashboard");
    }
}
