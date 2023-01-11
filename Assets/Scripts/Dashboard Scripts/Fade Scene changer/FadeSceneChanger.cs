using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeSceneChanger : MonoBehaviour
{
    public Animator transition;


    //1. START SCREEN
    public void StartScreenToLogin() 
    {
        StartCoroutine(LoadScenes("2. Login Screen"));
    }
    public void QuitGame() {
        Application.Quit();
        Debug.Log("Quit!");
    }
    //2. LOGIN SCREEN
    public void btnReturnToStartScreen() {
        StartCoroutine(LoadScenes("1. Start Screen"));
    }

    //3. STUDENT'S DASHBOARD
    public void btnSimulationsToSimulations() {
        StartCoroutine(LoadScenes("5. Simulations"));
    }
    public void btnLessonToLesson() {
        StartCoroutine(LoadScenes("4. Lessons"));
    }

    //5. SIMULATIONS
    public void btnReturnToStudentDashboard() {
        StartCoroutine(LoadScenes("3. Student's Dashboard"));
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
