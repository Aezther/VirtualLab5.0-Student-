using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentAccount : MonoBehaviour
{
    public TextMeshProUGUI displayStudentName;
    [SerializeField] StudentInfo userInfo;

    public void Awake() {
        displayStudentName.text = userInfo.StudentName;
    }
}
