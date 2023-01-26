using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControlls : MonoBehaviour
{
    public GameObject ControllUI;
    private void Start()
    {
        StartCoroutine(waiter());
    }
    //zeigt die Controlls für 4 Sekunden
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        ControllUI.SetActive(false);
    }
}
