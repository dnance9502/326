using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public static int P1Score;
    public static int P2Score;


    public TextMeshProUGUI p1ScoreText;
    public TextMeshProUGUI p2ScoreText;

    public GameObject P1winText;
    public GameObject P2winText;
    
    // Start is called before the first frame update
    void Start()
    {
        P1Score = 0;
        P2Score = 0;
        P1winText.SetActive(false);
        P2winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (P1Score == 11)
        {
            P1winText.SetActive(true);
        }

        if (P2Score == 11)
        {
            P2winText.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            
            if (CompareTag("player1"))
            {
                P1Score++;
                p1ScoreText.text = "Score: " + P1Score.ToString();
                BallMovement.P1Start = true;

            }

            if (CompareTag("player2"))
            {
                P2Score++;
                p2ScoreText.text = "Score: " + P2Score.ToString();
                BallMovement.P1Start = false;

            }
            Destroy(other.gameObject);
        }
    }
}
