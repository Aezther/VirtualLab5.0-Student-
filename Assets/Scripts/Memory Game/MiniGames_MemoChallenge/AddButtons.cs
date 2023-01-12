using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{

    [SerializeField]
    private Transform puzzlefield;

    [SerializeField]
    private GameObject btn;
    void Awake(){ // create for loop for cube count
        for(int i = 0; i < 8; i++) {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzlefield, false);
        }
    }

}
