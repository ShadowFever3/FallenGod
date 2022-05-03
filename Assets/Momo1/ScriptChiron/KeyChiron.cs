using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChiron : MonoBehaviour
{

    [SerializeField]
    GameObject Key;
    private void Start()
    {
        Key.SetActive(false);
        Satvar.amountofenemies = 0;

    }

    private void Update()
    {
        if (Satvar.amountofenemies >=3)
        {
            Key.SetActive(true);
        }

    }

}


