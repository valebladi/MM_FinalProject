using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{ 
    public int playerScore = 0;
    public GameObject playerScoreUI;


    // Update is called once per frame
    void Update()
    {
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + (int)playerScore);
       
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.name == "EndLevel"){
            CountScore();
        }
        if(trig.gameObject.tag == "Coin")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }
    }
    void CountScore()
    {
        playerScore = playerScore+50;
        Debug.Log(playerScore);
    }
}
