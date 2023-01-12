using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
     public void StartMemoryGametoLevel1(){
        SceneManager.LoadScene("lvl1");
    }
         public void StartLevel2(){
        SceneManager.LoadScene("lvl2");
    }
    public void Startlevel3(){
        SceneManager.LoadScene("lvl3");
    }
    public void FinishToStartScreen(){
        SceneManager.LoadScene("Main");
    }
}
