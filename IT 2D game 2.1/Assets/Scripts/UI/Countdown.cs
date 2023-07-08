using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 200f;
    private LevelEnd levelEnd;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime; //Startet den Countdown
        levelEnd = GameObject.FindGameObjectWithTag("Player").GetComponent<LevelEnd>(); //Refernz zum LevelEnd Script auf dem Spieler
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0"); //Countdown zu 0

        if (currentTime <= 0)
        {
            currentTime = 0;
            levelEnd.GameLost(levelEnd.looserScreen, levelEnd.playerUi); //wenn die Zeit 0 ist soll der Spieler sterben
        }
    }


}
