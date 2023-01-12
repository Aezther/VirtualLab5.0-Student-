using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoutScript : MonoBehaviour
{
        public Animator transition;
    public void btnSimulationsToSimulations() {
        StartCoroutine(LoadScenes("5. Simulations"));
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
