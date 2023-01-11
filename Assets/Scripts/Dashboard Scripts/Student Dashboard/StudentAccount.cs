using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentAccount : MonoBehaviour
{
    public TextMeshProUGUI displayStudentName;

    public void Awake() {
        displayStudentName.text = StudentLogin.studentLogin.Student_name;
    }
}
