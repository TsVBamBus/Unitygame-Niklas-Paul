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
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        ControllUI.SetActive(false);
    }
}
