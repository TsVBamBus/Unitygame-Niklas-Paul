using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;
    private LevelEnd levelEnd;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        levelEnd = GameObject.FindGameObjectWithTag("Player").GetComponent<LevelEnd>();
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            levelEnd.GameLost(levelEnd.looserScreen, levelEnd.playerUi);
        }
    }


}
