using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System.IO;
using TMPro;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;
using JetBrains.Annotations;
using System.Xml.Linq;
public class QueryManager : MonoBehaviour
{
     string connectionString;
    [Header("Leader boards")]
    [SerializeField] StudentInfo studentInfo;

    [Header("Leader boards")]
    [SerializeField] GameObject lbHeader;
    [SerializeField] GameObject lbContent;
    private TextMeshProUGUI[] lbTextCompList;
    private int nMaxUsers = 10;

    [Header("Score board")]
    [SerializeField] GameObject scHeader;
    [SerializeField] GameObject scContent;
    private TextMeshProUGUI[] scTextCompList;

    [Header("Lesson Buttons")]
    [SerializeField] Button[] lessonButtonsList;
    [SerializeField] string selectedLesson = "Types of Faults";


    // Start is called before the first frame update
    void Start()
    {
        connectionString = "Data Source = C:\\Users\\Ian\\OneDrive\\Documents\\VirtualLab\\VirtualLab.db";

        if (lbHeader && lbContent)
        {
            DisplayStudentLeaderBoard(selectedLesson);
        }
        else
        {
            Debug.Log("Leaderboards not updated");
        }

        if (scHeader && scContent && studentInfo)
        {
            DisplayStudentScores(selectedLesson);
        }
        else
        {
            Debug.Log("Scores not updated");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayStudentLeaderBoard(string lesson)
    {
        selectedLesson = lesson;
        Debug.Log("Display: " + selectedLesson);
        // delete all child 
        foreach (Transform child in lbContent.transform)
        {
            Destroy(child.gameObject);
        }

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT Firstname, max (Score), Section FROM ScoresTBL INNER JOIN StudentsTBL ON StudentsTBL.StudentID = ScoresTBL.StudentID WHERE ScoresTBL.Lesson = '" + selectedLesson + "' GROUP BY StudentsTBL.Firstname ORDER BY Score DESC";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    int nUsers = 0;
                    // reinstantiate all child
                    while (reader.Read())
                    {
                        nUsers++;

                        // one loop = 1 user
                        //Debug.Log(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5));
                        // create prefab
                        // modify value
                        GameObject userHeader = GameObject.Instantiate(lbHeader, lbContent.transform);

                        lbTextCompList = userHeader.gameObject.GetComponentsInChildren<TextMeshProUGUI>();

                        //Debug.Log(textCompList[0].gameObject.name);
                        lbTextCompList[0].text = nUsers.ToString();
                        lbTextCompList[1].text = reader.GetString(0);
                        lbTextCompList[2].text = reader.GetInt32(1).ToString();
                        lbTextCompList[3].text = reader.GetString(2);
                        if (nUsers >= nMaxUsers)
                        {
                            Debug.Log(" counter: " + nUsers + "loaded");
                            break;
                        }
                    }
                    reader.Close();

                }
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        } 
    }

    public void DisplayStudentScores(string lesson)
    {
        selectedLesson = lesson;
        Debug.Log("Display: " + selectedLesson);
        // delete all child 
        foreach (Transform child in scContent.transform)
        {
            Destroy(child.gameObject);
        }

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT Score, Date FROM ScoresTBL INNER JOIN StudentsTBL ON StudentsTBL.StudentID = ScoresTBL.StudentID WHERE ScoresTBL.Lesson = '" + selectedLesson + "' AND StudentsTBL.StudentID = '" + studentInfo.StudentID + "' ORDER BY Score DESC;";
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    // reinstantiate all child
                    while (reader.Read())
                    {

                        // one loop = 1 user
                        //Debug.Log(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5));
                        // create prefab
                        // modify value
                        GameObject userHeader = GameObject.Instantiate(scHeader, scContent.transform);

                        scTextCompList = userHeader.gameObject.GetComponentsInChildren<TextMeshProUGUI>();

                        //Debug.Log(textCompList[0].gameObject.name);
                        scTextCompList[0].text = reader.GetInt32(0).ToString();
                        scTextCompList[1].text = reader.GetString(1);

                    }
                    reader.Close();

                }
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
    }
    public void RefreshLB()
    {
        for (int i = 0; i < lessonButtonsList.Length; i++)
        {
            if (lessonButtonsList[i].IsInteractable() == false)
            {
                DisplayStudentLeaderBoard(selectedLesson);
            }
        }
    }

    public void RefreshSC()
    {
        for (int i = 0; i < lessonButtonsList.Length; i++)
        {
            if (lessonButtonsList[i].IsInteractable() == false)
            {
                DisplayStudentScores(selectedLesson);
            }
        }
    }

}
