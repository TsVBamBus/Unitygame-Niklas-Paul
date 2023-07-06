using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmanager : MonoBehaviour
{
    public int coinanzahl;
    public Text coinanzeige;

    void Start()
    {
        coinanzahl = PlayerPrefs.GetInt("Money", 0);
    }

    void Update()
    {
        coinanzeige.text = PlayerPrefs.GetInt("Money", 0).ToString(); 
    }
    public void AddCoin()
    {
        coinanzahl++;
        PlayerPrefs.SetInt("Money", coinanzahl);
    }
}
