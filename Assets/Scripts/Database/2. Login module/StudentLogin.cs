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

public class StudentLogin : MonoBehaviour {
    

    public string StudentIDInfo = "Show this message";

    [Header("ACCESS SCENES")]
    public static StudentLogin studentLogin;
    public string Student_name;

 
    public Animator transition;
    [Header("INPUTFIELD FOR SHOWPASSWORD")]
    public TMP_InputField PasswordShow;


    [Header("INPUTFIELD MAIN")]
    public TMP_InputField PassIF;
    public TMP_InputField UserIF;

    [Header("GAMEOBJECT FOR ERRORS")]
    public TextMeshProUGUI UserError;
    public TextMeshProUGUI PasswordError;

    //VARIABLES USED FOR SQLITE DATABASE
    private string connectionString;
    private string sqlQuery;
    //private string StudentIDInfo;
    private string timeLoggedIn;

    [SerializeField] StudentInfo userInfo;
    

    void Start() {
        connectionString = "Data Source =C:\\Users\\oliva\\Documents\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        
        //connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        //connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        //connectionString = @"Data Source =C:\\192.168.1.49\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db ";
        //ReadDBserver();

    }

    //USED ONLY FOR ACCESSING ANOTHER SCRIPT
    private void Awake() {
        if (studentLogin == null) {
            studentLogin = this;
            //DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }


    public bool StudentLoginVerify() 
    {
        bool isValidLogin = false;
        bool isExistingUsername = false;
        bool isExistingPass = false;

        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) 
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) 
            {

               

                //READING THE DATABASE
                //USERNAME
                sqlQuery = "SELECT Username FROM StudentsTBL";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        string DBUsername = reader.GetString(0);
                        if (UserIF.text == DBUsername && !string.IsNullOrEmpty(UserIF.text))
                        {
                            UserError.text = "";
                            isExistingUsername = true;

                        }
                        else
                        {
                            if (string.IsNullOrEmpty(UserIF.text))
                            {
                                UserError.text = "Username is empty.";
                            }
                            if (!string.IsNullOrEmpty(UserIF.text))
                            {
                                UserError.text = "";
                            }
                            if (UserIF.text != DBUsername && !string.IsNullOrEmpty(UserIF.text))
                            {
                                UserError.text = "";
                                UserError.text = "Invalid username.";
                            }
                        }
                        //Debug.Log("Usernames are: " + DBUsername);
                    }
                    reader.Close();
                }
                //PASSWORD
                sqlQuery = "SELECT Password FROM StudentsTBL";
                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        string DBPassword = reader.GetString(0);

                        if (PassIF.text == DBPassword && !string.IsNullOrEmpty(PassIF.text))
                        {
                            PasswordError.text = "";
                            isExistingPass = true;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(PassIF.text))
                            {
                                PasswordError.text = "Passwords is empty.";
                            }
                            if (!string.IsNullOrEmpty(PassIF.text))
                            {
                                PasswordError.text = "";
                            }
                            if (UserIF.text != DBPassword && !string.IsNullOrEmpty(PassIF.text))
                            {
                                PasswordError.text = "";
                                PasswordError.text = "Invalid password.";
                            }
                        }
                        //Debug.Log("Passwords are: " + DBPassword);
                    }
                    reader.Close();
                }

                // ONLY CHECK IF USERNAME AND PASS MATCHES WHEN BOTH EXISTS IN THE DATABASE
                if (isExistingUsername && isExistingPass)
                {
                    // CHECK IF USERNAME AND PASSWORD MATCHES
                    sqlQuery = "SELECT Username, Password FROM StudentsTBL";
                    dbCmd.CommandText = sqlQuery;


                    using (IDataReader reader = dbCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string DBUsername = reader.GetString(0);
                            string DBPassword = reader.GetString(1);

                            if (DBUsername == UserIF.text && DBPassword == PassIF.text)
                            {

                                // return = true
                                PasswordError.text = "";
                                UserError.text = "";
                                isValidLogin = true;
                                break;
                            }
                            else
                            {
                                isValidLogin = false;
                            }
                        }
                        reader.Close();
                    }
                }
        
                dbConnection.Close();
            }
        }
        Debug.Log("Username: " + isExistingUsername + " Pass: " + isExistingPass + "Match:" + isValidLogin);
        return isValidLogin;
    }

    //METHOD TO: GET USERS CREDENTIAL FROM THE ROW
    public void GetUserCredentials() 
    {

        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {


                sqlQuery = "SELECT Firstname, Lastname FROM StudentsTBL WHERE Username = '" + UserIF.text + "';";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) {
                    while (reader.Read()) {
                        string Firstname = reader.GetString(0);
                        string Lastname = reader.GetString(1);

                        userInfo.StudentName = Firstname.First().ToString().ToUpper() + Firstname.Substring(1) + " " + Lastname.First().ToString().ToUpper() + Lastname.Substring(1);
                    }
                    reader.Close();
                }
                dbConnection.Close();
            }
        }
    }
    //METHOD TO: GET THE USERID
    public void GetandAddUserLoggedInTimeAndDate() {
        //timeLoggedIn = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm:ss tt");
        //Debug.Log("Logged in at: " + time);

        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {

                //start
                sqlQuery = "SELECT StudentID FROM StudentsTBL WHERE Username = '" + UserIF.text + "';";
                //sqlQuery = "INSERT INTO StudentSessionsTBL (Action, Time, StudentID) VALUES ('Login','wawawa','1');";
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

    public void InsertStudentLoginDateAndTime(){
        
        timeLoggedIn = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy HH:mm:ss tt");
        using (IDbConnection dbConnection = new SqliteConnection(connectionString)) {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand()) {

                //start
                
                sqlQuery = "INSERT INTO StudentSessionsTBL (Action, Time, StudentID) VALUES ('Log in','"+ timeLoggedIn +"','" + StudentIDInfo + "');";
                Debug.Log(timeLoggedIn+ StudentIDInfo);
                //sqlQuery = "INSERT INTO SectionsTBL (Sections) VALUES('Carlo');";
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
    }

    public void LogInAccount()
    {
        if (StudentLoginVerify() == true)
        {
            GetUserCredentials();
            GetandAddUserLoggedInTimeAndDate();
            InsertStudentLoginDateAndTime();
            userInfo.StudentID = StudentIDInfo;
            StartCoroutine(LoadScenes("3. Student's Dashboard"));

        }
        else
        {
            Debug.Log("INVALID USERNAME/PASSWORD");
        }
    }

    public void ShowPassword() {
        PasswordShow.inputType = TMP_InputField.InputType.Standard;
    }
    public void HidePassword() {
        PasswordShow.contentType = TMP_InputField.ContentType.Password;
    }
    IEnumerator LoadScenes(string SceneIndex) //To control the speed of the transition
    {
        //play the animation using trigger
        transition.SetTrigger("Start");

        //Animation Transition Time speed
        yield return new WaitForSeconds(1f);

        //load the scene
        SceneManager.LoadScene(SceneIndex);
    }
}
