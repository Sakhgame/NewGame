using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
    public GameObject X; // Объявим и назовем объект X

    
    void Start()
    {
        X.SetActive(false); //скрыть объект X
    }
}
