using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField]
    GameObject Portals;

    [SerializeField]
    GameObject Key;

    private void Start()
    {
        Portals.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {

            Portals.SetActive(true);
           
        }
        

    }


}
