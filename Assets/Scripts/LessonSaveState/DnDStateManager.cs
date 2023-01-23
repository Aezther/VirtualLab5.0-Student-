using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DnDStateManager : MonoBehaviour
{
    
    public GameObject[] pages; ///lesson pages
    public static int pageRead = 0;
    void Start ()
    {
        Debug.Log(pageRead);
        pages[pageRead].SetActive(true);

    }

    public void nextPage()
    {
        if (pages.Length > pageRead)
        {
             pageRead++;
        }else {
            pageRead = 0;
        }
        Debug.Log(pageRead);
    }

    public void prevPage()
    {   
        if(pageRead<=0)
        {
            Debug.Log("x");
        }else{
            pageRead--;
        }
        Debug.Log(pageRead);
    }

    public void resetDnDState()
    {
        pageRead = 0;
    }

}
