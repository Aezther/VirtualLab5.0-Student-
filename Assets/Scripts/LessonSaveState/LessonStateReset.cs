using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonStateReset : MonoBehaviour
{

    public void clearStates()
    {
        SnVStateManager.pageRead = 0;
        MicroStateManager.pageRead = 0;
        DnDStateManager.pageRead = 0;
        ToFStateManager.pageRead = 0;
        Debug.Log("lesson states cleared!");
    }

}
