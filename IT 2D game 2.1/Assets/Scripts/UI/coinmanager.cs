using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmanager : MonoBehaviour
{
    public int coinanzahl;
    public Text coinanzeige;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinanzeige.text = coinanzahl.ToString(); 
    }
    public void AddCoin()
    {
        coinanzahl++;
    }
}
