using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class BinaryBeginnerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject card;
    private bool firstCardSelected, secondCardSelected;
    private GameObject card1, card2;
    private string rowForCard1, rowForCard2;
    bool timerHasElapsed, timerHasStarted;
    float timer;
    int nbMatch = 0;
    public bool timeOn;
    public float timePassed;
    public TextMeshProUGUI timerText;
    public GameObject victory;
    public Text scoreboardTime;
    string timePassedAsString;
    int timeAsInt;
    public GameObject SendScore;
    public GameObject NameInput;
    public GameObject NameFieldLabel;


    void Start()
    {
        displayCards();
        timeOn = true;
        
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeOn){
            timePassed += Time.deltaTime;
            updateTimer(timePassed);

            timeAsInt = Mathf.FloorToInt(timePassed) + 1;
            timePassedAsString = string.Format("{0}", timeAsInt);
            scoreboardTime.text = timePassedAsString;

        }
        if (timerHasStarted) { 
            timer += Time.deltaTime; 
            print (timer); 
            if (timer >= 1) { 
                timerHasElapsed = true; 
                timerHasStarted = false; 


                if (card1.tag == card2.tag) { 
                    Destroy (card1); 
                    Destroy (card2); 
                    nbMatch++;
                    if(nbMatch == 10){
                       
                       timeOn = false;
                       victory.SetActive(true);
                        SendScore.SetActive(true);
                        NameInput.SetActive(true);
                        NameFieldLabel.SetActive(true);
                    }
                    } 
                else { 
                    card1.GetComponent<Tile> ().hideCard (); 
                    card2.GetComponent<Tile> ().hideCard (); 
                } 


                firstCardSelected = false; 
                secondCardSelected = false; 
                card1 = null; 
                card2 = null; 
                rowForCard1 = ""; 
                rowForCard2 = ""; 
                timer = 0; 
            } 
        }
    }

    public void displayCards(){
        //Instantiate(card, new Vector3(0,0,0), Quaternion.identity);
        int[] shuffledArray = createShuffledArray();
        int[] shuffledArray2 = createShuffledArray();
        int baseNum1 = 0; // Going to be used to determine which base system it is using 0, 1 ,2 for decimal, binary, Hex
        int baseNum2 = 1;
        Scene scene = SceneManager.GetActiveScene();

        int rangeOfCards = 0; //Checks if cards are to be 1-10, 11-20, or Random

        if(scene.name == "BinaryBeginner"){

        
            for(int i = 0; i<10; i++){
                addACard(0, i, shuffledArray[i], baseNum1, rangeOfCards);
                addACard(1, i, shuffledArray2[i], baseNum2, rangeOfCards);

            }
        }

        if(scene.name == "HexBeginner"){
            
            baseNum1 = 2;
            rangeOfCards = 1;

            for(int i = 0; i<10; i++){
                addACard(0, i, shuffledArray[i], baseNum1, rangeOfCards);
                addACard(1, i, shuffledArray2[i], baseNum2, rangeOfCards);

            }

        }

        if(scene.name == "BinaryToHexBegin"){
            
            baseNum1 = 2;
            baseNum2 = 0;
            rangeOfCards = 1;

            for(int i = 0; i<10; i++){
                addACard(0, i, shuffledArray[i], baseNum1, rangeOfCards);
                addACard(1, i, shuffledArray2[i], baseNum2, rangeOfCards);

            }

        }
    }

    public void addACard(int row, int rank, int value, int baseVal, int cardRange) { 
        float cardOriginalScale = card.transform.localScale.x;
        float scaleFactor = (550 * cardOriginalScale) / 100.0f;
        GameObject cen = GameObject.Find("centerOfScreen");  
        float yScaleFactor = (775 * cardOriginalScale) / 100.0f; 
        Vector3 newPosition = new Vector3 (cen.transform.position.x + ((rank-10/2) *scaleFactor), cen.transform.position.y + ((row-2/2) *yScaleFactor), cen.transform.position.z);
        GameObject c = (GameObject)(Instantiate (card, newPosition, Quaternion.identity));
    
        c.tag = ""+ (value+1);
        c.name = "" + row + "_" + value;
        string nameOfCard = "";
        string cardNumber = "";

        if(cardRange == 0){
            cardNumber = "" + (value+1);
        }else if(cardRange == 1){
            cardNumber = "" + (value+11);
        }

        if(baseVal == 1){
            nameOfCard = "decimal_" + cardNumber;
        }
        else if(baseVal == 0){
            nameOfCard = "binary_" + cardNumber;
        }
        else if(baseVal == 2){
            nameOfCard = "hexadecimal_" + cardNumber;
        }

        Sprite s1 = (Sprite)(Resources.Load<Sprite>(nameOfCard));
        print("S1:"+s1);
        GameObject.Find("" + row + "_" + value).GetComponent<Tile>().setOriginalSprite(s1);
    
    }

    public int[] createShuffledArray(){
        int [] newArray = new int [] {0,1,2,3,4,5,6,7,8,9};
        int tmp; 
        for (int t = 0; t < 10; t++ ) { 
        tmp = newArray[t]; 
        int r = Random.Range(t, 10); 
        newArray[t] = newArray[r]; 
        newArray[r] = tmp; 
        } 
        return newArray;
    }

    public void cardSelected(GameObject card) { 
        if (!firstCardSelected) { 
            string row = card.name.Substring (0,1);
            rowForCard1 = row;
            firstCardSelected = true; 
            card1 = card; 
            card1.GetComponent<Tile> ().revealCard (); 
        } 
        else if(firstCardSelected && !secondCardSelected){
            string row = card.name.Substring (0, 1);
            rowForCard2 = row;
            if (rowForCard2 != rowForCard1){
                card2 = card;
                secondCardSelected = true;
                card2.GetComponent<Tile>().revealCard();
                checkCards();
            }
        }
    }

    public void checkCards(){
        runTimer();
    }

    public void runTimer(){
        timerHasElapsed = false;
        timerHasStarted = true;
    }


    void updateTimer(float time){
        time += 1;
        float min = Mathf.FloorToInt(time / 60);
        float sec = Mathf.FloorToInt(time % 60);


        timerText.text = string.Format("{00} : {1:00}", min, sec);

    }

    
}
