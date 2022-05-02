using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    GameObject objectDestroy;


    public void DestroyGameObject()
    {
        Destroy(objectDestroy);

    }
}
