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

    }

    private void Update()
    {
        if (Satvar.playerScore >= 15)
        {
            Key.SetActive(true);
        }

    }

}


