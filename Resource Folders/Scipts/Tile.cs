using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    private bool tileRevealed = false;
    public Sprite originalSprite;
    public Sprite hiddenSprite;

    // Start is called before the first frame update
    void Start()
    {
        hideCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown(){
        print("You Pressed on the Tile");
    
        GameObject.Find ("gameManager").GetComponent<BinaryBeginnerManager> ().cardSelected (gameObject);
    }

    public void hideCard() { 
        GetComponent<SpriteRenderer>().sprite = hiddenSprite;
        tileRevealed = false; 
        } 

    public void revealCard() { 
        GetComponent<SpriteRenderer>().sprite = originalSprite; 
        tileRevealed = true; 
        }

    public void setOriginalSprite(Sprite newSprite){
        originalSprite = newSprite;
    }
        
}
