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
    [SerializeField] string connectionString;

    [Header("Leader boards")]
    [SerializeField] GameObject lbHeader;
    [SerializeField] GameObject lbContent;
    private TextMeshProUGUI[] lbTextCompList;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayStudentLeaderBoard()
    {
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
                string sqlQuery = "SELECT StudentID, Username, Firstname, Middlename, Lastname, Section FROM StudentsTBL";
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
                        GameObject userHeader = GameObject.Instantiate(lbHeader, lbContent.transform);

                        lbTextCompList = userHeader.gameObject.GetComponentsInChildren<TextMeshProUGUI>();

                        //Debug.Log(textCompList[0].gameObject.name);
                        lbTextCompList[0].text = reader.GetString(0);
                        lbTextCompList[1].text = reader.GetString(1);
                        lbTextCompList[2].text = reader.GetString(2);
                        lbTextCompList[3].text = reader.GetString(3);
                        lbTextCompList[4].text = reader.GetString(4);
                        lbTextCompList[5].text = reader.GetString(5);
                    }
                    reader.Close();

                }
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        }
    }
}
