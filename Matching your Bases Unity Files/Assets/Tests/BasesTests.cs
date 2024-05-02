using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class BasesTests
{
    [UnityTest]
    public IEnumerator _01BinaryTutorialAndBack()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("BinaryTutorialButton");

        Assert.IsNotNull(playButton, "Binary Tutorial button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Binarytut", SceneManager.GetActiveScene().name, "Binary scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _02HexTutorialAndBack()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("HexTutorial");

        Assert.IsNotNull(playButton, "Hexadecimal Tutorial button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Hextut", SceneManager.GetActiveScene().name, "Hexadecimal scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _03BiHexTutorialAndBack()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("BinaryToHexTut");

        Assert.IsNotNull(playButton, "Binary to Hexadecimal Tutorial button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Bihextut", SceneManager.GetActiveScene().name, "Binary to Hexadecimal scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _04GameTutorialAndBack()
    {
       yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("GameTutorialButton");

        Assert.IsNotNull(playButton, "Game Tutorial button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Gametut", SceneManager.GetActiveScene().name, "Game Tutorial scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _05BinaryBeginAndBack()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("BinaryBeginnerButton");

        Assert.IsNotNull(playButton, "Binary Beginner button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("BinaryBeginner", SceneManager.GetActiveScene().name, "Binary Beginner scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _06HexBeginAndBack()
    {
       
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("HexBeginnerButton");

        Assert.IsNotNull(playButton, "Hexadecimal Beginner button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("HexBeginner", SceneManager.GetActiveScene().name, "Hexadecimal scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _07BiHexBeginAndBack()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("BinaryToHexBeginnerButton");

        Assert.IsNotNull(playButton, "Binary to Hexadecimal beginner button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("BinaryToHexBegin", SceneManager.GetActiveScene().name, "Binary to Hexadecimal beginner scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
    }

    [UnityTest]
    public IEnumerator _08ScoreAndBack()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Main Menu");

        yield return new WaitForSeconds(1f);

        GameObject playButton = GameObject.Find("ScoreboardButton");

        Assert.IsNotNull(playButton, "ScoreBoard button not found in Main Menu scene");

        playButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Scoreboards", SceneManager.GetActiveScene().name, "Scoreboard scene not loaded after clicking Play button");

        GameObject returnButton = GameObject.Find("ReturnToMain");

        Assert.IsNotNull(returnButton, "Main Menu Button is not found in the Binary Tutorial Scene");

        returnButton.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Main Menu", SceneManager.GetActiveScene().name, "Main Menu not loaded after clicking return button.");
        
    }

    [UnityTest]
    public IEnumerator _09AreCardsCreated()
    {
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        GameObject binaryRow1 = GameObject.Find("0_1");
        GameObject binaryRow2 = GameObject.Find("1_1");

        Assert.IsNotNull(binaryRow1, "Binary First Row not generated");
        Assert.IsNotNull(binaryRow2, "Binary Second Row not generated");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("HexBeginner");

        yield return new WaitForSeconds(1f);

        GameObject hexRow1 = GameObject.Find("0_1");
        GameObject hexRow2 = GameObject.Find("1_1");

        Assert.IsNotNull(hexRow1, "Binary First Row not generated");
        Assert.IsNotNull(hexRow2, "Binary Second Row not generated");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryToHexBegin");

        yield return new WaitForSeconds(1f);

        GameObject biHexRow1 = GameObject.Find("0_1");
        GameObject biHexRow2 = GameObject.Find("1_1");

        Assert.IsNotNull(biHexRow1, "Binary First Row not generated");
        Assert.IsNotNull(biHexRow2, "Binary Second Row not generated");
    }

    [UnityTest]
    public IEnumerator _10AreCardsClickable()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        GameObject theCard = GameObject.Find("0_1"); 

        Assert.IsNotNull(theCard, "Card did not generate");


        theCard.GetComponent<Tile>().OnMouseDown(); 

        yield return new WaitForSeconds (1f);

        GameObject theCardFlip = GameObject.Find("0_1"); 

        Assert.AreEqual(theCard.GetComponent<Tile>().tileRevealed, true, "Card not flipped");    
        yield return null;
    }

    [UnityTest]
    public IEnumerator _11DoTilesDisappearBinary()
    {
         yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        GameObject theCard = GameObject.Find("0_1"); 

        Assert.IsNotNull(theCard, "Card did not generate");


        theCard.GetComponent<Tile>().OnMouseDown(); 

        yield return new WaitForSeconds (1f);

        GameObject theCardFlip = GameObject.Find("0_1"); 

        Assert.AreEqual(theCard.GetComponent<Tile>().tileRevealed, true, "Card not flipped");    

        GameObject theCard2 = GameObject.Find("1_1"); 

        Assert.IsNotNull(theCard2, "Card did not generate");

        theCard2.GetComponent<Tile>().OnMouseDown(); 

        yield return new WaitForSeconds (1f);

        GameObject isItgone = GameObject.Find("0_1");
        GameObject isItgone2 = GameObject.Find("1_1");

        Assert.IsNull(isItgone, "Card did not disappear");

        Assert.IsNull(isItgone2, "Card did not disappear");

        yield return new WaitForSeconds (1f);


        yield return null;
    }

    [UnityTest]
    public IEnumerator _12DoesVictoryScreenAppear()
    {
        GameObject Card1;
        GameObject Card2;
        string Name1;
        string Name2;

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        for(int i = 0; i < 10; i++){
            Name1 = "0_" + i;
            Name2 = "1_" + i;
            Card1 = GameObject.Find(Name1);
            Card2 = GameObject.Find(Name2);

            Assert.IsNotNull(Card1, "Card did not generate");
            Assert.IsNotNull(Card2, "card did not generate");

            Card1.GetComponent<Tile>().OnMouseDown();

            yield return new WaitForSeconds (1.1f);

            Card2.GetComponent<Tile>().OnMouseDown();

            yield return new WaitForSeconds (1.1f);
        }

        GameObject VictoryText = GameObject.Find("Victory");
        GameObject ScoreButton = GameObject.Find("SubmitScoreButton");
        GameObject NameText = GameObject.Find("NameFieldText");
        GameObject NameInputBox = GameObject.Find("NameField");

        Assert.IsNotNull(VictoryText, "Victory Text does not exist.");
        Assert.IsNotNull(ScoreButton, "Score button does not exist");
        Assert.IsNotNull(NameText, "The Name Field Label does not exist");
        Assert.IsNotNull(NameInputBox, "The Name Input Field does not exist");

        Assert.IsTrue(VictoryText.activeInHierarchy, "Victory not active" );
        Assert.IsTrue(ScoreButton.activeInHierarchy, "Score Button not active" );
        Assert.IsTrue(NameText.activeInHierarchy, "The Name Field not active" );
        Assert.IsTrue(NameInputBox.activeInHierarchy, "The Name Input not active" );

      yield return null;
    }

    [UnityTest]
    public IEnumerator _13DoesTimerCount()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        GameObject GameManage = GameObject.Find("gameManager");

        Assert.IsNotNull(GameManage, "Game Manager not found");

        float time1 = GameManage.GetComponent<BinaryBeginnerManager>().timePassed;

        yield return new WaitForSeconds(3f);

        float time2 = GameManage.GetComponent<BinaryBeginnerManager>().timePassed;
        Assert.AreNotSame(time1, time2, "Timer Not Functioning");

        yield return null;
    }

    [UnityTest]
    public IEnumerator _14DoesTimerStop()
    {
        GameObject Card1;
        GameObject Card2;
        string Name1;
        string Name2;

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("BinaryBeginner");

        yield return new WaitForSeconds(1f);

        for(int i = 0; i < 10; i++){
            Name1 = "0_" + i;
            Name2 = "1_" + i;
            Card1 = GameObject.Find(Name1);
            Card2 = GameObject.Find(Name2);

            Assert.IsNotNull(Card1, "Card did not generate");
            Assert.IsNotNull(Card2, "card did not generate");

            Card1.GetComponent<Tile>().OnMouseDown();

            yield return new WaitForSeconds (1.1f);

            Card2.GetComponent<Tile>().OnMouseDown();

            yield return new WaitForSeconds (1.1f);
        }


        GameObject GameManage = GameObject.Find("gameManager");

        Assert.IsNotNull(GameManage, "Game Manager not found");

        float time1 = GameManage.GetComponent<BinaryBeginnerManager>().timePassed;

        yield return new WaitForSeconds(3f);

        float time2 = GameManage.GetComponent<BinaryBeginnerManager>().timePassed;
        Assert.AreEqual(time1, time2, "Timer Not Stopping");
        
        yield return null;
    }
}
