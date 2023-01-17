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
    public void btnMemoryGame(){
        StartCoroutine (LoadScenes("Main"));
    }
    //5.1 MINIGAME: INSIDE GUESS THE SHADOW
    public void btnExitToMinigamesPanel(){
        StartCoroutine(LoadScenes("6. Minigames"));
    }
    //5.2 MINIGAME: INSIDE MINIGAME
    public void btnExitToMinigamesPanelfromMM(){
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
    //PRE-TESTS
    public void btnTypesOffaultToPretest(){
            StartCoroutine(LoadScenes("PRETest TypesOfFault"));
    }
    public void btnDistanceDisplacementToPretest(){
            StartCoroutine(LoadScenes("PRETest Distance and Displaecment"));
    }
    public void btnMicroscopeToPretest(){
            StartCoroutine(LoadScenes("PRETest Microscope (Pre-Test)"));
    }
    public void btnSpeedVelocityToPretest(){
            StartCoroutine(LoadScenes("PRETest Velocity"));
    }

    //VIRTUAL MICROSCOPE SIMULATION
    public void btnLearnToLearntheparts(){
        StartCoroutine(LoadScenes("3. Learning Microscope Parts"));
    }
    public void btnExploreToLearnSpecimens(){
        StartCoroutine(LoadScenes("2. Explore Microscope Specimen"));
    }
    public void btnRETURNTOMICROSCOPESTARTSCREEN(){
        StartCoroutine(LoadScenes("1. Microscope Start Screen (Temp)"));
    }
    
    public void btnPretestGoingToMicroscopeSimulation(){
         StartCoroutine(LoadScenes("1. Microscope Start Screen (Temp)"));
         
    }

    public void btnPretestGoingToRoboDistanceDisplacementSim(){
        StartCoroutine(LoadScenes("RoboDistance"));
    }
    public void btnFinishedPostTestInDistanceDisplacement(){
        StartCoroutine(LoadScenes("3. Student's Dashboard"));
    }
    public void btnSuretoTakeQuizDistanceAndDisplacement(){
        StartCoroutine(LoadScenes("DistanceDisplacement"));
    }

    public void btnSuretoTakeQuizMicroscope(){
        StartCoroutine(LoadScenes("Microscope TrueOrFalse"));

    }

    public void btnFinishedPostTestInMicroscope(){
         StartCoroutine(LoadScenes("3. Student's Dashboard"));
    }

    public void btnfinishInPRETESTgoingtoLesson(){
        StartCoroutine(LoadScenes("Distance and Displacement Lesson"));
    }
    public void btnfinishedinPRETESTgoingtoLESSONinMicroscope(){
        StartCoroutine(LoadScenes("Mircroscope lesson"));
    }

    public void btnLESSONofMICROSCOPEGoingtoSimulation(){
        StartCoroutine(LoadScenes("1. Microscope Start Screen (Temp)"));

    }
    ////Lesson Starts
    public void lessonStartDND(){
        StartCoroutine(LoadScenes("DnDLessonStart"));

    }
    public void LessonStartMicro(){
        StartCoroutine(LoadScenes("MicroLessonStart"));

    }
    public void LessonStartFault(){
        StartCoroutine(LoadScenes("ToFLessonStart"));

    }
    
    public void LessonStartSpeed(){
        StartCoroutine(LoadScenes("SpeedLessonStart"));

    }
    ////Lesson Starting Page - Distance and Displacement
    public void dndStartPretestBTN(){
        StartCoroutine(LoadScenes("PRETest Distance and Displaecment"));

    }
    public void dndStartLessonBTN(){
        StartCoroutine(LoadScenes("Distance and Displacement Lesson"));

    }
    public void dndStartSimBTN(){
        StartCoroutine(LoadScenes("Choose Distance&Displacement Simulations"));

    }

    public void dndStartPostTestBTN(){
        StartCoroutine(LoadScenes("DistanceDisplacement"));

    }

    ////Lesson Starting Page - Microscope
    public void MicroStartPreTestBTN(){
        StartCoroutine(LoadScenes("PRETest Microscope (Pre-Test)"));

    }
    public void MicroStartLessonBTN(){
        StartCoroutine(LoadScenes("Mircroscope lesson"));

    }

    public void MicroStartSimBTN(){
        StartCoroutine(LoadScenes("1. Microscope Start Screen (Temp)"));

    }

     public void MicroStartPostTestBTN(){
        StartCoroutine(LoadScenes("Microscope TrueOrFalse"));

    }

    ////Lesson Starting Page - Speed    
     public void SpeedStartPreTestBTN(){
        StartCoroutine(LoadScenes("PRETest Velocity"));

    }
    
    public void SpeedStartLessonBTN(){
        StartCoroutine(LoadScenes("Lesson (Speed and Velocity)"));

    }

    public void SpeedStartSimBTN(){
        StartCoroutine(LoadScenes("Lesson (Speed and Velocity)"));

    }

    public void SpeedStartPostTestBTN(){
        StartCoroutine(LoadScenes("Lesson (Speed and Velocity)"));

    }

    ////Lesson Starting Page - Types of Faults   
    public void ToFStartPreTestBTN(){
        StartCoroutine(LoadScenes("PRETest TypesOfFault"));

    }

    public void ToFStartLessontBTN(){
        StartCoroutine(LoadScenes("Types of Fault"));

    }
    
    public void ToFStartSimBTN(){
        StartCoroutine(LoadScenes("TypeOfFaultSim"));

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
