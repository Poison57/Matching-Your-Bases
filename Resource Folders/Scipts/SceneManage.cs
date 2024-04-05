using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void BinaryTut(){
        SceneManager.LoadScene("Binarytut");
    }

    public void Gametut(){
        SceneManager.LoadScene("Gametut");
    }

    public void BinaryB(){
        SceneManager.LoadScene("BinaryBeginner");
    }

    public void Hextut(){
        SceneManager.LoadScene("Hextut");
    }

    public void Bihextut(){
        SceneManager.LoadScene("Bihextut");
    }

    public void HexB(){
        SceneManager.LoadScene("HexBeginner");
    }

    public void BinaryToHexB(){
        SceneManager.LoadScene("BinaryToHexBegin");
    }
}
