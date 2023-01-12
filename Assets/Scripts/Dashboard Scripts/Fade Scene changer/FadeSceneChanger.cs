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
    //5. MINIGAMES
    public void btnMinigamesToMinigames(){
        StartCoroutine(LoadScenes("6. Minigames"));
    }
    //5.1 MINIGAMES ENTERING A GAME
    public void btnGuessTheShadow(){
        StartCoroutine(LoadScenes("MInigames_GuessTheShadow"));
    }
    //5.1 MINIGAME: INSIDE GUESS THE SHADOW
    public void btnExitToMinigamesPanel(){
        StartCoroutine(LoadScenes("6. Minigames"));
    }
    public void btnLessonToLesson() {
        StartCoroutine(LoadScenes("4. Lessons"));
    }
    public void btnLeaderBoardsToLeaderBoards(){
        StartCoroutine(LoadScenes("7. Leaderboards"));
    }
    //4. INSIDE LESSONS UI
    public void btnMicroscopeToLesson(){
        StartCoroutine(LoadScenes("Mircroscope lesson"));
    }
    public void btnDistanceDisplacementToLesson(){
        StartCoroutine(LoadScenes("Distance and Displacement Lesson"));
    }
    //4.1 LESSON (MICROSCOPE)
    public void btnReturnInsideMicroscopeLesson(){
        StartCoroutine(LoadScenes("4. Lessons"));
    }
    //4.2 LESSON (DISTANCE AND DISPLACEMENT)
    public void btnReturnInsideDistanceLesson(){
        StartCoroutine(LoadScenes("4. Lessons"));
    }
    public void btnNextToChooseSimulationDistanceDisplacement(){
        StartCoroutine(LoadScenes("Choose Distance&Displacement Simulations"));
    }
    
    //4.3 PICK SIMULATION
    public void btnRoboSimToRoboSimulation(){
        StartCoroutine(LoadScenes("RoboDistance"));
    }
    //5. SIMULATIONS
    public void btnReturnToStudentDashboard() {
        StartCoroutine(LoadScenes("3. Student's Dashboard"));
    }
    //6. LESSONS
    public void btnReturnMGToStudentDashboard(){
        StartCoroutine(LoadScenes("3. Student's Dashboard"));
    }
    //7. LEADERBOARDS
    public void btnReturnLBToStudentDashboard(){
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
