using System.Collections.Generic;
using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class HighScoreControl : MonoBehaviour
{
    
    private string secretKey = "mySecretKey";
    public string addBinaryScoreURL = "http://localhost/Matching_Your_Bases/addBinary.php?";
    public string addHexScoreURL = "http://localhost/Matching_Your_Bases/addscoreHex.php?";
    public string addBinaryToHexScoreURL = "http://localhost/Matching_Your_Bases/addscoreBinaryToHex.php?";
    public string binaryScoreURL = "http://localhost/Matching_Your_Bases/display_binary.php";
    public string hexScoreURL = "http://localhost/Matching_Your_Bases/display_Hex.php";
    public string binaryToHexURL = "http://localhost/Matching_Your_Bases/display_Binary_to_Hex.php";
    public Text nameTextInput;
    public Text scoreTextInput;
    public Text nameResultText;
    public Text scoreResultText;
    public Text titleText;
    public GameObject SendScore;
    public GameObject NameInput;
    public GameObject NameFieldLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BinaryScoreBtn()
    {
    titleText.text = "Binary Scores!";
    nameResultText.text = "Player: \n \n";
    scoreResultText.text = "Time: \n \n";
    StartCoroutine(GetBinaryScores());
    }

    public void HexScoreBtn()
    {
    titleText.text = "Hexadecimal Scores!";
    nameResultText.text = "Player: \n \n";
    scoreResultText.text = "Time: \n \n";
    StartCoroutine(GetHexScores());
    }

    public void BinaryToHexScoreBtn()
    {
    titleText.text = "Binary To Hexadecimal Scores!";
    nameResultText.text = "Player: \n \n";
    scoreResultText.text = "Time: \n \n";
    StartCoroutine(GetBinaryToHexScores());
    }



    public void SendBinaryScoreBtn()
    {
    int scoreValue = Int32.Parse(scoreTextInput.text);
    StartCoroutine(PostBinaryScores(nameTextInput.text, scoreValue));        	
    SendScore.SetActive(false);
    NameInput.SetActive(false);
    NameFieldLabel.SetActive(false);
    }

    public void SendHexScoreBtn()
    {
    int scoreValue = Int32.Parse(scoreTextInput.text);
    StartCoroutine(PostHexScores(nameTextInput.text, scoreValue));        	
    SendScore.SetActive(false);
    NameInput.SetActive(false);
    NameFieldLabel.SetActive(false);
    }

    public void SendBinaryToHexScoreBtn()
    {
    int scoreValue = Int32.Parse(scoreTextInput.text);
    StartCoroutine(PostBinaryToHexScores(nameTextInput.text, scoreValue));        	
    SendScore.SetActive(false);
    NameInput.SetActive(false);
    NameFieldLabel.SetActive(false);
    }



    IEnumerator GetBinaryScores()
    {
	UnityWebRequest hs_get = UnityWebRequest.Get(binaryScoreURL);
	yield return hs_get.SendWebRequest();
	if (hs_get.error != null)
		Debug.Log("There was an error getting the high score: "
                + hs_get.error);
	else
	{
		string dataText = hs_get.downloadHandler.text;
		MatchCollection mc = Regex.Matches(dataText, @"_");
		if (mc.Count > 0)
		{
			string[] splitData = Regex.Split(dataText, @"_");
			for (int i =0; i < mc.Count; i++)
			{
				if (i % 2 == 0)
					nameResultText.text += 
                                        splitData[i];
				else{
					float ScoreTime = (float) Convert.ToDouble(splitData[i]);
                    float min = Mathf.FloorToInt(ScoreTime / 60);
                    float sec = Mathf.FloorToInt(ScoreTime % 60);


                    scoreResultText.text += string.Format("{00} : {1:00}", min, sec);
                    scoreResultText.text += "\n";

                }
			}
		}
	}
    }

    IEnumerator GetHexScores()
    {
	UnityWebRequest hs_get = UnityWebRequest.Get(hexScoreURL);
	yield return hs_get.SendWebRequest();
	if (hs_get.error != null)
		Debug.Log("There was an error getting the high score: "
                + hs_get.error);
	else
	{
		string dataText = hs_get.downloadHandler.text;
		MatchCollection mc = Regex.Matches(dataText, @"_");
		if (mc.Count > 0)
		{
			string[] splitData = Regex.Split(dataText, @"_");
			for (int i =0; i < mc.Count; i++)
			{
				if (i % 2 == 0)
					nameResultText.text += 
                                        splitData[i];
				else{
					float ScoreTime = (float) Convert.ToDouble(splitData[i]);
                    float min = Mathf.FloorToInt(ScoreTime / 60);
                    float sec = Mathf.FloorToInt(ScoreTime % 60);


                    scoreResultText.text += string.Format("{00} : {1:00}", min, sec);
                    scoreResultText.text += "\n";

                }
			}
		}
	}
    }


    IEnumerator GetBinaryToHexScores()
    {
	UnityWebRequest hs_get = UnityWebRequest.Get(binaryToHexURL);
	yield return hs_get.SendWebRequest();
	if (hs_get.error != null)
		Debug.Log("There was an error getting the high score: "
                + hs_get.error);
	else
	{
		string dataText = hs_get.downloadHandler.text;
		MatchCollection mc = Regex.Matches(dataText, @"_");
		if (mc.Count > 0)
		{
			string[] splitData = Regex.Split(dataText, @"_");
			for (int i =0; i < mc.Count; i++)
			{
				if (i % 2 == 0)
					nameResultText.text += splitData[i];
				else{
					float ScoreTime = (float) Convert.ToDouble(splitData[i]);
                    float min = Mathf.FloorToInt(ScoreTime / 60);
                    float sec = Mathf.FloorToInt(ScoreTime % 60);


                    scoreResultText.text += string.Format("{00} : {1:00}", min, sec);
                    scoreResultText.text += "\n";

                }
			}
		}
	}
    }





   IEnumerator PostBinaryScores(string name, int score)
    {
	string hash = HashInput(name + score + secretKey);
	string post_url = addBinaryScoreURL + "name=" + 
           UnityWebRequest.EscapeURL(name) + "&score=" 
           + score + "&hash=" + hash;
	UnityWebRequest hs_post = UnityWebRequest.PostWwwForm(post_url, hash);
	yield return hs_post.SendWebRequest();
	if (hs_post.error != null)
		Debug.Log("There was an error posting the high score: " 
                + hs_post.error);
    }

    IEnumerator PostHexScores(string name, int score)
    {
	string hash = HashInput(name + score + secretKey);
	string post_url = addHexScoreURL + "name=" + 
           UnityWebRequest.EscapeURL(name) + "&score=" 
           + score + "&hash=" + hash;
	UnityWebRequest hs_post = UnityWebRequest.PostWwwForm(post_url, hash);
	yield return hs_post.SendWebRequest();
	if (hs_post.error != null)
		Debug.Log("There was an error posting the high score: " 
                + hs_post.error);
    }

    IEnumerator PostBinaryToHexScores(string name, int score)
    {
	string hash = HashInput(name + score + secretKey);
	string post_url = addBinaryToHexScoreURL + "name=" + 
           UnityWebRequest.EscapeURL(name) + "&score=" 
           + score + "&hash=" + hash;
	UnityWebRequest hs_post = UnityWebRequest.PostWwwForm(post_url, hash);
	yield return hs_post.SendWebRequest();
	if (hs_post.error != null)
		Debug.Log("There was an error posting the high score: " 
                + hs_post.error);
    }

    
    public string HashInput(string input)
    {
	SHA256Managed hm = new SHA256Managed();
	byte[] hashValue = 	
            hm.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input));
	string hash_convert = 
             BitConverter.ToString(hashValue).Replace("-", "").ToLower();
	return hash_convert;
    }
}
