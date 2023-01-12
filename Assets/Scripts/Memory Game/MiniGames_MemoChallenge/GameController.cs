using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage;
    public Sprite[] puzzles;
    public List<Sprite> gamePuzzles = new List<Sprite>();
    public List<Button> btns = new List<Button>();

    private bool firstGuess, secondGuess;
    
    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private int firstGuessIndex, secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle;

    void Awake(){
       
    }
    void Start(){
        GetButtons ();
        AddListeners ();
        AddGamePuzzles();
        Shuffle (gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
   }

    void GetButtons(){
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Puzzle Button");

        for(int i = 0; i < objects.Length; i++){
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
    }

    void AddGamePuzzles(){
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++){
            
            if(index == looper / 2){
                index = 0;
            }
            try{ 
                gamePuzzles.Add(puzzles[index]);
            index++;
            } catch(Exception){}
            
        }

    }
    void AddListeners() {
        foreach(Button btn in btns){
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }
    public void PickAPuzzle(){
        
        if (!firstGuess) {

            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            try{
                firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
                btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];
            } catch(Exception){}
          
            
          

        } else if (!secondGuess){
            
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            
            try{
                secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
                btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
                
            countGuesses++;

            StartCoroutine(CheckIfThePuzzlesMatch());
            }catch(Exception){}
            

          

        }

     }
        IEnumerator CheckIfThePuzzlesMatch(){

            yield return new WaitForSeconds(.1f);

            if(firstGuessPuzzle == secondGuessPuzzle){

            yield return new WaitForSeconds(.5f);
                
            btns[firstGuessIndex].interactable = false;
            btns[secondGuessIndex].interactable = false;

            btns[firstGuessIndex].image.color = new Color (0, 0, 0, 0);
            btns[secondGuessIndex].image.color = new Color (0, 0, 0, 0);


                CheckIfTheGameIsFinished();

            } else {

            yield return new WaitForSeconds(.5f);

            btns[firstGuessIndex].image.sprite = bgImage;
            btns[secondGuessIndex].image.sprite = bgImage;

            }

           yield return new WaitForSeconds(.5f);

            firstGuess = secondGuess = false;
            


    }
    void CheckIfTheGameIsFinished(){
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuesses){
            Debug.Log("Game Finished");
            Debug.Log("It took you" + countGuesses + "many gues(es) to finish the game");
            
        }
    }


    void Shuffle(List<Sprite> list){
        
        for(int i =0;  i < list.Count; i++){
            Sprite temp = list[i];
            int randomIndex = UnityEngine.Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

}
