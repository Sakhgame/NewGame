using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
    public GameObject X; // ������� � ������� ������ X

    
    void Start()
    {
        X.SetActive(false); //������ ������ X
    }
}
