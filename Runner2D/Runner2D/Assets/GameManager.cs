using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;


    // atributo publico para que aparezca en el inspector
    public Text scoreText;

    public void AddScore()
    {
        playerScore++;
        Debug.Log("Puntos: " + playerScore);
        scoreText.text = playerScore.ToString();

    }

}
