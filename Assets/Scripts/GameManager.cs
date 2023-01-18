using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;
using Mono.Data.Sqlite;
using System.Data;


public class GameManager : MonoBehaviour
{
    [SerializeField] string Lesson;
    [SerializeField]StudentInfo studentInfo;
    public Questions[] questions;
    private static List<Questions> unansweredQuestions;
    private Questions currentQuestion;

    [SerializeField]
    private TMP_Text questionText;

    [SerializeField]
    private GameObject btnTrue;
    [SerializeField]
    private GameObject btnFalse;

    [SerializeField]
    private TMP_Text TrueAnswerText ;
    [SerializeField]
    private TMP_Text FalseAnswerText;
    [SerializeField]
    private GameObject TrueAnswerTexto ;
    [SerializeField]
    private GameObject FalseAnswerTexto;

    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Animator animatorResult;

    [SerializeField]
    private float timeBetweenQuestion = 1f;

    [SerializeField]
    private GameObject ToF;

    [SerializeField]
    private GameObject ResultScreen;

    [SerializeField]
    private TMP_Text ScoreText;


    public int Score;

    //////////////////////IDENTIFICATION HERE////////////////////////////////

    public IdentificationQuestions[] idfQuestionsRef;
    private List<IdentificationQuestions> idfunanswered;
    private IdentificationQuestions idfcurrentQuestion;
    

    [SerializeField]
    Animator idfanimator;

    [SerializeField]
    private TMP_Text idfQuestionText;

    [SerializeField]
    private TMP_InputField ansBox;

    [SerializeField]
    private GameObject idfansBox;

    [SerializeField]
    private GameObject idfsubmitbtn;

    [SerializeField]
    private GameObject identificationForm;

    [SerializeField]
    private GameObject ToFForm;

    [SerializeField]
    private GameObject transition;

    [SerializeField]
    public string finishSceneName;

     private string connectionString;
    private string sqlQuery;
    //private string StudentIDInfo;



    void Start ()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Questions>();
            Debug.Log("sample question: "+unansweredQuestions[0]);
        }
        else
        {
            Debug.Log("Questions preset not found");
        }

        if(idfunanswered == null || idfunanswered.Count == 0)
        {
            idfunanswered = idfQuestionsRef.ToList<IdentificationQuestions>();
        }
        else
        {
            Debug.Log(" Identification Questions preset not found");

        }

        GetAQuestion();
        idfGetAQuestion();
    
    }

    void GetAQuestion()
    {
        // int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        // currentQuestion = unansweredQuestions[randomQuestionIndex];
        
        if(unansweredQuestions.Count >0)
        {
           int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
            currentQuestion = unansweredQuestions[randomQuestionIndex];

            questionText.text = currentQuestion.question;
        }else 
        {
            questionText.text = "Finished!";
            StartCoroutine(Finished());
        }


        Debug.Log(unansweredQuestions.Count);

        if(currentQuestion.isTrue){
            TrueAnswerText.text = "CORRECT";
            FalseAnswerText.text = "WRONG";
        }else {
            TrueAnswerText.text = "WRONG";
            FalseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestion);

        animator.SetTrigger("NewQuestion");

        GetAQuestion();
        Debug.Log("Your Score is: "+Score);


        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        animator.SetTrigger("True");

        if(currentQuestion.isTrue   )
        {
            Score++;
            Debug.Log("Correct");
        }else {
            Debug.Log("Wrong");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectFalse()
    {
        animator.SetTrigger("False");

        if(!currentQuestion.isTrue   )
        {
            Score++;
            Debug.Log("Correct");
        }else {
            Debug.Log("Wrong");
        }

        StartCoroutine(TransitionToNextQuestion());
    }

    IEnumerator Finished()
    {
       TrueAnswerTexto.SetActive(false);
       FalseAnswerTexto.SetActive(false);
       btnTrue.SetActive(false);
       btnFalse.SetActive(false);
        Debug.Log("fin.");
        yield return new WaitForSeconds(timeBetweenQuestion);
        
        ToF.SetActive(false);
        ResultScreen.SetActive(true);

        // yield return new WaitForSeconds(0.35f);
        // animatorResult.SetTrigger("Default");
        ScoreText.text = (Score + "/10");
        yield return new WaitForSeconds(1f);
        animatorResult.SetTrigger("Dropped");
        yield return new WaitForSeconds(1f);
        animatorResult.SetTrigger("Score");
        yield return new WaitForSeconds(1f);
        animatorResult.SetTrigger("Default");
    }

    //////////////////////IDENTIFICATION HERE////////////////////////////////

    void idfGetAQuestion()
    {

        if(idfunanswered.Count > 0)
        {
           int idfrandomQuestionIndex = Random.Range(0, idfunanswered.Count);
            idfcurrentQuestion = idfunanswered[idfrandomQuestionIndex];

            idfQuestionText.text = idfcurrentQuestion.idfQuestion;
        }else 
        {
            idfQuestionText.text = "Finished!";
            StartCoroutine(loadToF());
            
        }
        //connectionString = "Data Source =C:\\Users\\Ian\\OneDrive\\Desktop\\GitHub\\VirtualLab5.0\\Assets\\StreamingAssets\\Database\\VirtualDB.db";
        connectionString = "Data Source = C:\\Users\\oliva\\Documents\\VirtualLab\\VirtualLab.db";

    }

    public void idfSubmitAnswer() 
    {
        
        
        if(ansBox.text.ToString().ToUpper() == idfcurrentQuestion.idfAnswer.ToString().ToUpper())
        {
            // Debug.Log("Correct!");
            idfanimator.SetTrigger("Correct");
            Score++;
        }else {
            // Debug.Log("Wrong! Its: " + idfcurrentQuestion.idfAnswer.ToString());
            idfanimator.SetTrigger("Wrong");
        }

        StartCoroutine(idfTransitionToNextQuestion());
    }

    IEnumerator idfTransitionToNextQuestion()
    {
        idfunanswered.Remove(idfcurrentQuestion);
        ansBox.text = "";
        yield return new WaitForSeconds(timeBetweenQuestion);
        
        idfGetAQuestion();
        Debug.Log("idfuns count: "+idfunanswered.Count + " unans count: "+ idfunanswered.Count);

        idfanimator.SetTrigger("Idle");
    
        

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator loadToF()
    {
        Debug.Log("Test loadToF");
        yield return new WaitForSeconds(1f);
        idfansBox.SetActive(false);
        idfsubmitbtn.SetActive(false);
        yield return new WaitForSeconds(1f);
        identificationForm.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        transition.SetActive(transform);
        yield return new WaitForSeconds(0.5f);
        transition.SetActive(false);
        ToFForm.SetActive(true);
        
    }

    //////FINISH BUTTON AFTER QUIZ SCORE

    public void finishQuiz()
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {

                //start
                studentInfo.score = Score;
                studentInfo.lesson = Lesson;

                sqlQuery = "INSERT INTO ScoresTBL (Lesson, Score , StudentID) VALUES ('" + Lesson + "','" + Score + "','" + studentInfo.StudentID + "');";
                //sqlQuery = "INSERT INTO SectionsTBL (Sections) VALUES('Carlo');";
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteNonQuery();
            }
            dbConnection.Close();
        }

        //SceneManager.LoadScene(finishSceneName); /////PUT THE NAME OF THE SCENE YOU WANT TO LOAD AT THE SERIALIZED FIELD AT THE INSPECTOR, IT'S CALLED FINISHSCENENAME
    }

    public void addScoretoDB(){
        
       
    }

}
