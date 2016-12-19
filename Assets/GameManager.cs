using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    Ball gameBall1;
    [SerializeField]
    Ball gameBall2;
    [SerializeField]
    Paddle paddle1;
    [SerializeField]
    Paddle paddle2;
    [SerializeField]
    Text scoreText;
    [SerializeField]
    Text countdown;
    

    int playerOneScore, playerTwoScore;
	// Use this for initialization
	void Start () {

       // countdown.text = "Press 'Enter' to start";
        playerOneScore = 0;
        playerTwoScore = 0;

       /* while (!Input.GetKeyDown(KeyCode.Return)) {
            yield return null;
        }
        countdown.text = "";*/
        gameBall1.initialize();
        gameBall2.initialize();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoalScored(int playerNumber)
    {
        if (playerNumber == 1) playerOneScore++;
        else if (playerNumber == 2) playerTwoScore++;

        if (playerOneScore == 5) GameOver(1);
        else if (playerTwoScore == 5) GameOver(2);

        UpdateScoreText();
        gameBall1.Reset();
        gameBall2.Reset();
        paddle1.Reset();
        paddle2.Reset();



       /* countdown.text = "Press 'Enter' to start";
        while (!Input.GetKeyDown(KeyCode.Return))
        {
            yield return null;
        }
        countdown.text = "";*/

        gameBall1.initialize();
        gameBall2.initialize();
       
    }

    void GameOver(int winner)
    {
        playerOneScore = 0;
        playerTwoScore = 0;

       /* countdown.text = "Congrats to Player" + winner.ToString() + "! Press 'Enter' to start a new game";
        while (!Input.GetKeyDown(KeyCode.Return))
        {
            yield return null;
        }
        countdown.text = "";*/

        gameBall1.Reset();
        gameBall2.Reset();
        UpdateScoreText();
        paddle1.Reset();
        paddle2.Reset();
        gameBall2.initialize();
        gameBall1.initialize();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Player One " + playerOneScore.ToString() + " - " + playerTwoScore.ToString() + " Player Two";
    }


}

