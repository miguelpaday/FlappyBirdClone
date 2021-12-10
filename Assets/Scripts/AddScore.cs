using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        if(Score.score > Score.highscore)
        {
            Score.highscore = Score.score;
        }
    }


}
