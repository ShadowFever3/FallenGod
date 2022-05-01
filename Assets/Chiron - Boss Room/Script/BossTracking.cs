using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTracking : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (gameObject.name == "PlayerPositionBL" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 4;
            StatVarChiron.isChironLeft = true;
            StatVarChiron.isChironRight = false;
        }
        if (gameObject.name == "PlayerPositionML" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 2;
            StatVarChiron.isChironLeft = true;
            StatVarChiron.isChironRight = false;
        }
        if (gameObject.name == "PlayerPositionTL" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 0;
            StatVarChiron.isChironLeft = true;
            StatVarChiron.isChironRight = false;
        }
        if (gameObject.name == "PlayerPositionBR" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 5;
            StatVarChiron.isChironLeft = false;
            StatVarChiron.isChironRight = true;
        }
        if (gameObject.name == "PlayerPositionMR" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 3;
            StatVarChiron.isChironLeft = false;
            StatVarChiron.isChironRight = true;
        }
        if (gameObject.name == "PlayerPositionTR" && collision.name == "ChironInternet")
        {
            Debug.Log(collision.name);
            StatVarChiron.chironPosition = 1;
            StatVarChiron.isChironLeft = false;
            StatVarChiron.isChironRight = true;
        }
    }
}
