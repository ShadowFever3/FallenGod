using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{

    [SerializeField]
    GameObject Key;
    private void Start()
    {
        Key.SetActive(false);
    }

    private void Update()
    {
        if (Satvar.amountofenemies >= 2)
        {
            Key.SetActive(true);
        }

    }
   
}
