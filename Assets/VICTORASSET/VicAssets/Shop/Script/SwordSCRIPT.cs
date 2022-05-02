using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSCRIPT : MonoBehaviour
{
    [SerializeField]
    GameObject objectDestroy;


    public void DestroyGameObject()
    {
        Destroy(objectDestroy);

    }
}
