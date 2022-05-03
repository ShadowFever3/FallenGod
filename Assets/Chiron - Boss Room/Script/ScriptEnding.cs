using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnding : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < 53)
        {
            gameObject.transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            gameObject.transform.position = new Vector3(0, 0, -10);
        }
    }
}
