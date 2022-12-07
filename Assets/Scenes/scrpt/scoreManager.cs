using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int scoreToReach;
    private int player1Score = 0;
    private int player2Score = 0;
    public Text player1ScoreText ;
    public Text player2ScoreText;
    public void player1Goal()
    {
        player1Score++;
        player1ScoreText.text = "" +player1Score;
        checkScore();
    }
    public void player2Goal()
    {
        player2Score++;
        player2ScoreText.text = "" + player2Score;
        checkScore();
    }
    private void checkScore()
    {
        if(player1Score == scoreToReach )
        {
            SceneManager.LoadScene(2);
        }else if ( player2Score == scoreToReach)
        {
            SceneManager.LoadScene(3);
        }
    }
}
