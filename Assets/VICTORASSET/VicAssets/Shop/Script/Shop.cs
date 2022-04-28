using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;

    public static bool isTriger { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
        canvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
          
         canvas.enabled = isTriger;
        
        
        


    }
}
