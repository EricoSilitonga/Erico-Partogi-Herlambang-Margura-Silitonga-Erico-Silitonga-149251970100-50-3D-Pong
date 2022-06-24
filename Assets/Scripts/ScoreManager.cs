using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int player1,player2,player3,player4;

    public void AddPlayer1Score(int increment)
    {
        player1 += increment;
    }

    public void AddPlayer2Score(int increment)
    {
        player2 += increment;
    }

    public void AddPlayer3Score(int increment)
    {
        player3 += increment;
    }

    public void AddPlayer4Score(int increment)
    {
        player4 += increment;
    }
}
