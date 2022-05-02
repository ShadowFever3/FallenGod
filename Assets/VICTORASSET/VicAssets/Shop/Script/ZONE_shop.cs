using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZONE_shop : MonoBehaviour
{
    public GameObject UI;
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "player")
        {
            UI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider obj)
    {
        if (obj.tag == "player")
        {
            UI.SetActive(false);
        }
    }
}
