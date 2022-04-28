using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatVarChiron : MonoBehaviour
{
    //Player Position 
    // 0 -> Top Left
    // 1 -> Top Right
    // 2 -> Middle Left
    // 3 -> Middle Right
    // 4 -> Bottom Left
    // 5 -> Bottom Right
    public static int playerPosition { get; set; }
    public static bool isPlayerLeft { get; set; }
    public static bool isPlayerRight { get; set; }

}
