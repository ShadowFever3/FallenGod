using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracking : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (gameObject.name == "PlayerPositionBL")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 4;
            StatVarChiron.isPlayerLeft = true;
            StatVarChiron.isPlayerRight = false;
        }
        if (gameObject.name == "PlayerPositionML")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 2;
            StatVarChiron.isPlayerLeft = true;
            StatVarChiron.isPlayerRight = false;
        }
        if (gameObject.name == "PlayerPositionTL")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 0;
            StatVarChiron.isPlayerLeft = true;
            StatVarChiron.isPlayerRight = false;
        }
        if (gameObject.name == "PlayerPositionBR")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 5;
            StatVarChiron.isPlayerLeft = false;
            StatVarChiron.isPlayerRight = true;
        }
        if (gameObject.name == "PlayerPositionMR")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 3;
            StatVarChiron.isPlayerLeft = false;
            StatVarChiron.isPlayerRight = true;
        }
        if (gameObject.name == "PlayerPositionTR")
        {
            Debug.Log(gameObject.name);
            StatVarChiron.playerPosition = 1;
            StatVarChiron.isPlayerLeft = false;
            StatVarChiron.isPlayerRight = true;
        }
    }
}
