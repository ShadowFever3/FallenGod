using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilMAGIC : MonoBehaviour
{
    [SerializeField]
    GameObject objectDestroy;


    public void DestroyGameObject()
    {
        Destroy(objectDestroy);

    }
}
